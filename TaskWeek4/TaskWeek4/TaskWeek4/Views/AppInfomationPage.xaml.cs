using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TaskWeek4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppInfomationPage : ContentPage
	{

		public AppInfomationPage ()
		{
			InitializeComponent ();
            		GetInfomationApp();
		}

        private void GetInfomationApp()
        {
            lblAppName.Text = $"{AppInfo.Name}";
            lblAppPackageName.Text = $"{AppInfo.PackageName}";
            lblAppVersion.Text = $"{AppInfo.Version}";
        }
    }
}