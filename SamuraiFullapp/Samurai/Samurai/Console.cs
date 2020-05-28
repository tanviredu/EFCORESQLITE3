using System;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using System.Linq;
namespace Samurai
{
    public class Console
    {
        static void Main(string[] args)
        {
            //
            // var cr = new CRUD();
            // //cr.InsertData();
            // cr.ReadData();
            // //cr.UpdateData(1,"Tanvir Rahman");
            
            //Interact.InsertSamuraiWithAQuote();
            //Interact.AddQuoteToExistingSmurai(1);
            //Interact.AddquoteWithDifferentWay(1);
            //Interact.DataEgarLoadWithQuotes();
            //QueryProjection.ProjectSamuraisWithQuotes();
            //QueryProjection.SelectiveQuote();
            Many_to_many_query.getSamuraiWithBattle();
            
            
        }
    }
}