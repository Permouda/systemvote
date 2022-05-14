using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace systemvote.Models
{
    public class Partie_politique
    {
        public Partie_politique(string nom, string nom_president, int id)
        {
            this.nom = nom;
            this.nom_president = nom_president;
            this.id = id;

        }
        public string nom { get; set; }
        public string nom_president { get; set; }
        [Key]
        public int id { get; set; }
        public ICollection<Vote> votes { get; set; }
    }

}