using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "LifeUP!", Price = 1 },
            new Product { Id = 2, Name = "Sword", Category = "MeleWeapon", Price = 7.89M },
            new Product { Id = 3, Name = "Hammer", Category = "MeleWeapon", Price = 16.99M},
            new Product { Id = 3, Name = "Rod", Category = "MagicWeapon", Price = 73.99M}
                       
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
