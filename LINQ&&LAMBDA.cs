  
  public class LinqAndLambda{

    public static List<Album> AlbumsofArtist(Artist artist, string name){ 
                                
        
        List<Album> ListAlbums = (from item in artist.ArtistAlbums where artist.Name.Equals(name) select item).ToList();

        return ListAlbums;

    }

    public static List<Album> AlbumsofYear(List<Album> album, int ano){ 
                                
        
        List<Album> ListAlbums = (from item in album where item.ReleaseDate.Year.Equals(ano) select item).ToList();

        return ListAlbums;

    }

     public static List<Music> MusicsArtist(Artist artist){ 
                                
        var ListMusics = (artist.ArtistAlbums.SelectMany(x => x.Musics)).ToList();

        return ListMusics;

    }

  }