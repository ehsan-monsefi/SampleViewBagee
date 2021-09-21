using Domain.Entittes;
using Infrastructur.DAL.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructur.DAL
{
    public class SmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DbViewBage;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSliderConfiguration());
            base.OnModelCreating(modelBuilder);            
        }
        public DbSet<User> Users { get; set; } 
        public DbSet<ProductSlider> ProductSliders { get; set; }
    }
}
