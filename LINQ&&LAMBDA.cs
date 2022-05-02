  
  public class LinqAndLambda{

    public static List<Album> AlbumsofArtist(Artist artist){ 
                                
        
        List<Album> ListAlbums = (from item in artist.ArtistAlbums select item).ToList();

        return ListAlbums;

    }

  }