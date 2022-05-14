using Microsoft.EntityFrameworkCore;

namespace systemvote.Models
{
    public class EvotingContext:DbContext
    {

      public EvotingContext(DbContextOptions<EvotingContext> options):base(options)
      {

      }   

       public DbSet<Citoyen> citoyens { get; set; }
       public DbSet<Region> regions { get; set; } 
       public DbSet<Partie_politique> part_pol { get; set; } 
       public DbSet<Administrateur> Admins { get; set; } 
       public DbSet<Vote> votes { get; set; } 
        
    }

    
}