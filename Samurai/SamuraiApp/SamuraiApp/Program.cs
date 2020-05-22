using System;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;
using System.IO;

namespace SamuraiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertNewSamuraiWithAquote();
            AddQuoteToExistingSmurai(1001);

        }

        private static void AddQuoteToExistingSmurai(int samuraiId)
        {
            // we wil use  adisconnected instance 
            // that wil add another quote in the
            // existing related table
            var db = new SamuraiContext();
            // get the samurai
            var samurai = db.Samurais.Find(samuraiId);
            // adding a new quote
            samurai.Quotes.Add(new Quote
            {
                Text = "we made our own deamon"
            });

            // must remember you need to attach the
            // quote when adding with the existing related data
            db.Samurais.Attach(samurai);
            db.SaveChanges();
            Console.WriteLine("[+] New Data Attached");
            
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
