using System.Linq;
using SamuraiApp.Data;
using SamuraiApp.Domain;
namespace Samurai
{
    public class QueryProjection
    {

        public static void ProjectSamuraisWithQuotes()
        {
            var db = new SamuraiContext();
            var somePropertiesWithQuote = db.Samurais.Select(s => new
            {
                s.Id, s.Name, s.Quotes.Count
            }).ToList();

            foreach (var samurai in somePropertiesWithQuote)
            {
                System.Console.WriteLine($"[*] Id: {samurai.Id,-6} Name: {samurai.Name,-6} Quote: {samurai.Count} ");
            }
        }
    }
}