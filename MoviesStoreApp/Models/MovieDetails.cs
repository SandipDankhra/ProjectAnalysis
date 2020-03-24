using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStoreApp.Models
{
    public class MovieDetails
    {

        public int MovieDetailId { get; set; }

        public int ActorsId { get; set; }
        
        public int MovieId { get; set; }
        
        public String Role { get; set; }
       
    }
}
