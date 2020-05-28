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
            
            var cr = new CRUD();
            cr.InsertData();
        }
    }
}