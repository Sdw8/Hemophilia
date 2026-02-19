using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using Hemophilia.ViewModels;

namespace Hemophilia.Views;

public partial class MainWindow : Window
{
    // Windows 11 dark title bar via DWM
    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
    private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

    public MainWindow()
    {
        InitializeComponent();
        var vm = new MainViewModel();
        vm.OpenResultRequested += result =>
        {
            var win = new ResultWindow { DataContext = result, Owner = this };
            win.ShowDialog();
        };
        DataContext = vm;
    }

    protected override void OnSourceInitialized(EventArgs e)
    {
        base.OnSourceInitialized(e);
        EnableDarkTitleBar();
    }

    private void EnableDarkTitleBar()
    {
        var hwnd = new WindowInteropHelper(this).Handle;
        int dark = 1;
        DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref dark, sizeof(int));
    }
}
