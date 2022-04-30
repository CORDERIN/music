using System;
using System.Collections.Generic;
using System.Linq;

public class Music{

   public string NameMusic;
   public double TimeMusic;
   public string MusicalGender;
   public DateTime RelaseDate;

   public Music(string name, double time, string Musical_Gender, DateTime RelaseDate){

      this.NameMusic = name;
      this.TimeMusic = time;
      this.MusicalGender = Musical_Gender;
      this.RelaseDate = RelaseDate;
   }
    
}