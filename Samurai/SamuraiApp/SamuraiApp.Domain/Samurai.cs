using System;
using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public Samurai()
        {

            // instantiate the battle when 
            Quotes = new List<Quote>();
            SamuraiBattles = new List<SamuraiBattle>();
                }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public Clan Clan { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }

}
