using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace SamuraiApp.Domain
{
    public class Samurai
    {
        
        // this are all the properties 
        // of the Samurai
        // Smurai has id,Name,and a List of Quote object
        // and  a Clan object
        public Samurai()
        {
            // initialize the list at the constructor
            Quotes = new List<Quotes>();
            SamuraiBattles = new List<SamuraiBattle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quotes> Quotes { get; set; }
        public Clan CLan { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        
        // have create a many to many relationship
        // between samurai and battle
        // every samurai can have multiple battle
        // and every battle can have multiple samurai
        // so samurai have  alist of battle
        // battle has a list of samurai
    }
    
    
  
}