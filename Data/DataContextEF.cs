using System.Reflection.Emit;
using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Data
{
    public class DataContextEF : DbContext
    {
        
        public DbSet<Computer> ? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // base.OnConfiguring(options);
            if(!options.IsConfigured){
                options.UseSqlServer(
                    "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id= SA;Password=SQLfantuan1",
                    options => options.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            // base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Computer>().HasNoKey();
            modelBuilder.Entity<Computer>().HasKey( c => c.ComputerId);

                // .ToTable("TableName","SchemaName");
                // .ToTable("Computer","TutorialAppSchema");
// 
        }
    }
}