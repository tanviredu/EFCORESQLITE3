using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Samurai
{
    public class onetoone
    {
        public static void AddSamuraiWithHorse()
        {
            var db = new SamuraiContext();
            var samurai = new SamuraiApp.Domain.Samurai
            {
                Name = "Tanvir Rahman Ornob"
            };

            samurai.Horse = new Horse
            {
                Name = "Black pearl"
            };

            db.Samurais.Add(samurai);
            db.SaveChanges();
            System.Console.WriteLine("[+] Samurai with Horse added");

            // if you use disconnected then 
            // you have to use the attach 
        }



        public static void query_onetoone()
        {
            var db = new SamuraiContext();

            var query = db.Samurais.Include(h => h.Horse).Where(s => s.Id == 2).ToList();

            foreach (var samurai in query)
            {
                System.Console.WriteLine($"[*] Name :  {samurai.Name}");
                System.Console.WriteLine($"[*] Horse Name :  {samurai.Horse.Name}");
            }
        }
    }
}