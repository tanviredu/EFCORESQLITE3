using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        public Battle()
        {
            // init the list
            SamuraiBattles = new List<SamuraiBattle>();

        }

        /// <summary>
        /// both class Samurai and 
        /// battle need to have this list
        /// because both class need to intract this
        /// this is a many to many relationghip
        /// the last thing you need to do this is 
        /// make go to onmodel create and specfy the relationhip
        /// </summary>

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
