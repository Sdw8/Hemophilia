using System.Collections.ObjectModel;
using Hemophilia.Models;
using Hemophilia.Services;

namespace Hemophilia.ViewModels;

public class ResultViewModel
{
    public string HemophiliaLabel { get; }
    public string BleedingLabel   { get; }
    public string ProtocolLabel   { get; }
    public string WeightLabel     { get; }
    public string CurrentLevel    { get; }
    public string FormulaUsed     { get; }

    public ObservableCollection<PhaseDisplayRow> Phases { get; }

    public ResultViewModel(PatientInput input, IReadOnlyList<DoseCalculator.PhaseResult> results)
    {
        HemophiliaLabel = input.HemophiliaType == HemophiliaType.TypeA
            ? "Гемофилия A (FVIII)"
            : $"Гемофилия B (FIX){(input.IsUnder15 ? ", ребёнок <15 лет" : "")}";

        BleedingLabel = BleedingTypeName(input.BleedingType);
        ProtocolLabel = input.DoseProtocol == DoseProtocol.LowDose
            ? "Низкодозный (ресурсные ограничения)"
            : "Высокодозный (без ресурсных ограничений)";
        WeightLabel   = $"{input.WeightKg} кг";
        CurrentLevel  = $"{input.CurrentFactorLevel}%";
        FormulaUsed   = DoseCalculator.FormulaDescription(input.HemophiliaType, input.IsUnder15);

        Phases = new ObservableCollection<PhaseDisplayRow>(
            results.Select(r => new PhaseDisplayRow(r)));
    }

    private static string BleedingTypeName(BleedingType bt) => bt switch
    {
        BleedingType.Joint               => "Внутрисуставное",
        BleedingType.ShallowMuscle       => "Мышечное (поверхностное)",
        BleedingType.IliopsoasDeepMuscle => "Мышечное (глубокое / подвздошно-поясничное)",
        BleedingType.Intracranial        => "Внутричерепное (ЦНС)",
        BleedingType.ThroatNeck          => "Горло и шея",
        BleedingType.Gastrointestinal    => "Желудочно-кишечное",
        BleedingType.Renal               => "Почечное",
        BleedingType.DeepLaceration      => "Глубокие резаные раны",
        BleedingType.SurgeryMajor        => "Хирургическая операция (большая)",
        BleedingType.SurgeryMinor        => "Хирургическая операция (малая)",
        _                                => bt.ToString()
    };
}

public class PhaseDisplayRow
{
    public string Label       { get; }
    public string DoseRange   { get; }   // "500 — 1 000 МЕ"
    public string TargetRange { get; }   // "10–20%" — percent is cleaner and universal
    public string Duration    { get; }

    public PhaseDisplayRow(DoseCalculator.PhaseResult r)
    {
        Label      = r.Label;
        DoseRange  = $"{r.DoseMin:0} — {r.DoseMax:0} МЕ";
        TargetRange = r.TargetMin == r.TargetMax
            ? $"{r.TargetMin:0}%"
            : $"{r.TargetMin:0}–{r.TargetMax:0}%";
        Duration   = r.Duration;
    }
}
