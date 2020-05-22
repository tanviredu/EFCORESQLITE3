using System;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertNewSamuraiWithAquote();
            //AddQuoteToExistingSmurai(1001);
            EagerLoadSamuraiwithQuote();

        }

        private static void EagerLoadSamuraiwithQuote()
        {
            // you need to import entity framework core 
            // to perform eager loading
            var db = new SamuraiContext();
            var samuraiWithQuotes = db.Samurais.Include(s => s.Quotes).ToList();

            foreach(var item in samuraiWithQuotes)
            {
                Console.WriteLine($"[+] SAMURAI NAME :{item.Name}");
                Console.WriteLine($"     [*] CLAN NAME :{item.Clan}");
                foreach(var q in item.Quotes)
                {
                    Console.WriteLine($"        [*] QUOTES  : {q.Text}");
                }
            }

            // if you want clan too with the eager loading
            var egear = db.Samurais.Include(s => s.Quotes).Include(c => c.Clan).ToList();

            foreach (var item in samuraiWithQuotes)
            {
                Console.WriteLine($"[+] SAMURAI NAME :{item.Name}");
                Console.WriteLine($"     [*] CLAN NAME :{item.Clan}");
                foreach (var q in item.Quotes)
                {
                    Console.WriteLine($"        [*] QUOTES  : {q.Text}");
                }
            }

        }

        private static void AddQuoteToExistingSmurai(int samuraiId)
        {
            // you can add this 
            // without attach 
            // with this trick
            // the quote has a samuraiId
            // if you pass it it will be added

            var db = new SamuraiContext();
            var quote = new Quote
            {
                Text = "i have a plan ",
                //pass the samurai id
                // so it will direcly save
                SamuraiId = samuraiId
            };
            
            
                        // now add it to the quotes table directly
            db.Quotes.Add(quote);
            
            db.SaveChanges();
            Console.WriteLine("[+] Data is inserted In the Quote");


            // use a disconnected instance

        }

        private static void InsertNewSamuraiWithAquote()
        {
            var db = new SamuraiContext();
            var samurai = new Samurai
            {
                Name = "Tanvir rahman",
                Quotes = new List<Quote>
                {
                    new Quote
                    {
                        Text = "I am happy that i become a stone cold killer"
                    },
                    new Quote
                    {
                        Text = "if you die in grudge you will be an evil"
                    }
                }
            };

            db.Samurais.Add(samurai);
            db.SaveChanges();
            Console.WriteLine("[+] Data is inserted");

            
        }
    }

        

        

      
    
}
