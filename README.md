# LINQDb
## Prerequisiti
* Installare il database chinook.db -> SQLite sample database ([download](https://www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip))
* Installare l'estensione SQLite su Visual Studio Code  
##
### Creazione passo passo
1. Creare una cartella

2. Aprirla su Visual Studio Code

3. Aprire un terminale e scrivere
  ```
  dotnet new console
  ```

4. Spostare all'interno della cartella creata il file [chinook.db](https://github.com/Sateoo/LINQDb/blob/main/README.md#prerequisiti)

5. Installare l'estensione SQLite
  ![estendione](https://kod90.com/wp-content/uploads/2022/09/sqlite-eklentisi-1024x487.png)

6. Aprire il terminale e scrivere
  ```
  dotnet add package sqlite-net-pcl
  ```

7. Andare nel file Program.cs e scrivere
  ```
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

  ```
##
### Cos'è LINQ (Language Integrated Query)
è una tecnologia di programmazione sviluppata da Microsoft per semplificare la manipolazione dei dati all'interno del codice. LINQ è stato introdotto per la prima volta in .NET Framework 3.5 e fornisce un insieme di librerie standardizzate che possono essere utilizzate in qualsiasi linguaggio supportato da .NET.
### Consente
* di scrivere query SQL-style (Structured Query Language) all'interno del proprio codice, che possono essere eseguite su una vasta gamma di dati, inclusi database, oggetti e servizi Web.
* di scrivere query complesse in modo più semplice e leggibile rispetto all'utilizzo di costrutti di loop tradizionali, aumentando così la produttività del programmatore e riducendo la possibilità di errori.
