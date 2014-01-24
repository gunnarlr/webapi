using firstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace firstWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        // Some fake data based of the Product model
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        // Be able to get all products in "database"
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // Get a single document
        public IHttpActionResult GetProduct(int id)
        {
            var cookies = Request.Headers.GetCookies();
            var numcookies = cookies.Count;
            Trace.WriteLine("Length " + numcookies + " " + cookies.FirstOrDefault().ToString());

            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
