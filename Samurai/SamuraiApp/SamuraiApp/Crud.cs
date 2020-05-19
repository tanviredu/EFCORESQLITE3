using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp
{
    
    // apply both functional and the query syntax to do that

    
    class Crud
    {
        public Samurai CreateSamurai()
        {


            return new Samurai();
        }


        public Samurai ReadSamurai()
        {


            return new Samurai();
        }

        public Samurai UpdateSamurai(Samurai samurai)
        {


            return new Samurai();
        }


        public void DeleteSamurai(Samurai samurai)
        {


            
        }

        public IEnumerable<Samurai> GetMultipleSamurai()
        {
            List<Samurai> samurais = new List<Samurai>();
            return samurais;
        }

    }
}
