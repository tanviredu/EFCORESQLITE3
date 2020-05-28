using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using SQLitePCL;

namespace Samurai
{
    public class Interact
    {
        public static void InsertSamuraiWithAQuote()
        {
            var db = new SamuraiContext();
            var samurai = new SamuraiApp.Domain.Samurai
            {
                Name = "Tanvir Rahman Ornob",
                Quotes = new List<Quotes>
                {
                    new Quotes
                    {
                        Text = "We fight togather"
                    },
                    new Quotes
                    {
                        Text = "We die Togather"
                    },
                }
            };

            db.Samurais.Add(samurai);
            db.SaveChanges();
            System.Console.WriteLine($"Data Added the id is {samurai.Id}");



        }

        public static void AddQuoteToExistingSmurai(int samuraiId)
        {
            var db = new SamuraiContext();
            var samurai = db.Samurais.Find(samuraiId);
            samurai.Quotes.Add(
                new Quotes
                {
                    Text = "you die alone"
                });
            // you have to use the attach 

            db.Samurais.Attach(samurai);
            db.SaveChanges();
            System.Console.WriteLine("Quote added with attach");
        }


        public static void AddquoteWithDifferentWay(int samuraiId)
        {
            var db = new SamuraiContext();
            var quote = new Quotes
            {
                Text = "we all die",
                SamuraiId = samuraiId
            };
            // direct insert
            db.Quotes.Add(quote);
            db.SaveChanges();
            System.Console.WriteLine("Quote added with direct id");

        }

        public static void DataEgarLoadWithQuotes()
        {
            var db = new SamuraiContext();
            
            // remmember you can use chain the include 
            // to make all the relation you want to make
            
            
            var samuraiwithquote = db.Samurais.Include(q => q.Quotes).ToList();

            foreach (var samurai in samuraiwithquote)
            {
                System.Console.WriteLine($"{samurai.Name} has Quote :   ");

                foreach (var quote in samurai.Quotes)
                {
                    System.Console.WriteLine($"[+] {quote.Id}     [*] {quote.Text}    ");
                }
            }
           
            
        }
    }
}