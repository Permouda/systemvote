namespace systemvote.Models
{
    public class Administrateur
    {
        public Administrateur(int admin_id, string nom, string role) 
        {
            this.admin_id = admin_id;
                this.nom = nom;
                this.role = role;
               
        }
        public int admin_id {get;set;}
        public string nom {get; set;}
        public string role {get; set;}
    }
}