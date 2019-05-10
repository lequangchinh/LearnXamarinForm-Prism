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
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomePageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
            if(item.Id == 0)
            {
                Detail = new NavigationPage(new NavigationView());
            }
            else if(item.Id == 1)
            {
                Detail = new NavigationPage(new ListProductsView());
            }
            else if(item.Id == 2)
            {
                Detail = new NavigationPage(new MapPageView());
            }
            else if(item.Id == 3)
            {
                Detail = new NavigationPage(new AppInfomationPage());
            }
            else if(item.Id == 4)
            {
                Detail = new NavigationPage(new DeviceInfomationPageView());
            }
        }
    }
}