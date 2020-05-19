using Microsoft.EntityFrameworkCore;
using System;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=A:\\EFCORE3.1sqlite3\\Samurai\\database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // so this is a relationship declaration
            // of the many to many relationship
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.SamuraiId, s.BattleId });
            modelBuilder.Entity<Horse>().ToTable("Horses");
        }
    }
}

/*
 first you need to add the Microsoft.EntityFrameworkCore.Design in the Samuraiapp.domain
 then you need to add the SamuraiApp.Data project as a startappproject
 then you need ti apply this migration
 Add-Migration initial_migrate -Project SamuraiApp.Data
     
     */
