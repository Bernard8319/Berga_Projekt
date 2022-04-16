using Berga_Projekt.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berga_Projekt.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product> {
        
    };
        public async Task<ActionResult<List<Product>>> GetProducts(){
          return Ok(Products);
        }
    }
}
