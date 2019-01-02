using System.Collections.Generic;
using Webapi.Models;

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace Webapi.Services
{
    public class ProductService
    {
        List<Product> _productList = new List<Product>() {
                new Product {
                    ProductId = 1,
                    Name = "Lenovo k8 note", 
                    Description = "4GB RAM and 64GB Internal Storage"
                },
                 new Product {
                    ProductId = 2,
                    Name = "Panasonic P55 NOVO", 
                    Description = "1GB RAM and 5GB Internal Storage"
                },
                 new Product {
                    ProductId = 3,
                    Name = "Samsung J5 Prime", 
                    Description = "4GB RAM and 16GB Internal Storage"
                }

            };
        

        // public ProductService()
        // {
        //     var result = _productList;
        // }


        public List<Product> GetProducts()
        {
            return _productList;
        }
        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }
    }
}