# LINQDb
## Prerequisiti
* Installare il database chinook.db -> SQLite sample database ([download](https://www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip))
* Installare l'estensione SQLite su Visual Studio Code  
###Creazione passo passo
1. Creare una cartella
2. Aprirla su Visual Studio Code
3. Aprire un terminale e scrivere
  ```
  dotnet new console
  ```
4. Installare l'estensione SQLite
  ![estendione](https://kod90.com/wp-content/uploads/2022/09/sqlite-eklentisi-1024x487.png)
5. Aprire il terminale e scrivere
  ```
  dotnet add package sqlite-net-pcl
  ```
6. Andare nel file Program.cs e scrivere
```
using SQLite;

SQLiteConnection cn1= new SQLiteConnection("chinook.db");
var tblArtist=cn1.Query<Artist>("select * from artists");
Console.WriteLine($"In questa tabella ci sono{tblArtist.Count} record!");

//utilizzando  il linguaggio LINQ
//Language Integrate Query

//stampa della tabella dal primo record all'ultimo
foreach(var artista in tblArtist)
{
    Console.WriteLine($"{artista.Name}");
}

//stampa della tabella dall'ultimo record al primo
tblArtist = tblArtist.OrderByDescending(x=>x.Name).ToList();
foreach(var artista in tblArtist)
{
    Console.WriteLine($"{artista.Name}");
}



public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}
```
