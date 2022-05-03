  
  public class LinqAndLambda{

    public static List<Album> AlbumsofArtist(Artist artist){ 
                                
        
        List<Album> ListAlbums = (from item in artist.ArtistAlbums select item).ToList();

        return ListAlbums;

    }

    public static List<Album> AlbumsofYear(List<Album> album, int year){ 
                                
        
        List<Album> ListAlbums = (from item in album where item.ReleaseDate.Year.Equals(year) select item).ToList();

        return ListAlbums;

    }

     public static List<Music> MusicsArtist(Artist artist){ 
                                
        var ListMusics = (artist.ArtistAlbums.SelectMany(x => x.Musics)).ToList();

        return ListMusics;

    }

    public static List<Music> MusicsArtistofYear(Artist artist, int year){ 
                                
        var ListAllMusics = MusicsArtist(artist);

        var ListMusicsofYear = (from item in ListAllMusics where item.RelaseDate.Year.Equals(year) select item).ToList();

        return ListMusicsofYear;

    }

    public static List<Album> AlbumsProducersGender(Producer producer, string gender){ 
                                
        List<Album> ListAlbums = (from elemento in producer.ProducerAlbums where elemento.GenderAlbum.Equals(gender) select elemento).ToList();

        return ListAlbums;

    }

     public static List<Album> AlbumsProducersYear(Producer producer, int year){ 
                                
        List<Album> ListAlbums = (from elemento in producer.ProducerAlbums where elemento.ReleaseDate.Year.Equals(year) select elemento).ToList();

        return ListAlbums;

    }



  }