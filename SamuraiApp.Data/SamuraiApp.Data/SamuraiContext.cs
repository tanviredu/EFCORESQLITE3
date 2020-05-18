using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Design;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {

        // adding entity 
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            /// REMEMBER YOU MUST MUST MUST
            /// MUST MUST MUST
            /// GIVE THE FULL PATH
            /// OF THE DB FILE
            /// WHERE YOU WANT TO CREATE
            /// DO NOT ADD JUST THE FILE 
            /// NAME
            options.UseSqlite("Data Source=A:\\database.db");
        }

        /*
         * 
         * Install-Package Microsoft.EntityFrameworkCore.Tools
            Add-Migration InitialCreate
            Update-Database

            AND AFTER THAT RUN THE CONSOLE 
            PROJECT WITH THE DOTNET RUN USING TERMINAL
            AND MAKE SURE THE 
            PROJECT THET CONTAINS THE DBCONTEXT FILE
            IN THIS CASE SAMURAIAPP.DATA SHOULD BE THE STARTUP PROJECT
        
         */
    }
}
