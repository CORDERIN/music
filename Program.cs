using System;
public class Program{
    static void Main(string[] args){

        Artist Labrinth = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrónica", new DateTime(2021, 08, 12));

        Producer Masterworks = new Producer("Milan Records", "061.743.987-12", new DateTime(1983, 03, 19), new DateTime(), "Masterworks");

        Album album = new Album(Labrinth, Masterworks, "Euphoria", "Eletrónica", "Euphoria (Original Score from the HBO Series)", new DateTime(2019, 10, 04));
    }
}
