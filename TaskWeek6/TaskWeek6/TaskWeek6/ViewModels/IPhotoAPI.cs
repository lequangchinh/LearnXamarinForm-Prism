using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TaskWeek6.ViewModels
{
    [Headers("Content-Type: application/json")]
    public interface IPhotoAPI
    {
        // 
        [Get("/photos?albumId={albumId}")]
        Task<ObservableCollection<ImageView>> GetListImage(string albumId);

        [Get("/photos?Id={Id}")]
        Task<ImageView> GetImage(string Id);

        [Get("/users?id={userId}")]
        Task<User> GetUser(string userID);

        [Get("/users")]
        Task<List<User>> GetUsers();

        [Get("/albums?userId={userId}")]
        Task<List<AlbumsPhoto>> GetAlbums(string userID);

        [Get("/albums?id={albumID}")]
        Task<AlbumsPhoto> GetAlbum(string albumID);

        [Get("/posts")]
        Task<List<Post>> GetPosts();

        [Get("/comments?postId={postId}")]
        Task<List<Comment>> GetComments(string postId);


    }
}
