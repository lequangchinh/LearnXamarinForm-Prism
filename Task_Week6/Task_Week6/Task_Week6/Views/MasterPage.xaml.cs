using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Task_Week6.ViewModels;
using System.Runtime.CompilerServices;

namespace Task_Week6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView;

        public MasterPage()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItems;
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ItemMenu> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ItemMenu>(new[]
                {
                    new ItemMenu { Id = 0, Title = "Thông tin" },
                    new ItemMenu { Id = 1, Title = "Duyệt ảnh" },
                    new ItemMenu { Id = 2, Title = "Thumbnail" },
                    new ItemMenu { Id = 3, Title = "Bài viết" },
                    new ItemMenu { Id = 4, Title = "Đăng xuất" }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}