using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoDependencyService.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoDependencyService.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSpeakButtonClicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak("Hello!");
        }
    }
}