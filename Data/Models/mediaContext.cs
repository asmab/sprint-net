using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

namespace Data.Models
{
    public partial class mediaContext : DbContext
    {
        static mediaContext()
        {
            Database.SetInitializer<mediaContext>(null);
        }

        public mediaContext()
            : base("Name=mediaContext")
        {
        }

        public DbSet<auteur> auteurs { get; set; }
        public DbSet<medium> media { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new auteurMap());
            modelBuilder.Configurations.Add(new mediumMap());
        }
    }
}
