using Instagram.Infrastructure.Data.Configurations;
using Instagram.Infrastructure.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace Instagram.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Soap2DayDb;User Id=sa;Password=Soap2dayy@a;TrustServerCertificate=True;");
        }
        
             
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
    
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FollowerConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Follower> Followers { get; set; }


    }
}