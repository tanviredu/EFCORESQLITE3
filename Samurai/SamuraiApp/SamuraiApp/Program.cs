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
            InsertData();                         // C in Crud
            ReadData();                           // R i Crud
            UpdateData(1,"Tanvir Rahman Ornob");  // U in Crud
            DeleteData(1);                          // D i Crud
            

        }

        private static void DeleteData(int id)
        {
            // delete the data based on the id
            var db = new SamuraiContext();
            var samu = db.Samurais.Single(s => s.Id == id);
            Console.WriteLine($"[-] Old Name {samu.Name}");
            db.Samurais.Remove(samu);
            db.SaveChanges();

        }

        private static void UpdateData(int id,string name)
        {
            // we update this with the linq
            var db = new SamuraiContext();
            var samu = db.Samurais.Single(s => s.Id == id);

            Console.WriteLine($"[-] Old Name {samu.Name}");
            // setting new name
            samu.Name = name;
            Console.WriteLine($"[+] New Name {samu.Name}");
            db.SaveChanges();
            Console.WriteLine($"[+] Database Updated");






        }

        private static void ReadData()
        {
            // read the first 10
            // all 
            // and orderby name ascending

            var db = new SamuraiContext();
            // this is the first 10
            var query1 = from sm in db.Samurais
                         select sm;

            foreach (var sm in query1.Take(10))
            {
                Console.WriteLine($"[+] Samurai Name {sm.Name}");
            }

            var samurai_count = (from sm in db.Samurais
                          select sm).Count();

            Console.WriteLine($"[+] Total Samurai : {samurai_count}");
        }

        private static void InsertData()
        {
            //string dbName = "A:\\EFCORE3.1sqlite3\\Samurai\\database.db";
            //if (File.Exists(dbName))
            //{
            //    File.Delete(dbName);
            //}


            var samuries = ProcessFileQUery("data.csv");
            using (var sm = new SamuraiContext())
            {
                sm.Database.EnsureCreated();
                if (!sm.Samurais.Any())
                {
                    foreach (var samu in samuries)
                    {
                        sm.Samurais.Add(samu);
                        Console.WriteLine($"[+] Added {samu.Name}");
                    }
                    sm.SaveChanges();
                    Console.WriteLine("[+] Data Added.");
                    
                }
            }

        }

        private static List<Samurai> ProcessFileQUery(string path)
        {
            // make a query to instert all the data from the csv to
            // the database
            // select each of the row from the fila and pass it
            // to the parseCsv from the utility class
            var query = from row in File.ReadAllLines(path).Skip(1)
                        where row.Length > 1
                        select utility.ParseFromCsv(row);

            return query.ToList();
        }


      
    }
}
