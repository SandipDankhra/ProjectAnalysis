using MoviesStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStoreApp.Domains
{
    class ActorDomain:BaseDomain
    {
        public void AddActor(Actors actors)
        {
            try
            {
                Actors.Add(actors);
                SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
