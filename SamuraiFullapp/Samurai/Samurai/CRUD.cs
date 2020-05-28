using System;
using System.Linq;
using SamuraiApp.Data;

namespace Samurai
{
    public class CRUD
    {
        public void InsertData()
        {
            var samurais = Utility.ProcessFileQuery("data.csv");
            
            // creating a  isolated environment
            using (var sm = new SamuraiContext())
            {
                foreach (var samu in samurais)
                {
                    sm.Samurais.Add(samu);
                    System.Console.WriteLine($"[+] Added {samu.Name}");

                }

                sm.SaveChanges();
                System.Console.WriteLine($"[+] Added To Database");
                
            }
        }

        public void ReadData()
        {
            var db = new SamuraiContext();
            var query1 = from sm in db.Samurais 
                select sm;

            foreach (var samurai in query1)
            {
                
                System.Console.WriteLine($"[+] Name {samurai.Name,-6}");
            }
        }


        public void UpdateData(int id, string name)
        {
            var db = new SamuraiContext();
            var samu = db.Samurais.Single(s => s.Id == id);
            System.Console.WriteLine($"[-] Old Name {samu.Name}");
            samu.Name = name;
            System.Console.WriteLine($"[+] New Name {samu.Name}");
            db.SaveChanges();
            System.Console.WriteLine($"[+] database Updated");
            
        }

        public void Delete(int id)
        {
            var db = new SamuraiContext();
            var samu = db.Samurais.Single(s=> s.Id == id);
            db.Samurais.Remove(samu);
            db.SaveChanges();

        }
    }
}