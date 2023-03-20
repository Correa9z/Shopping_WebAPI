using Microsoft.EntityFrameworkCore;
using ShoppingWebAPI.DAL.Entities;

namespace ShoppingWebAPI.DAL
{
    public class DataBaseContext : DbContext
    {
        

        public DataBaseContext(DbContextOptions<DataBaseContext> option) : base(option) 
        {

        }

        private DbSet<Country> Countries { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();

        } 



    }
}
