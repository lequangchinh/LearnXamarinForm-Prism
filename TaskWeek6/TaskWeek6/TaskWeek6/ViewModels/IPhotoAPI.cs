using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;

namespace TaskWeek6.ViewModels
{
    [Headers("Content-Type: application/json")]
    public interface IPhotoAPI
    {
        // 
        [Get("/photos?albumId={albumId}")]
        Task<List<ImageView>> GetListImage(string albumId);

        [Get("/users?id={userId}")]
        Task<User> GetUser(string userID);

        [Get("/albums?userId={userId}")]
        Task<List<AlbumsPhoto>> GetAlbums(string userID);

        [Get("/albums?id={albumID}")]
        Task<AlbumsPhoto> GetAlbum(string albumID);

        [Get("/posts")]
        Task<List<Post>> GetPosts();
    }
}
