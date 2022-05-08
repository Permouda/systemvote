using System;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
namespace systemvote.Models
{
    public class Citoyen
    {


        public Citoyen(int id, string nom, string prenom, int cin)
        {
           this.Citoyen_id = id;
           this.Nom = nom;
           this.Prenom = prenom;
           this.CIN = cin;      
        }
        [Key]
        public int Citoyen_id { get; set; }
        public string? Nom { get; set; }
        public string Prenom { get; set; }
        public int CIN { get; set; }
        public virtual Vote vote{get; set;}

    }

}


