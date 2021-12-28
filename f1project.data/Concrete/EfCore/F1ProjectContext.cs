using f1project.entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace f1project.data.Concrete.EfCore
{
    public class F1ProjectContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostDriver>()
                .HasKey(a=>new{a.DriverId,a.PostId});
            modelBuilder.Entity<PostTeam>()
                .HasKey(a=>new{a.TeamId,a.PostId});
            
            modelBuilder.Entity<PostDriver>()
                .HasOne(a=>a.Driver)
                .WithMany(a=>a.PostsDrivers)
                .HasForeignKey(a=>a.DriverId);
            modelBuilder.Entity<PostDriver>()
                .HasOne(a=>a.Post)
                .WithMany(a=>a.PostsDrivers)
                .HasForeignKey(a=>a.PostId);
            
            modelBuilder.Entity<PostTeam>()
                .HasOne(a=>a.Team)
                .WithMany(a=>a.PostsTeams)
                .HasForeignKey(a=>a.TeamId);
            modelBuilder.Entity<PostTeam>()
                .HasOne(a=>a.Post)
                .WithMany(a=>a.PostsTeams)
                .HasForeignKey(a=>a.PostId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<F1Driver> Drivers { get; set; }
        public DbSet<F1Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=F1Project;integrated security=true;");
            
            base.OnConfiguring(optionsBuilder);
        }
        
        
    }
}