using System;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create a samurai context class
            // apply simple Crud data

            // REmember because this is a in memory data 
            // you need to copy the db file in to the console project

            GetSamurai();
            AddSamurai();
            GetSamurai();
        }

        private static void AddSamurai()
        {
            var db = new SamuraiContext();
            var samurai = new Samurai
            {
                Name = "Tanvir Rahman"
            };

            db.Add(samurai);
            db.SaveChanges();
        }

        // add the samurai

        private static void GetSamurai()
        {
            var db = new SamuraiContext();
            var query = from s in db.Samurais
                            select s;
            // write a lopp to get all

            foreach(var s in query)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
