using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using ToyZoneApp.Context;
using ToyZoneApp.Models;

namespace ToyZoneApp.Domain
{
    public class ProductDomain
    {
        BaseContext db = new BaseContext();
        public void AddProduct(Products products)
        {
            try
            {

                db.Products.Add(products);
                db.SaveChangesAsync();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Products> GetProduct()
        {

            return db.Products.ToList();

        }

        public void RemoveProduct(Products products)
        {
            try
            {

                db.Products.Remove(products);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
