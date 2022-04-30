using System;
public class Program{
    static void Main(string[] args){

        Artist Labrinth = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrónica", new DateTime(2021, 08, 12));

        Producer Masterworks = new Producer("Milan Records", "061.743.987-12", new DateTime(1983, 03, 19), new DateTime(), "Masterworks");

        Masterworks.Musical_genres.Add("Eletrônica");
        Masterworks.Musical_genres.Add("Rap");
        Masterworks.Musical_genres.Add("Pop");

        Album Euphoria = new Album(Labrinth, Masterworks, "Euphoria", "Eletrónica", "Euphoria (Original Score from the HBO Series)", new DateTime(2019, 10, 04));

        Music Mount_Everest = new Music("Mount Everest", 2.6 , "Eletrónica", new DateTime(2019, 10, 04));
        Music Formula = new Music("Formula", 3.5, "Eletrónica", new DateTime(2019, 10, 04));

        Euphoria.Musics.Add(Mount_Everest);
        Euphoria.Musics.Add(Formula);

        foreach(var elemento in Euphoria.Musics){

         Console.WriteLine(elemento.NameMusic);

        }
    }
}
