using SQLite;
SQLiteConnection cn1= new SQLiteConnection("chinook.db");
var tblArtist=cn1.Query<Artist>("select * from artists");
Console.WriteLine($"In questa tabella ci sono{tblArtist.Count} record!");

//stampa della tabella
foreach(var artista in tblArtist)
{
    Console.WriteLine($"{artista.Name}");
}


public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}