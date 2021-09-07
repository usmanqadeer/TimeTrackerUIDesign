using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFUITimeTrackerDesign.Services;
using XFUITimeTrackerDesign.Views;

namespace XFUITimeTrackerDesign
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzcyNDU0QDMxMzgyZTM0MmUzMEpRMVFpWHpWZjJ4SXJnTHRrLzlFSTZNcTQ5bHlRb1lMY0N1cjc5V2EzV009");
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
