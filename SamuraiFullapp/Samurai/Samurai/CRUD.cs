using System;
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
            
        }
    }
}