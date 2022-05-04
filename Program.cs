using System;
using System.Collections.Generic;
public class Program{
    static void Main(string[] args){

        //Variáveis do menu

        int option = 0;
        int option_menu = 0;

        //Artistas

        Artist Labrinth = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrónica", new DateTime(2021, 08, 12));

        //Produtoras

        Producer Masterworks = new Producer("Milan Henry", "061.743.987-12", new DateTime(1983, 03, 19), new DateTime(), "Masterworks");

        //Gêneros musicais da produrora Masterworks

        Masterworks.Musical_genres.Add("Eletrônica");
        Masterworks.Musical_genres.Add("Rap");
        Masterworks.Musical_genres.Add("Pop");
        Masterworks.Musical_genres.Add("Rock");

        //Álbuns

        Album Euphoria = new Album(Labrinth, Masterworks, "Euphoria", "Eletrónica", "Euphoria (Original Score from the HBO Series)", new DateTime(2020, 10, 04));
        Album Batman = new Album(Labrinth, Masterworks, "Batman", "tara", "Euphoria (Original Score from the HBO Series)", new DateTime(2021, 10, 04));

        //Inicializando músicas "soltas"

        Music Mount_Everest = new Music("Mount Everest", 2.6 , "Eletrónica", new DateTime(2019, 10, 04));
        Music Formula = new Music("Formula", 3.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music Forever = new Music("Forever", 3.2, "Eletrónica", new DateTime(2019, 10, 04));
        Music When_I_RIP = new Music("When I R.I.P", 3.8, "Eletrónica", new DateTime(2019, 10, 04));
        Music ImTired = new Music("I'am Tired", 3.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music Still_Dont_Know_My_Name = new Music("Still Don't Know My Name", 2.93, "Eletrónica", new DateTime(2020, 10, 04));
        Music EliotsSong = new Music("Eliot's Song", 3.5, "Eletrónica", new DateTime(2020, 10, 04));
        Music NateGrowingUp = new Music("Nate Growing Up", 2.5, "Eletrónica", new DateTime(2019, 10, 04));
        Music WeAllKnew = new Music("We All Knew", 3.01, "Eletrónica", new DateTime(2020, 10, 04));
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

        //Adicionando os álbumns do Labrinth

        Labrinth.ArtistAlbums.Add(Euphoria);
        Labrinth.ArtistAlbums.Add(Batman);

        //Adicionando os álbumns da MasterWorks

        Masterworks.ProducerAlbums.Add(Euphoria);
        Masterworks.ProducerAlbums.Add(Batman);

        //Todos os álbums

        List<Album> All_Albums = new List<Album>();
        All_Albums.Add(Euphoria);

        //Parte de Interação com o Usuário

        do
        {
            //Menu Principal para opções implementadas do LINQ e LAMBDA

            Menus.MainMenu();
            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            if (option != 0){

                    Console.Clear();
            }

            //Opções de escolha do Menu Principal

            switch(option){

                case 1:

                do{

                    //Albúns dos Artistas

                    Menus.Menu_albums_of_Artist();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albumsAartist = LinqAndLambda.AlbumsofArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in albumsAartist) {
                            
                            Console.WriteLine(elemento.NameAlmbum);

                            }

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);

                break;

                case 2:

                do{

                    //Albúns do ano

                    Menus.Menu_albums_of_year();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albums_of_year = LinqAndLambda.AlbumsofYear(All_Albums, Euphoria.ReleaseDate.Year);

                            Console.WriteLine("\n");

                            foreach(var elemento in albums_of_year) Console.WriteLine(elemento.NameAlmbum);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);


                break;

                case 3:

                do{

                    //Músicas dos Artistas

                    Menus.MusicsArtist();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Music> musics_of_artist = LinqAndLambda.MusicsArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in musics_of_artist) Console.WriteLine(elemento.NameMusic);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);


                break;

                case 4:

                do{

                    //Albúns dos Artistas en um ano específico

                    Menus.MusicsArtistYear();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                    if(option_menu != 0) Console.Write("\nDigite o ano que deseja buscar: ");
             
                    int year = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Music> musicsArtistYear = LinqAndLambda.MusicsArtistofYear(Labrinth, year);

                            Console.WriteLine("\n");

                            foreach(var elemento in musicsArtistYear) Console.WriteLine(elemento.NameMusic);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);


                break;

                case 5:

                do{

                    //Albúns dos Produtores do mesmo gênero

                    Menus.AlbumsProducersGender();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                   
                        switch(option_menu){

                            case 1:

                            List<Album> albums_of_producer = LinqAndLambda.AlbumsProducersGender(Masterworks, "Eletrónica");

                            Console.WriteLine("\n");

                            foreach(var elemento in albums_of_producer) Console.WriteLine(elemento.NameAlmbum);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);


                break;

                case 6:

                do{

                    //Albúns dos Produtor daquele ano

                    Menus.AlbumsProducersYear();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                    if(option_menu != 0) Console.Write("\nDigite o ano que deseja buscar: ");
             
                    int year_ = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albumsProducerYear = LinqAndLambda.AlbumsProducersYear(Masterworks, year_);

                            Console.WriteLine("\n");

                            foreach(var elemento in albumsProducerYear) Console.WriteLine(elemento.NameAlmbum);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);

                break;

                case 7:

                do{

                    //Albúns dos Artistas em ordem de lançamento

                    Menus.Ordem_albums_of_Artist();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albums_of_artist = LinqAndLambda.OrderAlbumsArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in albums_of_artist) Console.WriteLine(elemento.NameAlmbum + " : "  + elemento.ReleaseDate.Day + "/" + elemento.ReleaseDate.Month+ "/" + elemento.ReleaseDate.Year);

                            Console.ReadLine();

                            break;

                            case 0:
                            break;

                            default:

                            Console.WriteLine("Entrada Inválida");
                            break;
                        }

                        Console.Clear();

                } while(option_menu!=0);


                break;

                case 0:
                break;

                default:

                Console.WriteLine("Entrada Inválida");

                break;
            }
            
        } while (option != 0);

    }
}
