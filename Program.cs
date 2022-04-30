using System;
public class Program{
    static void Main(string[] args){

        Artist artist = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrónica", new DateTime(2021, 08, 12));

        Console.WriteLine(artist.Name);
        Console.WriteLine(artist.CPF);
        Console.WriteLine(artist.BirthDate);
        Console.WriteLine(artist.DeathDate);
        Console.WriteLine(artist.Musical_genre);
        Console.WriteLine(artist.ContractDate);

    }
}
