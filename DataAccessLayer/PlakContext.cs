using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class PlakContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=PlakDb;Encrypt=false;Trusted_Connection=True;"); // Change connection string !!!
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AppUserMapping());
            //modelBuilder.ApplyConfiguration(new MealCategoryMapping());
            //modelBuilder.ApplyConfiguration(new MealMapping());
            //modelBuilder.ApplyConfiguration(new ProductMapping());
            //modelBuilder.ApplyConfiguration(new MealContentMapping());
            //modelBuilder.ApplyConfiguration(new CountryMapping());
            //modelBuilder.ApplyConfiguration(new CityMapping());
            //modelBuilder.ApplyConfiguration(new AddressMapping());
            //modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            //modelBuilder.ApplyConfiguration(new WeightsAndHeightsMapping());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Album>()
            .HasMany<Artist>(ar => ar.Artists)
            .WithMany(al => al.Albums);

        }

    }
}