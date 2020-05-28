using System;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        // this constractor will take the data
        // and then pass it to the startupconfiguration
        public SamuraiContext(DbContextOptions<SamuraiContext> options):base(options)
        {
        }

        // we create the scheme based on the 
        // class Definition
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quotes> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=A:\\EFCORE3.1sqlite3\\SamuraiFullapp\\databse.db");
        }

        // adding manytomany relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new {s.SamuraiId, s.BattleId});
            // adding a one to one relationship
            modelBuilder.Entity<Horse>().ToTable("Horses");
        }
        
        
    }
}