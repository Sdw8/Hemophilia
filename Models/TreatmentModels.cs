namespace Hemophilia.Models;

/// <summary>
/// One treatment phase row from WFH Table 7-2.
/// TargetMin/TargetMax are peak plasma factor levels in IU/dL (= %).
/// Duration is the display string exactly as in the table (e.g. "1–2", "8–21").
/// </summary>
public record TreatmentPhase(
    string Label,       // e.g. "Начальная терапия", "Поддерживающая", "Предоперационно"
    double TargetMin,   // peak factor level IU/dL lower bound
    double TargetMax,   // peak factor level IU/dL upper bound
    string Duration     // days, as shown in table (empty string = not specified)
);

/// <summary>
/// Complete treatment entry for one cell-group in WFH Table 7-2.
/// </summary>
public record TreatmentProtocol(
    HemophiliaType HemophiliaType,
    BleedingType BleedingType,
    DoseProtocol DoseProtocol,
    IReadOnlyList<TreatmentPhase> Phases
);

/// <summary>
/// Patient data entered by the user.
/// </summary>
public record PatientInput(
    HemophiliaType HemophiliaType,
    BleedingType BleedingType,
    DoseProtocol DoseProtocol,
    double WeightKg,
    double CurrentFactorLevel,  // % (IU/dL)
    bool IsUnder15                  // Гемофилия B, rFIX: ребёнок <15 лет — восстановление 0,7 МЕ/дл
);
