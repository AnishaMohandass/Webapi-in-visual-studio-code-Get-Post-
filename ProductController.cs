using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webapi.Models;
using Webapi.Services;

namespace Webapi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
     public class ProductController : ControllerBase
     {
         ProductService _productService;
         public ProductController(ProductService productService) //constructor
         {
             this._productService = productService;
         }

         [HttpGet]
         public ActionResult Get()
         {
             return Ok(this._productService.GetProducts());
         }

         [HttpPost]
         public ActionResult Post(Product product)
         {
             this._productService.AddProduct(product);
             return Ok(this._productService.GetProducts());
         }
     }
}