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
            ActorDomain actorDomain = new ActorDomain();

            var movies = new Movies();
            var actors = new Actors();
            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Remove Movie");
                Console.WriteLine("3.View Movie");
                Console.WriteLine("4.Add Actors");
                Console.WriteLine("5.Remove Actors");
                Console.WriteLine("6.View Actor");
                Console.WriteLine("7.Add MovieDeatils");
                Console.WriteLine("0.Exit");

                Console.Write("\nEnter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n====== Add movies =====");

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

                        movies.MovieName = MovieName;
                        movies.ReleaseDate = ReleaseDate;
                        movies.MovieType = MovieType;
                        movies.MovieLanguage = MovieLanguage;
                        movies.MovieCost = MovieCost;
                        movies.ShootingDuration = ShootingDuration;

                        movieDomain.AddMovies(movies);
                        break;

                    case 2:
                        Console.WriteLine("\n====== View All movie =====");
                        movieDomain.ViewAllMovies();

                        Console.WriteLine("\n====== Remove movie =====");
                        Console.Write("\nEnter Movie ID : ");
                        int MovieId = Convert.ToInt32(Console.ReadLine());
                        movies.MovieId = MovieId;
                        movieDomain.DeleteMovies(movies);
                        break;

                    case 3:
                        Console.WriteLine("\n====== View All movie =====");
                        movieDomain.ViewAllMovies();
                        break;
                    case 4:
                        Console.WriteLine("\n====== Add Actor =====");

                        Console.Write("Enter Actor Name: ");
                        string ActorName = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter Actor Fees: ");
                        string Fees = Convert.ToString(Console.ReadLine());

                        actors.ActorName = ActorName;
                        actors.Fees = Fees;

                        actorDomain.AddActor(actors);

                        break;
                    case 5:
                        Console.WriteLine("\n====== View All Actor =====");
                        //actorDomain.ViewAllActor();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine(" Invalid Choice !!!");
                        break;
                }
            } while (i > -1);
        }
    }
}
