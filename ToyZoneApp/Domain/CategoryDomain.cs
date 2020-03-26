using ToyZoneApp.Context;
using System;

using System.Collections.Generic;
using System.Text;
using ToyZoneApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyZoneApp.Domain
{
    [Table("Categorys")]
    public class CategoryDomain:BaseContext
    {
        public void AddCategory(Categorys categorys)
        {
            try
            {
                Categorys.AddRangeAsync(categorys);
                SaveChangesAsync();
              
          
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ViewCategory()
        {
            try
            {
                Categorys categorys = new Categorys();
                Console.WriteLine("CategoryId\tCategoryName\tCategoryDescription");
                foreach(var category in Categorys)
                {
                    Console.WriteLine($"{category.CategoryId}\t{category.CategoryName}\t{category.Description}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
        
        public void RemoveCategory(Categorys categorys)
        {
            try
            {
               // Console.WriteLine(categorys.CategoryId);
                Categorys.Remove(categorys);
                SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
      
    }
}
