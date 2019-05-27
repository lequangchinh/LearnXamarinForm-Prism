using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Task_Week6.ViewModels
{
    [Headers("Content-Type: application/json")]
    public interface IAppAPI
   
    {
        [Get("/photos?albumId={albumId}")]
        Task<ObservableCollection<Photo>> GetListImage(string albumId);

        [Get("/users?id={userId}")]
        Task<User> GetUser(string userID);

        [Get("/users")]
        Task<List<User>> GetUsers();

        [Get("/albums?userId={userId}")]
        Task<List<Album>> GetAlbums(string userID);

        [Get("/albums?id={albumID}")]
        Task<Album> GetAlbum(string albumID);

        [Get("/posts")]
        Task<List<Post>> GetPosts();

        [Get("/comments?postId={postId}")]
        Task<List<Comment>> GetComments(string postId);
    }
}
