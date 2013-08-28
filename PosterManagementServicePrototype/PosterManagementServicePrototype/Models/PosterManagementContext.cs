using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PosterManagementServicePrototype.Models.Mapping;

namespace PosterManagementServicePrototype.Models
{
    public partial class PosterManagementContext : DbContext
    {
        static PosterManagementContext()
        {
            Database.SetInitializer<PosterManagementContext>(null);
        }

        public PosterManagementContext()
            : base("Name=PosterManagementContext")
        {
        }

        public DbSet<Poster> Posters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PosterMap());
        }
    }
}
