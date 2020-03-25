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
                this.ExecuteNonQuery($"insert into Movies(MovieName,ReleaseDate,MovieType,MovieLanguage,MovieCost,ShootingDuration)values('{movies.MovieName}','{movies.ReleaseDate}','{movies.MovieType}','{movies.MovieLanguage}','{movies.MovieCost}','{movies.ShootingDuration}')");

                Console.WriteLine("\n  Record inserted Successfully ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* public void DeleteMovies(int MovieId)*/
        public void DeleteMovies(Movies movies)
        {
            try
            {
                this.ExecuteNonQuery($"delete from movies where MovieId={movies.MovieId}");
                /*this.ExecuteNonQuery("delete from movies where MovieId=MovieId");*/

                Console.WriteLine("\n  Record Deleted Successfully ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        } 
        public void ViewAllMovies()
        {
            try
            {
                var  reader = this.GetReader($"select * from Movies");
                /*Console.WriteLine(reader.Read());*/
                Console.WriteLine("MovieId  MovieName  ReleaseDate  MovieType  MovieLanguage  MovieCost ShootingDuration");
                
                while (reader.Read())
                {
                  
                    Console.WriteLine(reader.GetInt32(0) + "\t" 
                        + reader.GetString(1) + "\t" 
                        + reader.GetDateTimeOffset(2) + "\t"
                        + reader.GetString(3) + "\t" 
                        + reader.GetString(4) + "\t" 
                        + reader.GetString(5) + "\t" 
                        + reader.GetString(6));

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
