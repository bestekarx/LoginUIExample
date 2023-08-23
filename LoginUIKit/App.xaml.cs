using LoginUIKit.Pages.Calashop;

namespace LoginUIKit;

public partial class App : Application
{
    public App()
    {
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF5cXmtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWXhfd3RSRWBZVEF3WkQ=");

        InitializeComponent();

        MainPage = new LoginPage();
    }
}