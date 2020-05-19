using System;
using System;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;

namespace SamuraiApp
{
    class Program
    {
        static void Main(string[] args)
        {

            GetSamurai();
            AddSamurai();
            GetSamurai();

        }

        private static void AddSamurai()
        {
            var db = new SamuraiContext();
            var samurai = new Samurai
            {
                Name = "Tanvir rahman"
            };
            db.Add(samurai);
            db.SaveChanges();
        }

        private static void GetSamurai()
        {
            var db = new SamuraiContext();
            var query = from s in db.Samurais select s;
            foreach (var s in query)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
