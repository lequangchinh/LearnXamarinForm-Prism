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

namespace TaskWeek6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListImageView : ContentPage
    {
        public ListImageView()
        {
            InitializeComponent();
            GetImage();

            lvwImage.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ImageView)e.SelectedItem;
                var page = new ImageDetailPage();
                page.BindingContext = item;
                Navigation.PushAsync(page);
            };
        }

        public void OnItemSelected(object sender, EventArgs e)
        {
            if (lvwImage.SelectedItem != null)
            {
                DisplayAlert("OnItemSelected", lvwImage.SelectedItem.ToString(), "OK");
            }
        }


        private async void GetImage()
        {
            HttpClient client = new HttpClient();

            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var images = await apiResponse.GetListImage("1");
            //var user = await apiResponse.GetUser("1");
            //lvwImage.ItemsSource = images;

            //var respone = await client.GetStringAsync("https://jsonplaceholder.typicode.com/photos");
            //var image = JsonConvert.DeserializeObject<List<ImageView>>(respone);

            //var resAlbum = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
            //var album = JsonConvert.DeserializeObject<List<AlbumsPhoto>>(resAlbum);

            //var imageAlbum = new List<ImageView>();
            var imageList = new List<ImageView>();
            /*
            foreach (var item in image)
            {
                if (item.AlbumId == 1)
                {
                    imageAlbum.Add(item);
                }
            }
            */

            foreach (var item in images)
            {
                if (item.Id < 51)
                {
                    imageList.Add(item);
                }
            }
            lvwImage.ItemsSource = imageList;
        }
    }
}