using Catalog.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> ListaProdutos()
        {
            return Ok(new List<Product>()
            {
                new Product()
                {
                    Id = "048509438043",
                    Name = "Golf",
                    Category = "Volksvagem",
                    Description ="Good Car",
                    Image = "carro.png",
                    Price = 120003.43f
                },
                new Product()
                {
                    Id = "048509438043",
                    Name = "Pajero",
                    Category = "Mitsubich",
                    Description ="Good Car",
                    Image = "carro2.png",
                    Price = 200020.43f
                }
            });
        }
    }
}
