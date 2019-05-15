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

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListImageView : ContentPage
	{
		public ListImageView ()
		{
			InitializeComponent ();
            GetImage();
		}

        private async void GetImage()
        {
            HttpClient client = new HttpClient();

            var respone = await client.GetStringAsync("https://jsonplaceholder.typicode.com/photos");
            var image = JsonConvert.DeserializeObject<List<ImageView>>(respone);

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
            foreach (var item in image)
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