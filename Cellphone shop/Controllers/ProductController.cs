using Cellphone_shop.IServices;
using CustomerManagement1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cellphone_shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICellPhoneService phoneService;
        public ProductController(ICellPhoneService product)
        {
            phoneService = product;
        }
       
        [HttpGet]
       
        public IEnumerable<Products> GetProducts()
           
        {
            return phoneService.GetProducts();
        }

        [HttpPost]

        public Products AddProducts(Products products)
        {

            return phoneService.AddProducts(products);
        }

        [HttpPut]

        public Products UpdateProducts(Products products)
        {
            return phoneService.UpdateProducts(products);
        }
        [HttpDelete]
      
        [Route("{Id:int}")]

        public Products DeleteProducts(int id )
        {
            return phoneService.DeleteProducts(id);
        }


    }
}
