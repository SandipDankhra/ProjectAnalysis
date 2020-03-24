using MoviesStoreApp.Domains;
using MoviesStoreApp.Models;
using System;

namespace MoviesStoreApp
{
    class Program
    {
        public static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("========== WelCome TO MovieStore ==========");
            int choice;
            MovieDomain movieDomain = new MovieDomain();
            
            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Remove Movie");
                Console.WriteLine("3.Add Actors");
                Console.WriteLine("4.Remove Actors");
                Console.WriteLine("5.Add MovieDeatils");
                Console.WriteLine("6.Exit");

                Console.Write("\n Enter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("====== Add movies =====");

                        Console.Write("Enter MovieName: ");
                        string MovieName = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter ReleaseDate: ");
                        DateTime ReleaseDate = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Enter MovieType: ");
                        string MovieType = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter MovieLanguage: ");
                        string MovieLanguage = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter MovieCost: ");
                        string MovieCost = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter ShootingDuration: ");
                        string ShootingDuration = Convert.ToString(Console.ReadLine());


                        var movies = new Movies();

                        movies.MovieName = MovieName;
                        movies.ReleaseDate = ReleaseDate;
                        movies.MovieType = MovieType;
                        movies.MovieLanguage = MovieLanguage;
                        movies.MovieCost = MovieCost;
                        movies.ShootingDuration = ShootingDuration;

                        movieDomain.AddMovies(movies);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine(" Invalid Choice !!!");
                        break;
                }
            } while (i > -1);
        }
    }
}
