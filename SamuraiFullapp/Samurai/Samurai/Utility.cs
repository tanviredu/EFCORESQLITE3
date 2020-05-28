using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace Samurai
{
    public class Utility
    {
        public static SamuraiApp.Domain.Samurai ParseFromCsv(string row)
        {
            var data = row.Split(",");
            return new SamuraiApp.Domain.Samurai
            {
                Id = int.Parse(data[0]),
                Name = data[1]
            };
        }

        public static List<SamuraiApp.Domain.Samurai> ProcessFileQuery(string path)
        {
            
            // get a list of samurai

            var query = from row in File.ReadAllLines(path).Skip(1)
                where row.Length > 1
                select ParseFromCsv(row);

            return query.ToList();

        }
    }
}