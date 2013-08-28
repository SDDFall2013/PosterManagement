using PosterManagementServicePrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PosterManagementServicePrototype
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public IEnumerable<Models.Poster> GetPosters()
        {
            using(var context = new PosterManagementServicePrototype.Models.PosterManagementContext())
            {
                return context.Posters.ToList();
            }
        }


        public void CreatePoster(Models.Poster poster)
        {
            using (var context = new PosterManagementServicePrototype.Models.PosterManagementContext())
            {
                context.Entry(poster).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }


        public void DeletePoster(int id)
        {
            using (var context = new PosterManagementServicePrototype.Models.PosterManagementContext())
            {
                Poster poster = context.Posters.FirstOrDefault(p => p.Id == id);
                if (poster != null)
                {
                    context.Entry(poster).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                    throw new InvalidOperationException("That poster doesn't exist");
            }
        }

        public Models.Poster UpdatePoster(Models.Poster poster)
        {
            using (var context = new PosterManagementServicePrototype.Models.PosterManagementContext())
            {
                if (context.Posters.Any(p => p.Id == poster.Id))
                {
                    context.Entry(poster).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return poster;
                }
                else
                    throw new InvalidOperationException("That poster doesn't exist");
            }
        }
    }
}
