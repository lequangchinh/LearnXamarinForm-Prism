using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace TaskWeek4.ViewModels
{
    [Headers("Content-Type: application/json")]
    public interface IListProducts
    {
        [Get("/api/v1/products.json?brand={brand}")]
        Task<List<Product>> GetProducts(string brand);

        [Post("/api/v1/addMakeUp")]
        Task<Product> CreateListProducts([Body] Product product, [Header("Authorization")] string token);
    }
}
