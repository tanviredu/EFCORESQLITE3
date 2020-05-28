using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;

namespace Samurai
{
    public class Many_to_many_query
    {
        // we query many to many
        // think this is parent child and grantchild
        // you need to start with samurai
        // then include samuraibattle
        // then include the battle


        public static void getSamuraiWithBattle()
        {
            // many to many query with Egarload
            // query from samurai to samuraibattle
            // to battle and then include everytinh for
            // samurai==2
            // this may sound like cumber
            
            // you are querying all of the the battle
            // of a single samurai
            
            
            
            var _context = new SamuraiContext();
            var samuraiwithbattle = _context.Samurais.Include(s => s.SamuraiBattles).ThenInclude(
                sb => sb.Battle).FirstOrDefault(samurai => samurai.Id == 1);
            System.Console.WriteLine(samuraiwithbattle.Name);

            foreach (var battle in samuraiwithbattle.SamuraiBattles)
            {
                System.Console.WriteLine(battle.Battle.Name);
            }
            
            
            
            

        }
        
        
        // include method looks like a littlebit complicated
        // lets use the projection

        public static void getsamuraiwithprojection()
        {
            var db = new SamuraiContext();
            
            // now we are using the projeciton
            var samuraiwithbattles = db.Samurais.Where(s => s.Id == 2)
                .Select(s => new
                {
                    Samurai = s,
                    Battle = s.SamuraiBattles.Select(sb => sb.Battle)
                }).FirstOrDefault();
        }
        // we select the samurau and get id==2
        // then we make a new type where 
        // samurai is the samurai object anbd the battle
        // if the battle the smurai faught
        
        // the include is easier
        // and it egarload
        
        
        
        
        
                
        
    }
}