using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Genre> Genres => Set<Genre>();

        public GameStoreContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(

                new  { Id = 1, Name = "RPG" },
                new  { Id = 2, Name = "Action" },
                new  { Id = 3, Name = "Sport" },
                new  { Id = 4, Name = "Racing"}

            );
        }
    }
}
