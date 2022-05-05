using System;
using System.Collections.Generic;
public class Program{
    static void Main(string[] args){

        //Variáveis do menu

        int option = 0;
        int option_menu = 0;

        //Artistas

        Artist Labrinth = new Artist("Labrinth", "022.653.776-51", new DateTime(1989, 01, 04), new DateTime(), "Eletrônica", new DateTime(2021, 08, 12));
        Artist BillieEilish = new Artist("Billie Eilish", "032.245.743-12", new DateTime(2001, 12, 18), new DateTime(), "Pop", new DateTime(2016, 02, 21));

        //Produtoras

        Producer Masterworks = new Producer("Milan Henry", "061.743.987-12", new DateTime(1983, 03, 19), new DateTime(), "Masterworks");

        //Gêneros musicais da produrora Masterworks

        Masterworks.Musical_genres.Add("Eletrônica");
        Masterworks.Musical_genres.Add("Rap");
        Masterworks.Musical_genres.Add("Pop");
        Masterworks.Musical_genres.Add("Rock");

        //Álbuns

        Album Euphoria = new Album(Labrinth, Masterworks, "Euphoria", "Eletrônica", "Euphoria (Original Score from the HBO Series)", new DateTime(2020, 10, 04));
        Album Happier_Than_Ever = new Album(BillieEilish, Masterworks, "Happier Than Ever", "Pop", "Sofrência Internacional", new DateTime(2021, 07, 30));
        Album teste_para_lista_decrescente = new Album(BillieEilish, Masterworks, "teste_para_lista_decrescente", "Pop", "Sofrência Internacional", new DateTime(2022, 04, 30));

        //Inicializando músicas "soltas"

        Music Mount_Everest = new Music("Mount Everest", 2.6 , "Eletrônica", new DateTime(2019, 10, 04));
        Music Formula = new Music("Formula", 3.5, "Eletrônica", new DateTime(2019, 10, 04));
        Music Forever = new Music("Forever", 3.2, "Eletrônica", new DateTime(2019, 10, 04));
        Music When_I_RIP = new Music("When I R.I.P", 3.8, "Eletrônica", new DateTime(2019, 10, 04));
        Music ImTired = new Music("I'am Tired", 3.5, "Eletrônica", new DateTime(2019, 10, 04));
        Music Still_Dont_Know_My_Name = new Music("Still Don't Know My Name", 2.93, "Eletrônica", new DateTime(2020, 10, 04));
        Music EliotsSong = new Music("Eliot's Song", 3.5, "Eletrônica", new DateTime(2020, 10, 04));
        Music NateGrowingUp = new Music("Nate Growing Up", 2.5, "Eletrônica", new DateTime(2019, 10, 04));
        Music WeAllKnew = new Music("We All Knew", 3.01, "Eletrônica", new DateTime(2020, 10, 04));
        Music WTF_AreWeTalkingFor = new Music("WTF Are We Talking For", 2.8, "Eletrônica", new DateTime(2019, 10, 04));
        Music ArrivalAtTheFormal = new Music("Arrival At The Formal", 5.95, "Eletrônica", new DateTime(2019, 10, 04));
        Music Gangster = new Music("Gangster", 2.5, "Eletrônica", new DateTime(2019, 10, 04));

        Music HappierThanEver = new Music("Happier Than Ever", 4.6 , "Pop", new DateTime(2021, 07, 30));
        Music Bored = new Music("Bored", 3.6 , "Pop", new DateTime(2020, 05, 25));
        Music Bellyache = new Music("Bellyache", 3.1 , "Pop", new DateTime(2017, 07, 30));
        Music OceanEyes = new Music("Ocean Eyes", 3.9 , "Pop", new DateTime(2016, 07, 30));
        Music ThereforeIAm = new Music("Therefore I Am", 3.3 , "Pop", new DateTime(2020, 07, 30));
        Music LostCause = new Music("Lost Cause", 3.8 , "Pop", new DateTime(2021, 07, 30));
        Music WhenThePartyOver = new Music("When The Party's Over", 3.6 , "Pop", new DateTime(2017, 07, 30));
        Music Lovely = new Music("Lovely", 3.2 , "Pop", new DateTime(2018, 07, 30));

        //Adicionando as músicas aos álbuns

          //Euphoria

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

          //Happier Than Ever

        Happier_Than_Ever.Musics.Add(HappierThanEver);
        Happier_Than_Ever.Musics.Add(Bored);
        Happier_Than_Ever.Musics.Add(Bellyache);
        Happier_Than_Ever.Musics.Add(OceanEyes);
        Happier_Than_Ever.Musics.Add(ThereforeIAm);
        Happier_Than_Ever.Musics.Add(LostCause);
        Happier_Than_Ever.Musics.Add(WhenThePartyOver);
        Happier_Than_Ever.Musics.Add(Lovely);

        //Adicionando os álbumns aos Artistas

          //Labrinth

         Labrinth.ArtistAlbums.Add(Euphoria);
         Labrinth.ArtistAlbums.Add(teste_para_lista_decrescente);

          //Billie Eilish
         
         BillieEilish.ArtistAlbums.Add(Happier_Than_Ever);
         BillieEilish.ArtistAlbums.Add(teste_para_lista_decrescente);

        //Adicionando os álbumns da MasterWorks

        Masterworks.ProducerAlbums.Add(Euphoria);
        Masterworks.ProducerAlbums.Add(Happier_Than_Ever);

        //Todos os álbums

        List<Album> All_Albums = new List<Album>();
        All_Albums.Add(Euphoria);
        All_Albums.Add(Happier_Than_Ever);
        All_Albums.Add(teste_para_lista_decrescente);

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

                    Menus.Artists();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albumsLabrinth = LinqAndLambda.AlbumsofArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in albumsLabrinth) {
                            
                            Console.WriteLine(elemento.NameAlmbum);

                            }

                            Console.ReadLine();

                            break;

                            case 2:

                            List<Album> albumsBillieEilish = LinqAndLambda.AlbumsofArtist(BillieEilish);

                            Console.WriteLine("\n");

                            foreach(var elemento in albumsBillieEilish) Console.WriteLine(elemento.NameAlmbum);

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

                //Albúns do ano

                Console.Write("\nDigite o ano que deseja buscar: ");
                int yearAlbum = int.Parse(Console.ReadLine());

                List<Album> ListAlbumsOfYear = LinqAndLambda.AlbumsofYear(All_Albums, yearAlbum);

                Console.WriteLine("\n");

                if(ListAlbumsOfYear.Count == 0) {

                Console.WriteLine("Nenhum Álbum registrado é de " + yearAlbum );

                } else {

                foreach(var elemento in ListAlbumsOfYear) Console.WriteLine(elemento.NameAlmbum);

                }

                Console.ReadLine();

                Console.Clear();

               
                break;

                case 3:

                do{

                    //Músicas dos Artistas

                    Menus.Artists();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Music> musics_Labrinth = LinqAndLambda.MusicsArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in musics_Labrinth) Console.WriteLine(elemento.NameMusic);

                            Console.ReadLine();

                            break;

                            case 2:

                            List<Music> musics_BillieEilish = LinqAndLambda.MusicsArtist(BillieEilish);

                            Console.WriteLine("\n");

                            foreach(var elemento in musics_BillieEilish) Console.WriteLine(elemento.NameMusic);

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

                    //Músicas dos Artistas en um ano específico

                    Menus.Artists();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                    int year = 0;

                    if(option_menu != 0) 
                    {

                        Console.Write("\nDigite o ano que deseja buscar: ");
                        year = int.Parse(Console.ReadLine());
                        

                    }
             

                        switch(option_menu){

                            case 1:

                            List<Music> musicsLabrinthYear = LinqAndLambda.MusicsArtistofYear(Labrinth, year);

                            Console.WriteLine("\n");

                            if(musicsLabrinthYear.Count == 0) {

                            Console.WriteLine("Nenhuma Música desse Artista é de " + year );

                            } else {

                            foreach(var elemento in musicsLabrinthYear) Console.WriteLine(elemento.NameMusic);

                            }

                            Console.ReadLine();

                            break;

                            case 2:

                            List<Music> musicsBillieEilishYear = LinqAndLambda.MusicsArtistofYear(BillieEilish, year);

                            Console.WriteLine("\n");

                            if(musicsBillieEilishYear.Count == 0) {

                            Console.WriteLine("Nenhuma Música desse Artista é de " + year );

                            } else {

                            foreach(var elemento in musicsBillieEilishYear) Console.WriteLine(elemento.NameMusic);

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

                case 5:

                do{

                    //Albúns dos Produtores do mesmo gênero

                    Menus.Producers();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                    string gender_album = "";

                    if(option_menu != 0) 
                    {

                        Console.Write("\nDigite o gênero que deseja buscar: ");
                        gender_album = (Console.ReadLine());
                        
                        
                    }

                   
                        switch(option_menu){

                            case 1:

                            List<Album> albums_of_producer = LinqAndLambda.AlbumsProducersGender(Masterworks, gender_album);

                            Console.WriteLine("\n");

                            if(albums_of_producer.Count == 0) {

                            Console.WriteLine("Nenhum Álbum desse produtor faz parte do gênero: " + gender_album );

                            } else {
                                
                                foreach(var elemento in albums_of_producer) Console.WriteLine(elemento.NameAlmbum);
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

                case 6:

                do{

                    //Albúns dos Produtor daquele ano

                    Menus.Producers();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                    int Year = 0;

                    if(option_menu != 0) 
                    {
                        Console.Write("\nDigite o ano que deseja buscar: ");
                        Year = int.Parse(Console.ReadLine());
                    }
             

                        switch(option_menu){

                            case 1:

                            List<Album> albumsProducerYear = LinqAndLambda.AlbumsProducersYear(Masterworks, Year);

                            Console.WriteLine("\n");

                            if(albumsProducerYear.Count == 0) {

                            Console.WriteLine("Nenhum Álbum desse produtor é de " + Year );

                            } else {
                                
                                foreach(var elemento in albumsProducerYear) Console.WriteLine(elemento.NameAlmbum);
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

                case 7:

                do{

                    //Albúns dos Artistas em ordem de lançamento

                    Menus.Artists();
                    Console.Write("\nEscolha uma opção: ");
                    option_menu = int.Parse(Console.ReadLine());

                        switch(option_menu){

                            case 1:

                            List<Album> albums_of_Labrinth = LinqAndLambda.OrderAlbumsArtist(Labrinth);

                            Console.WriteLine("\n");

                            foreach(var elemento in albums_of_Labrinth) Console.WriteLine(elemento.NameAlmbum + " : "  + elemento.ReleaseDate.Day + "/" + elemento.ReleaseDate.Month+ "/" + elemento.ReleaseDate.Year);

                            Console.ReadLine();

                            break;

                            case 2:

                            List<Album> albums_of_BillieEilish = LinqAndLambda.OrderAlbumsArtist(BillieEilish);

                            Console.WriteLine("\n");

                            foreach(var elemento in albums_of_BillieEilish) Console.WriteLine(elemento.NameAlmbum + " : "  + elemento.ReleaseDate.Day + "/" + elemento.ReleaseDate.Month+ "/" + elemento.ReleaseDate.Year);

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
