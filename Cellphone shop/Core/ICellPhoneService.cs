using CustomerManagement1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cellphone_shop.IServices
{
    public interface ICellPhoneService
    {
        IEnumerable<Products> GetProducts();
       
      
        //Products GetProductsById(int id);
        Products AddProducts(Products products);
        Products UpdateProducts(Products products);
        Products DeleteProducts(int id);

    }
}
