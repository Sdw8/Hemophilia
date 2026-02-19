namespace Hemophilia.Models;

public enum HemophiliaType
{
    TypeA,  // Гемофилия A — FVIII
    TypeB   // Гемофилия B — FIX
}

/// <summary>
/// Bleeding types exactly matching Table 7-2 rows in WFH Guidelines, 3rd edition.
/// Russian names from the official translation (pdf-2221).
/// </summary>
public enum BleedingType
{
    Joint,              // Внутрисуставное
    ShallowMuscle,      // В поверхностную мышцу / без НС повреждений (кроме подвздошно-поясничной)
    IliopsoasDeepMuscle,// В подвздошно-поясничную мышцу или глубокие мышцы с НС повреждениями
    Intracranial,       // Внутричерепное (ЦНС)
    ThroatNeck,         // Горло и шея
    Gastrointestinal,   // Желудочно-кишечные
    Renal,              // Почечное
    DeepLaceration,     // Глубокие резаные раны
    SurgeryMajor,       // Хирургическая операция (большая)
    SurgeryMinor        // Хирургическая операция (малая)
}

/// <summary>
/// Corresponds directly to table columns:
///   LowDose  = Низкодозный протокол  (ресурсные ограничения)
///   HighDose = Высокодозный протокол (нет ограничений)
/// </summary>
public enum DoseProtocol
{
    LowDose,  // Низкодозный (ресурсные ограничения)
    HighDose  // Высокодозный (нет ресурсных ограничений)
}

