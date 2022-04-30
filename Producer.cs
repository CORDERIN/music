using System;
using System.Collections.Generic;
using System.Linq;

public class Producer : Person {
    public List<string> Musical_genres;

    public List<Album> ProducerAlbums;
    public string Music_producer;

     public Producer(string Name, string CPF, DateTime BirthDate, DateTime DeathDate, string Music_producer){

        base.Name = Name;
        base.CPF = CPF;
        base.BirthDate = BirthDate;
        base.DeathDate = DeathDate;
        this.Music_producer = Music_producer;
        Musical_genres = new List<string>();
        ProducerAlbums = new List<Album>();
    }

}


