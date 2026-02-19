using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Hemophilia.Data;
using Hemophilia.Models;
using Hemophilia.Services;

namespace Hemophilia.ViewModels;

public class MainViewModel : INotifyPropertyChanged, IDataErrorInfo
{
    // ── Backing fields ────────────────────────────────────────────────────────
    private HemophiliaType _hemophiliaType   = HemophiliaType.TypeA;
    private BleedingType   _bleedingType     = BleedingType.Joint;
    private DoseProtocol   _doseProtocol     = DoseProtocol.LowDose;
    private string         _weightText       = string.Empty;
    private string         _currentLevelText = "0";
    private bool           _isUnder15;

    // ── Properties ────────────────────────────────────────────────────────────
    public HemophiliaType HemophiliaType
    {
        get => _hemophiliaType;
        set
        {
            _hemophiliaType = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsTypeBSelected));
            OnPropertyChanged(nameof(FormulaHint));
        }
    }

    public BleedingType BleedingType
    {
        get => _bleedingType;
        set { _bleedingType = value; OnPropertyChanged(); }
    }

    public DoseProtocol DoseProtocol
    {
        get => _doseProtocol;
        set { _doseProtocol = value; OnPropertyChanged(); OnPropertyChanged(nameof(DoseProtocolDescription)); }
    }

    public string WeightText
    {
        get => _weightText;
        set { _weightText = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanCalculate)); }
    }

    public string CurrentLevelText
    {
        get => _currentLevelText;
        set { _currentLevelText = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanCalculate)); }
    }

    public bool IsUnder15
    {
        get => _isUnder15;
        set { _isUnder15 = value; OnPropertyChanged(); OnPropertyChanged(nameof(FormulaHint)); }
    }

    public bool IsTypeBSelected => HemophiliaType == HemophiliaType.TypeB;

    public string FormulaHint =>
        DoseCalculator.FormulaDescription(HemophiliaType, IsUnder15 && IsTypeBSelected);

    public string DoseProtocolDescription => DoseProtocol == DoseProtocol.LowDose
        ? "Низкодозный — при ресурсных ограничениях"
        : "Высокодозный — без ресурсных ограничений";

    // ── Validation ────────────────────────────────────────────────────────────
    public string Error => string.Empty;

    public string this[string prop] => prop switch
    {
        nameof(WeightText)       => ValidatePositive(WeightText, "Вес"),
        nameof(CurrentLevelText) => ValidateLevel(CurrentLevelText),
        _                        => string.Empty
    };

    private static string ValidatePositive(string val, string field)
    {
        if (string.IsNullOrWhiteSpace(val)) return $"{field}: обязательное поле";
        if (!TryParseDouble(val, out double d) || d <= 0)
            return $"{field}: введите число > 0";
        return string.Empty;
    }

    private static string ValidateLevel(string val)
    {
        if (string.IsNullOrWhiteSpace(val)) return "Обязательное поле";
        if (!TryParseDouble(val, out double d) || d < 0 || d > 100)
            return "Введите значение от 0 до 100";
        return string.Empty;
    }

    public bool CanCalculate =>
        string.IsNullOrEmpty(this[nameof(WeightText)]) &&
        string.IsNullOrEmpty(this[nameof(CurrentLevelText)]);

    // ── Commands ──────────────────────────────────────────────────────────────
    public ICommand CalculateCommand { get; }

    public event Action<ResultViewModel>? OpenResultRequested;

    public MainViewModel()
    {
        CalculateCommand = new RelayCommand(_ => Calculate(), _ => CanCalculate);
    }

    private void Calculate()
    {
        TryParseDouble(WeightText, out double weight);
        TryParseDouble(CurrentLevelText, out double current);

        var input = new PatientInput(
            HemophiliaType, BleedingType, DoseProtocol,
            weight, current,
            IsUnder15 && IsTypeBSelected);

        var protocol = ProtocolData.Get(HemophiliaType, BleedingType, DoseProtocol);
        if (protocol is null) return;

        var results = DoseCalculator.Calculate(input, protocol.Phases);
        OpenResultRequested?.Invoke(new ResultViewModel(input, results));
    }

    private static bool TryParseDouble(string text, out double value)
        => double.TryParse(
            text?.Replace(',', '.'),
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out value);

    // ── INotifyPropertyChanged ────────────────────────────────────────────────
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

public class RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null) : ICommand
{
    public bool CanExecute(object? p) => canExecute?.Invoke(p) ?? true;
    public void Execute(object? p)    => execute(p);
    public event EventHandler? CanExecuteChanged
    {
        add    => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}
