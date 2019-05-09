using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoCreateAPI.Models;

namespace DemoCreateAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 123, Name = "Product 1", Price = 25000},
            new Product {Id = 124, Name = "Product 2", Price = 24900},
            new Product {Id = 125, Name = "Product 3", Price = 10333},
            new Product {Id = 126, Name = "Product 4", Price = 24932},
            new Product {Id = 127, Name = "Product 5", Price = 58440},
            new Product {Id = 128, Name = "Product 6", Price = 24900},
            new Product {Id = 129, Name = "Product 7", Price = 12000},
            new Product {Id = 131, Name = "Product 8", Price = 24900}
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }
    }
}
