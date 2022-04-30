using System;
using System.Collections.Generic;
using System.Linq;


public class Artist : Person {

    public string Musical_genre;
    public DateTime ContractDate;
    public List<Album> ArtistAlbums;

    public Artist(string Name, string CPF, DateTime BirthDate, DateTime DeathDate, string Musical_genre, DateTime ContractDate){

        this.Name = Name;
        this.CPF = CPF;
        this.BirthDate = BirthDate;
        this.DeathDate = DeathDate;
        this.Musical_genre = Musical_genre;
        this.ContractDate = ContractDate;
        ArtistAlbums = new List<Album>();
    }

}

