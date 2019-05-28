using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThumbnailListImage : ContentPage
	{
		public ThumbnailListImage ()
		{
			InitializeComponent ();
            
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
        }
       
            
	}
}