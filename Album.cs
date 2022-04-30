using System;
using System.Collections.Generic;
using System.Linq;

public class Album{

    public List<Music> Musics;
    public Artist artist;
    public Producer producer;
    public string NameAlmbum;
    public string GenderAlbum;
    public string AlbumCover;
    public DateTime ReleaseDate;

    public Album(Artist artist, Producer producer, string NameAlmbum, string GenderAlbum, string AlbumCover, DateTime ReleaseDate  ){

        Musics = new List<Music>();
        this.artist = artist;
        this.producer = producer;
        this.NameAlmbum = NameAlmbum;
        this.GenderAlbum = GenderAlbum;
        this.AlbumCover = AlbumCover;
        this.ReleaseDate = ReleaseDate;

    }

}
