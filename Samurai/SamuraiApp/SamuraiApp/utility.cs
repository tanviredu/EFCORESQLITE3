using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp
{
    class utility
    {
        public static Samurai ParseFromCsv(string row)
        {
            var data = row.Split(",");
            return new Samurai
            {

                Id = int.Parse(data[0]),
                Name = data[1]

            };
        }
    }
}
