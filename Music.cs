using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Music{

   public string NameMusic;
   public float TimeMusic;
   public string MusicalGender;
   public DateTime RelaseDate;

   public Music(string name, float time, string Musical_Gender, DateTime RelaseDate){

      this.NameMusic = name;
      this.TimeMusic = time;
      this.MusicalGender = Musical_Gender;
      this.RelaseDate = RelaseDate;
   }
    
}