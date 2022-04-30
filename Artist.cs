using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Artist : Person {

    public string Musical_genre;
    public DateTime ContractDate;

    public Artist(string Name, string CPF, DateTime BirthDate, DateTime DeathDate, string Musical_genre, DateTime ContractDate){

        base.Name = Name;
        base.CPF = CPF;
        base.BirthDate = BirthDate;
        base.DeathDate = DeathDate;
        this.Musical_genre = Musical_genre;
        this.ContractDate = ContractDate;
    }

}

