using SQLite;

SQLiteConnection cn1= new SQLiteConnection("chinook.db");
var tblArtist=cn1.Query<Artist>("select * from artists");
Console.WriteLine($"In questa tabella ci sono{tblArtist.Count} record!");

//utilizzando  il linguaggio LINQ
//Language Integrate Query

//stampa della tabella dal primo record all'ultimo
Console.WriteLine("Ordine default");
foreach(var artista in tblArtist)
{
  Console.Write($"{artista.ArtistId} ");
  Console.WriteLine($"{artista.Name}");
}

//stampa della tabella dall'ultimo record al primo
Console.WriteLine("Ordine contrario");
tblArtist = tblArtist.OrderByDescending(x=>x.ArtistId).ToList();
foreach(var artista in tblArtist)
{
  Console.Write($"{artista.ArtistId} ");
  Console.WriteLine($"{artista.Name}");
}



public class Artist
{
  public int ArtistId{get;set;}
  public string Name{get;set;}
}
