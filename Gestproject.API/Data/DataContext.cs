using Gestproject.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace Gestproject.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Investigador> Investigadors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasIndex(c => c.NombreProyecto).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Investigador>().HasIndex(c => c.Id).IsUnique();
        }
    }
}
