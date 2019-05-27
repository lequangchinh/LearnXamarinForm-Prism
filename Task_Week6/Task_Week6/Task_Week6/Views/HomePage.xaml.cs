using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Task_Week6.ViewModels;
using System;

namespace Task_Week6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ItemMenu;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;

            if (item.Id == 0)
            {
                Detail = new NavigationPage(new AboutPage());
            }
            else if (item.Id == 1)
            {
                Detail = new NavigationPage(new AboutPage());
            }
            else if (item.Id == 2)
            {
                Detail = new NavigationPage(new AboutPage());
            }
            else if (item.Id == 3)
            {
                Detail = new NavigationPage(new AboutPage());
            }
            else if (item.Id == 4)
            {
                Navigation.PopToRootAsync();
            }

        }
    }
}