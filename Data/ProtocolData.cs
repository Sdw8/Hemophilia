using Hemophilia.Models;

namespace Hemophilia.Data;

/// <summary>
/// SINGLE SOURCE OF TRUTH — WFH Guidelines for Management of Hemophilia, 3rd Edition
/// Table 7-2: Practice patterns: peak plasma factor levels and duration of administration
/// Source PDFs: pdf-1863 (EN) and pdf-2221 (RU), page 107 / document page 105
///
/// Column mapping:
///   LowDose  = Низкодозный протокол  (Lower-dose practice pattern)
///   HighDose = Высокодозный протокол (Higher-dose practice pattern)
///
/// Note: For low-dose protocols, Hemophilia A and B values are identical in Table 7-2
/// except for IliopsoasDeepMuscle (A: 20–40 / 10–20; B: 15–30 / 10–20) and
/// Renal/DeepLaceration (A: 20–40; B: 15–30). All verified against both PDFs.
/// </summary>
public static class ProtocolData
{
    // ── phase helpers ────────────────────────────────────────────────────────

    private static TreatmentPhase P(string label, double min, double max, string days)
        => new(label, min, max, days);

    private const string INITIAL      = "Начальная терапия";
    private const string MAINTENANCE  = "Поддерживающая";
    private const string PREOP        = "Предоперационно";
    private const string POSTOP       = "Послеоперационно";
    private const string SINGLE_DOSE  = "Разовая доза";

    private static readonly IReadOnlyList<TreatmentProtocol> All = new List<TreatmentProtocol>
    {
        // ════════════════════════════════════════════════════════════════════
        // JOINT — Внутрисуставное
        // A low: 10-20 / 1-2d    A high: 40-60 / 1-2d
        // B low: 10-20 / 1-2d    B high: 40-60 / 1-2d   (identical to A)
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.Joint, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 10, 20, "1–2") }),
        new(HemophiliaType.TypeB, BleedingType.Joint, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 10, 20, "1–2") }),
        new(HemophiliaType.TypeA, BleedingType.Joint, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 60, "1–2") }),
        new(HemophiliaType.TypeB, BleedingType.Joint, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 60, "1–2") }),

        // ════════════════════════════════════════════════════════════════════
        // SHALLOW MUSCLE — Поверхностная мышца / без НС повреждений
        // A low: 10-20 / 2-3d    A high: 40-60 / 2-3d
        // B low: 10-20 / 2-3d    B high: 40-60 / 2-3d   (identical to A)
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.ShallowMuscle, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 10, 20, "2–3") }),
        new(HemophiliaType.TypeB, BleedingType.ShallowMuscle, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 10, 20, "2–3") }),
        new(HemophiliaType.TypeA, BleedingType.ShallowMuscle, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 60, "2–3") }),
        new(HemophiliaType.TypeB, BleedingType.ShallowMuscle, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 60, "2–3") }),

        // ════════════════════════════════════════════════════════════════════
        // ILIOPSOAS / DEEP MUSCLE WITH NV INJURY — Подвздошно-поясничная / глубокие мышцы
        // A low:  Initial 20-40/1-2d  Maintenance 10-20/3-5d
        // B low:  Initial 15-30/1-2d  Maintenance 10-20/3-5d
        // A high: Initial 80-100/1-2d Maintenance 30-60/3-5d
        // B high: Initial 60-80/1-2d  Maintenance 30-60/3-5d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.IliopsoasDeepMuscle, DoseProtocol.LowDose,
            new[] { P(INITIAL, 20, 40, "1–2"), P(MAINTENANCE, 10, 20, "3–5") }),
        new(HemophiliaType.TypeB, BleedingType.IliopsoasDeepMuscle, DoseProtocol.LowDose,
            new[] { P(INITIAL, 15, 30, "1–2"), P(MAINTENANCE, 10, 20, "3–5") }),
        new(HemophiliaType.TypeA, BleedingType.IliopsoasDeepMuscle, DoseProtocol.HighDose,
            new[] { P(INITIAL, 80, 100, "1–2"), P(MAINTENANCE, 30, 60, "3–5") }),
        new(HemophiliaType.TypeB, BleedingType.IliopsoasDeepMuscle, DoseProtocol.HighDose,
            new[] { P(INITIAL, 60, 80, "1–2"), P(MAINTENANCE, 30, 60, "3–5") }),

        // ════════════════════════════════════════════════════════════════════
        // INTRACRANIAL — Внутричерепное кровотечение
        // LOW-DOSE (A and B identical):
        //   Phase 1 (days 1-3):  50-80
        //   Phase 2 (days 4-7):  30-50  ← this row appears only in low-dose
        //   Phase 3 (days 8-14): 20-40
        // HIGH-DOSE A: Initial 80-100/1-7d   Maintenance 50/8-21d
        // HIGH-DOSE B: Initial 60-80/1-7d    Maintenance 30/8-21d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.Intracranial, DoseProtocol.LowDose,
            new[]
            {
                P("Дни 1–3",   50, 80, "1–3"),
                P("Дни 4–7",   30, 50, "4–7"),
                P("Дни 8–14",  20, 40, "8–14")
            }),
        new(HemophiliaType.TypeB, BleedingType.Intracranial, DoseProtocol.LowDose,
            new[]
            {
                P("Дни 1–3",   50, 80, "1–3"),
                P("Дни 4–7",   30, 50, "4–7"),
                P("Дни 8–14",  20, 40, "8–14")
            }),
        new(HemophiliaType.TypeA, BleedingType.Intracranial, DoseProtocol.HighDose,
            new[]
            {
                P(INITIAL,     80, 100, "1–7"),
                P(MAINTENANCE, 50, 50,  "8–21")
            }),
        new(HemophiliaType.TypeB, BleedingType.Intracranial, DoseProtocol.HighDose,
            new[]
            {
                P(INITIAL,     60, 80, "1–7"),
                P(MAINTENANCE, 30, 30, "8–21")
            }),

        // ════════════════════════════════════════════════════════════════════
        // THROAT AND NECK — Горло и шея
        // LOW-DOSE (A and B identical):
        //   Initial 30-50 / 1-3d    Maintenance 10-20 / 4-7d
        // HIGH-DOSE A: Initial 80-100/1-7d  Maintenance 50/8-14d
        // HIGH-DOSE B: Initial 60-80/1-7d   Maintenance 30/8-14d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.ThroatNeck, DoseProtocol.LowDose,
            new[] { P(INITIAL, 30, 50, "1–3"), P(MAINTENANCE, 10, 20, "4–7") }),
        new(HemophiliaType.TypeB, BleedingType.ThroatNeck, DoseProtocol.LowDose,
            new[] { P(INITIAL, 30, 50, "1–3"), P(MAINTENANCE, 10, 20, "4–7") }),
        new(HemophiliaType.TypeA, BleedingType.ThroatNeck, DoseProtocol.HighDose,
            new[] { P(INITIAL, 80, 100, "1–7"), P(MAINTENANCE, 50, 50, "8–14") }),
        new(HemophiliaType.TypeB, BleedingType.ThroatNeck, DoseProtocol.HighDose,
            new[] { P(INITIAL, 60, 80, "1–7"), P(MAINTENANCE, 30, 30, "8–14") }),

        // ════════════════════════════════════════════════════════════════════
        // GASTROINTESTINAL — Желудочно-кишечные
        // LOW-DOSE (A and B identical):
        //   Initial 30-50 / 1-3d    Maintenance 10-20 / 4-7d
        // HIGH-DOSE A: Initial 80-100/7-14d  Maintenance 50 (duration not specified)
        // HIGH-DOSE B: Initial 60-80/7-14d   Maintenance 30 (duration not specified)
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.Gastrointestinal, DoseProtocol.LowDose,
            new[] { P(INITIAL, 30, 50, "1–3"), P(MAINTENANCE, 10, 20, "4–7") }),
        new(HemophiliaType.TypeB, BleedingType.Gastrointestinal, DoseProtocol.LowDose,
            new[] { P(INITIAL, 30, 50, "1–3"), P(MAINTENANCE, 10, 20, "4–7") }),
        new(HemophiliaType.TypeA, BleedingType.Gastrointestinal, DoseProtocol.HighDose,
            new[] { P(INITIAL, 80, 100, "7–14"), P(MAINTENANCE, 50, 50, "до остановки") }),
        new(HemophiliaType.TypeB, BleedingType.Gastrointestinal, DoseProtocol.HighDose,
            new[] { P(INITIAL, 60, 80, "7–14"), P(MAINTENANCE, 30, 30, "до остановки") }),

        // ════════════════════════════════════════════════════════════════════
        // RENAL — Почечное
        // A low: 20-40 / 3-5d    A high: 50 / 3-5d
        // B low: 15-30 / 3-5d    B high: 40 / 3-5d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.Renal, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 20, 40, "3–5") }),
        new(HemophiliaType.TypeB, BleedingType.Renal, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 15, 30, "3–5") }),
        new(HemophiliaType.TypeA, BleedingType.Renal, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 50, 50, "3–5") }),
        new(HemophiliaType.TypeB, BleedingType.Renal, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 40, "3–5") }),

        // ════════════════════════════════════════════════════════════════════
        // DEEP LACERATION — Глубокие резаные раны
        // A low: 20-40 / 5-7d    A high: 50 / 5-7d
        // B low: 15-30 / 5-7d    B high: 40 / 5-7d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.DeepLaceration, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 20, 40, "5–7") }),
        new(HemophiliaType.TypeB, BleedingType.DeepLaceration, DoseProtocol.LowDose,
            new[] { P(SINGLE_DOSE, 15, 30, "5–7") }),
        new(HemophiliaType.TypeA, BleedingType.DeepLaceration, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 50, 50, "5–7") }),
        new(HemophiliaType.TypeB, BleedingType.DeepLaceration, DoseProtocol.HighDose,
            new[] { P(SINGLE_DOSE, 40, 40, "5–7") }),

        // ════════════════════════════════════════════════════════════════════
        // SURGERY MAJOR — Хирургическая операция (большая)
        // LOW-DOSE A:
        //   Pre-op: 60-80   Post-op d1-3: 30-40   d4-6: 20-30   d7-14: 10-20
        // LOW-DOSE B:
        //   Pre-op: 50-70   Post-op d1-3: 30-40   d4-6: 20-30   d7-14: 10-20
        // HIGH-DOSE A:
        //   Pre-op: 80-100  Post-op d1-3: 60-80   d4-6: 40-60   d7-14: 30-50
        // HIGH-DOSE B:
        //   Pre-op: 60-80   Post-op d1-3: 40-60   d4-6: 30-50   d7-14: 20-40
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.SurgeryMajor, DoseProtocol.LowDose,
            new[]
            {
                P(PREOP,       60, 80, "—"),
                P("Дни 1–3",   30, 40, "1–3"),
                P("Дни 4–6",   20, 30, "4–6"),
                P("Дни 7–14",  10, 20, "7–14")
            }),
        new(HemophiliaType.TypeB, BleedingType.SurgeryMajor, DoseProtocol.LowDose,
            new[]
            {
                P(PREOP,       50, 70, "—"),
                P("Дни 1–3",   30, 40, "1–3"),
                P("Дни 4–6",   20, 30, "4–6"),
                P("Дни 7–14",  10, 20, "7–14")
            }),
        new(HemophiliaType.TypeA, BleedingType.SurgeryMajor, DoseProtocol.HighDose,
            new[]
            {
                P(PREOP,       80, 100, "—"),
                P("Дни 1–3",   60, 80,  "1–3"),
                P("Дни 4–6",   40, 60,  "4–6"),
                P("Дни 7–14",  30, 50,  "7–14")
            }),
        new(HemophiliaType.TypeB, BleedingType.SurgeryMajor, DoseProtocol.HighDose,
            new[]
            {
                P(PREOP,       60, 80,  "—"),
                P("Дни 1–3",   40, 60,  "1–3"),
                P("Дни 4–6",   30, 50,  "4–6"),
                P("Дни 7–14",  20, 40,  "7–14")
            }),

        // ════════════════════════════════════════════════════════════════════
        // SURGERY MINOR — Хирургическая операция (малая)
        // LOW-DOSE (A and B identical):
        //   Pre-op: 40-80    Post-op: 20-50 / 1-5d
        // HIGH-DOSE (A and B identical):
        //   Pre-op: 50-80    Post-op: 30-80 / 1-5d
        // ════════════════════════════════════════════════════════════════════
        new(HemophiliaType.TypeA, BleedingType.SurgeryMinor, DoseProtocol.LowDose,
            new[] { P(PREOP, 40, 80, "—"), P(POSTOP, 20, 50, "1–5") }),
        new(HemophiliaType.TypeB, BleedingType.SurgeryMinor, DoseProtocol.LowDose,
            new[] { P(PREOP, 40, 80, "—"), P(POSTOP, 20, 50, "1–5") }),
        new(HemophiliaType.TypeA, BleedingType.SurgeryMinor, DoseProtocol.HighDose,
            new[] { P(PREOP, 50, 80, "—"), P(POSTOP, 30, 80, "1–5") }),
        new(HemophiliaType.TypeB, BleedingType.SurgeryMinor, DoseProtocol.HighDose,
            new[] { P(PREOP, 50, 80, "—"), P(POSTOP, 30, 80, "1–5") }),
    };

    // ── Public API ───────────────────────────────────────────────────────────

    public static TreatmentProtocol? Get(HemophiliaType type, BleedingType bleeding, DoseProtocol dose)
        => All.FirstOrDefault(p =>
            p.HemophiliaType == type &&
            p.BleedingType == bleeding &&
            p.DoseProtocol == dose);
}
