using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using TaskWeek6.ViewModels;
using Xamarin.Forms.Xaml;
using Refit;
using Xamarin.Forms.PlatformConfiguration;

namespace TaskWeek6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListImageView : ContentPage
    {
        public ListImageView()
        {
            InitializeComponent();
        }
    }
}