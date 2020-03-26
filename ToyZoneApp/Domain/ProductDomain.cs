using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using ToyZoneApp.Context;
using ToyZoneApp.Models;

namespace ToyZoneApp.Domain
{
    public class ProductDomain : BaseContext
    {

        public void AddProduct(Products products)
        {
            try
            {
                Products.Add(products);
                SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Products> GetProduct()
        {

            return Products.ToList();

        }

        public void RemoveProduct(Products products)
        {
            try
            {

                Products.Remove(products);
                SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
