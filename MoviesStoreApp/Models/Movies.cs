using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStoreApp.Models
{
    public class Movies
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public string MovieType { get; set; }

        public string MovieLanguage { get; set; }

        public string MovieCost { get; set; }

        public string ShootingDuration { get; set; }
    }
}
