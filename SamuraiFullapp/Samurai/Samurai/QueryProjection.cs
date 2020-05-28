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


        public static void SelectiveQuote()
        {
            var db = new SamuraiContext();
            var filterquote = db.Samurais.Select(s => new
            {
                s.Id,s.Name,die_quotes = s.Quotes.Where(q=>q.Text.Contains("die"))
            }).ToList();
            foreach (var samurai in filterquote)
            {
                System.Console.WriteLine($"[*] Id: {samurai.Id,-6} Name: {samurai.Name,-6}");
                foreach (var qoute in samurai.die_quotes)
                {
                    System.Console.WriteLine($"[*] Quote {qoute.Text}");
                }

            }
        }
    }
}