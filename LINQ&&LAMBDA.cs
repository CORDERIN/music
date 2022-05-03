  
  public class LinqAndLambda{

    public static List<Album> AlbumsofArtist(Artist artist, string name){ 
                                
        
        List<Album> ListAlbums = (from item in artist.ArtistAlbums where artist.Name.Equals(name) select item).ToList();

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

  }