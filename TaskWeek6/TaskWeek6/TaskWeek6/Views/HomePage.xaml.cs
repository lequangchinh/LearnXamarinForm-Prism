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
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
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
            if (item.Id == 0)
            {
                Detail = new NavigationPage(new About());
            }
            else if (item.Id == 1)
            {
                Detail = new NavigationPage(new ListImageView());
            }
            else if (item.Id == 2)
            {
                Detail = new NavigationPage(new About());
            }
            
        }
    }
}