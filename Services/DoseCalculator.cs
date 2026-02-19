using Hemophilia.Models;

namespace Hemophilia.Services;

/// <summary>
/// Dose calculation formulas — WFH Guidelines, 3rd Edition, Chapter 5, pages 68–70.
///
/// ── FVIII (Гемофилия A) ── EN p.68 / RU p.68 ──────────────────────────────
///   "multiply weight in kg by the FVIII level desired (IU/dL), then multiply by 0.5"
///   Доза (МЕ) = Вес (кг) × (Целевой уровень − Исходный уровень) × 0,5
///   Пример: 50 кг × 40 МЕ/дл × 0,5 = 1000 МЕ
///
/// ── FIX (Гемофилия B, rFIX) ── EN p.70 / RU p.70 ──────────────────────────
///   "Unmodified recombinant FIX (rFIX) CFCs have a lower recovery than
///    plasma-derived FIX CFCs, such that each unit of FIX infused per kg
///    will raise FIX activity by approximately 0.8 IU/dL in adults and
///    0.7 IU/dL in children under 15 years of age."
///
///   Взрослые ≥15 лет:  Доза (МЕ) = Вес × (Целевой − Исходный) ÷ 0,8
///   Дети     <15 лет:  Доза (МЕ) = Вес × (Целевой − Исходный) ÷ 0,7
///   Пример взрослый: 50 кг × 40 МЕ/дл ÷ 0,8 = 2500 МЕ
///   Пример ребёнок:  50 кг × 40 МЕ/дл ÷ 0,7 ≈ 2857 МЕ
/// </summary>
public static class DoseCalculator
{
    public record PhaseResult(
        string Label,
        double DoseMin,
        double DoseMax,
        string Duration,
        double TargetMin,
        double TargetMax
    );

    public static IReadOnlyList<PhaseResult> Calculate(
        PatientInput input,
        IReadOnlyList<TreatmentPhase> phases)
    {
        return phases
            .Select(phase => new PhaseResult(
                Label:     phase.Label,
                DoseMin:   Math.Round(Compute(input, phase.TargetMin)),
                DoseMax:   Math.Round(Compute(input, phase.TargetMax)),
                Duration:  phase.Duration,
                TargetMin: phase.TargetMin,
                TargetMax: phase.TargetMax))
            .ToList();
    }

    private static double Compute(PatientInput input, double targetPeak)
    {
        double delta = Math.Max(0, targetPeak - input.CurrentFactorLevel);

        return input.HemophiliaType switch
        {
            // FVIII: dose = weight × delta × 0.5
            HemophiliaType.TypeA =>
                input.WeightKg * delta * 0.5,

            // rFIX child <15: dose = weight × delta / 0.7
            HemophiliaType.TypeB when input.IsUnder15 =>
                input.WeightKg * delta / 0.7,

            // rFIX adult ≥15: dose = weight × delta / 0.8
            HemophiliaType.TypeB =>
                input.WeightKg * delta / 0.8,

            _ => throw new ArgumentOutOfRangeException(nameof(input.HemophiliaType))
        };
    }

    public static string FormulaDescription(HemophiliaType type, bool isUnder15) =>
        type == HemophiliaType.TypeA
            ? "Доза (МЕ) = Вес × (Целевой − Исходный уровень) × 0,5  [FVIII]"
            : isUnder15
                ? "Доза (МЕ) = Вес × (Целевой − Исходный уровень) ÷ 0,7  [rFIX, дети <15 лет]"
                : "Доза (МЕ) = Вес × (Целевой − Исходный уровень) ÷ 0,8  [rFIX, взрослые ≥15 лет]";
}
