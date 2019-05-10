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
	public partial class DeviceInfomationPageView : ContentPage
	{
		public DeviceInfomationPageView ()
		{
			InitializeComponent ();
            getDeviceInfo();
		}

        private void getDeviceInfo()
        {
            lblDeViceName.Text = $"{DeviceInfo.Name}";
            lblDeViceModel.Text = $"{DeviceInfo.Model}";
            lblDeviceManufacturer.Text= $"{DeviceInfo.Manufacturer}";
            lblDeviceVersion.Text = $"{DeviceInfo.Version}";
            lblDevicePlatfomr.Text = $"{DeviceInfo.Platform}";
            lblDeviceIdiom.Text = $"{DeviceInfo.Idiom}";
            lblDeviceType.Text = $"{DeviceInfo.DeviceType}";
        }
    }
}