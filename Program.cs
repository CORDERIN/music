using System;
using System.Collections.Generic;
public class Program{

    static void Menu(){

        Console.WriteLine("\t  ______________________________________________________________\n" +
                             "\t.'  __________________________________________________________  '.\n" +
                             "\t: .'                                                          '.  :\n" +
                             "\t| |       _______________________________________________       | |\n" +
                             "\t| |    .:________________________________________________ :.    | |\n" +
                             "\t| |    |           INICIANDO EM LINQ E LAMBDA              |    | |\n" +
                             "\t| |    |                                                   |    | |\n" +
                             "\t| |    |                  MENU PRINCIPAL:                  |    | |\n" +
                             "\t| |    |                                                   |    | |\n" +
                             "\t| |    |   1 - Todos os álbuns de um artista.              |    | |\n" +
                             "\t| |    |   2 - Todos os álbuns de um ano.                  |    | |\n" +
                             "\t| |    |   3 - As músicas de um Artista.                   |    | |\n" +
                             "\t| |    |   4 - As músicas de um Artista em um Ano.         |    | |\n" +
                             "\t| |    |   5 - Álbuns do mesmo gênero de um produtor.      |    | |\n" +
                             "\t| |    |   6 - Álbuns do mesmo ano de um produtor.         |    | |\n" +
                             "\t| |    |   7 - Lista decrescente dos Álbuns de um artista. |    | |\n" +
                             "\t| |    |   0 - Sair                                        |    | |\n" +
                             "\t| |    |                                                   |    | |\n" +
                             "\t| |    |            __________________________             |    | |\n" +
                             "\t| |    |           |  |  |  |  |  |  |  |  |  |            |    | |\n" +
                             "\t| |    '.__________|__|__|__|__|__|__|__|__|__|__________ .'    | |\n" +
                             "\t| |                                                             | |\n" +
                             "\t| |                 Lista de Exercícios 1 - TP                  | |\n" +
                             "\t: '.__________________________________________________________.'  :\n" +
                             "\t'._____________________________/__ /____________________________.'\n\n\n");
 
    }

    public static List<Album> AlbumsofArtist(Artist artist, string name){ 
                                
        
        List<Album> ListAlbums = (from item in artist.ArtistAlbums where item.artist.Name.Equals(name) select item).ToList();

        return ListAlbums;

    }



    static void Main(string[] args){

        //Variáveis do menu

        int option = 0;
        string name = "";

        //Artistas

        Artist Labrinth = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrónica", new DateTime(2021, 08, 12));

        //Produtoras

        Producer Masterworks = new Producer("Milan Henry", "061.743.987-12", new DateTime(1983, 03, 19), new DateTime(), "Masterworks");

        //Gêneros musicais que a produrora produz

        Masterworks.Musical_genres.Add("Eletrônica");
        Masterworks.Musical_genres.Add("Rap");
        Masterworks.Musical_genres.Add("Pop");
        Masterworks.Musical_genres.Add("Rock");

        //Álbum Euphoria

        Album Euphoria = new Album(Labrinth, Masterworks, "Euphoria", "Eletrónica", "Euphoria (Original Score from the HBO Series)", new DateTime(2019, 10, 04));

        //Inicializando músicas "soltas"

        Music Mount_Everest = new Music("Mount Everest", 2.6 , "Eletrónica", new DateTime(2019, 10, 04));
        Music Formula = new Music("Formula", 3.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music Forever = new Music("Forever", 3.2, "Eletrónica", new DateTime(2019, 10, 04));
        Music When_I_RIP = new Music("When I R.I.P", 3.8, "Eletrónica", new DateTime(2019, 10, 04));
        Music ImTired = new Music("I'am Tired", 3.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music Still_Dont_Know_My_Name = new Music("Still Don't Know My Name", 2.93, "Eletrónica", new DateTime(2019, 10, 04));
        Music EliotsSong = new Music("Eliot's Song", 3.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music NateGrowingUp = new Music("Nate Growing Up", 2.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music WeAllKnew = new Music("We All Knew", 3.01, "Eletrónica", new DateTime(2019, 10, 04));
        Music WTF_AreWeTalkingFor = new Music("WTF Are We Talking For", 2.8, "Eletrónica", new DateTime(2019, 10, 04));
        Music ArrivalAtTheFormal = new Music("Arrival At The Formal", 5.95, "Eletrónica", new DateTime(2019, 10, 04));
        Music Gangster = new Music("Gangster", 2.5, "Eletrónica", new DateTime(2019, 10, 04));

        //Adicionando as músicas ao álbum Euphoria

        Euphoria.Musics.Add(Mount_Everest);
        Euphoria.Musics.Add(Formula);
        Euphoria.Musics.Add(Forever);
        Euphoria.Musics.Add(When_I_RIP);
        Euphoria.Musics.Add(ImTired);
        Euphoria.Musics.Add(Still_Dont_Know_My_Name);
        Euphoria.Musics.Add(EliotsSong);
        Euphoria.Musics.Add(NateGrowingUp);
        Euphoria.Musics.Add(WeAllKnew);
        Euphoria.Musics.Add(WTF_AreWeTalkingFor);
        Euphoria.Musics.Add(ArrivalAtTheFormal);
        Euphoria.Musics.Add(Gangster);

        //Adicionando os álbumns do cantor

        Labrinth.ArtistAlbums.Add(Euphoria);

        //Adicionando os álbumns da produtora

        Masterworks.ProducerAlbums.Add(Euphoria);

        //Parte de Interação com o Usuário

       do
       {
           
        Menu();
        Console.Write("Escolha uma opção: ");
        option = int.Parse(Console.ReadLine());

        if (option != 0){

                Console.Clear();
        }

        switch(option){

            case 1:

            Console.Write("\nDigite um nome:");
            name = Console.ReadLine();

            List<Album> albums_of_artist = AlbumsofArtist(Labrinth, name);
 
            Console.WriteLine("\nÁlbuns desse cantor:\n");

            foreach(var elemento in albums_of_artist){

             Console.WriteLine(elemento.NameAlmbum);

            }

            Console.ReadLine();

            break;

            case 2:

            break;

            case 3:

            break;

            case 4:

            break;

            case 5:

            break;

            case 6:

            break;

            case 7:

            break;

            case 0:

            break;

            default:

            break;
        }
        
       } while (option != 0);


        //Percorrendo e imprimindo as músicas do Álbum Euphoria

    

    }
}
