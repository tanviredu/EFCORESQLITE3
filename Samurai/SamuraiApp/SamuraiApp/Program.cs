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
            InsertNewSamuraiWithAquote();

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

            
        }
    }

        

        

      
    
}
