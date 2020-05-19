using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Horse
    {
        // some samurai may have hourse
        // its  a one to one relationhip
        // one specfic horse is related to just one samurai
        // its an optional becase some  samuraies may not have a horse
        public int Id { get; set; }
        public string Name { get; set; }
        public int SamuraiId { get; set; }

    }



            /*
                before migrating the databse 
                you will visulaze the relationship
                with dgm editor
                yes you can visualize before 
                even migrate
                and you dont need to add all the table in the dbcontext
                if any table is related with other table 
                it will automatically shows up
                you put the table in the dbcontext if you want 
                to directly controll it
                other wise efcore will automatically create it from the class
                but you can still adjust thename 
                in the onmodel creating
            
            */
}
