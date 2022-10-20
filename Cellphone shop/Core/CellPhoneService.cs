using Cellphone_shop.IServices;
using CustomerManagement1.Database;
using CustomerManagement1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cellphone_shop.Core
{
    public class CellPhoneService : ICellPhoneService
    {
        CustomerDbContext DbContext;
        public CellPhoneService(CustomerDbContext _db)
        {
            DbContext = _db;
        }
        public IEnumerable<Products> GetProducts()
            
        {
            var products = DbContext.Product.ToList();
            return products;
        } 
        public Products AddProducts(Products products)
        {
            try
            {
                if (products != null)
                {
                    DbContext.Product.Add(products);
                    DbContext.SaveChanges();
                    return products;
                    Console.WriteLine("Added Successfully");

                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            return null;
        }
        public Products UpdateProducts(Products products)
        {
            try
            {
                {
                    DbContext.Entry(products).State = EntityState.Modified;
                    DbContext.SaveChanges();
                    
                }
                Console.WriteLine("Added Successfully");
            }
            catch
            {
                Console.WriteLine("error");
            }
            return products;
        }
        public Products DeleteProducts(int id)
        {
           
               

                    var products = DbContext.Product.FirstOrDefault(x => x.Id == id);
                    DbContext.Entry(products).State = EntityState.Deleted;
                    DbContext.SaveChanges();
                    return products;
          
                
           

            
        }


    }
}
