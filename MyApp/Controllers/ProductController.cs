using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product {
                    ProductId=1,
                    Name = "Product1",
                    Description = "Desc Prod 1"
                },
                new Product {
                    ProductId=2,
                    Name = "Product2",
                    Description = "Desc Prod 2"
                }
            };
        }

        [HttpGet]
        public Product Get(int id)
        {
            return new Product {
                    ProductId=id,
                    Name = "Product1",
                    Description = "Desc Prod 1"
                };
        }
    }
}