using System.Collections.Generic;
using SamuraiApp.Domain;

public class SamuraiBattle
{
    // this is the common entity
    // that we have to make it by hand
    public int SamuraiId { get; set; }
    public int BattleId { get; set; }
    public Samurai Samurai { get; set; }
    public Battle Battle { get; set; }
    
}