using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskWeek4.ViewModels;

namespace TaskWeek4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationView : ContentPage
	{
		public NavigationView ()
		{
			InitializeComponent ();
		}

        public void OnButtonTextToSpeechClicked(Object obj, EventArgs e)
        {
            string strText = etrTextToSpeech.Text.ToString();
            DependencyService.Get<ITextToSpeech>().Speak(strText);
        }

    }
}