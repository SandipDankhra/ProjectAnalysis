using MoviesStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStoreApp.Domains
{
    class MovieDomain : BaseDomain
    {

        public void AddMovies(Movies movies)
        {
            try
            {

                this.ExecuteNonQuery($"insert into Movies (MovieName,ReleaseDate,MovieType,MovieLanguage,MovieCost,ShootingDuration) " +
                      $"values({movies.MovieName},{movies.ReleaseDate},{movies.MovieType},{movies.MovieLanguage},{movies.MovieCost},{movies.ShootingDuration})");

                Console.Read();
                Console.WriteLine("Record inserted");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteMovies(Movies movies)
        {

        }
    }
}
