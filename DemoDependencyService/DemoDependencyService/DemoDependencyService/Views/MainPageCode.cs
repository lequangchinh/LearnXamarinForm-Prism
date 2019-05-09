using System;
using System.Collections.Generic;
using System.Text;
using DemoDependencyService.ViewModels;
using Xamarin.Forms;

namespace DemoDependencyService.Views
{
    class MainPageCode : ContentPage
    {
        public MainPageCode()
        {
            var speak = new Button
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            speak.Clicked += (sender, e) => {
                DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
            };
            Content = speak;
        }
    }
}
