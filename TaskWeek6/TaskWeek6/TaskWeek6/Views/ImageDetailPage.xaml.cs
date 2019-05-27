using Refit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageDetailPage : ContentPage 
	{
        string albumId;
        public ImageDetailPage()
        {
            InitializeComponent();
            
            //albumId = lblAlbumId.Text;
           // GetAlbumTitle(albumId);
        }
        public async void GetAlbumTitle(string albumID)
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var album = await apiResponse.GetAlbum(albumID);

            //lblAlbum.Text = album.Title;
        }

        public async void GetUserName(string userid)
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var user = await apiResponse.GetUser(userid);
        }
    }
}