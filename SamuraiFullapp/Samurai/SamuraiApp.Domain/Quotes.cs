using SamuraiApp.Domain;

public class Quotes
{
    // this quote have  aid , text the samurai object 
    // itself and a samuraiId
    // we add the samurai object for redundency
    // its not important
    public int Id { get; set; }
    public string Text { get; set; }
    public Samurai Samurai { get; set; }
    public int SamuraiId { get; set; }
}