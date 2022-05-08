using System.Collections.Generic;
using systemvote.Models;
namespace systemvote.services
{
    public class partie_polServices
    {
          static List<Partie_politique> Partie_politiques { get; }
    static int nextId = 3;
    static partie_polServices()
    {
        Partie_politiques = new List<Partie_politique>
        {
            new Partie_politique ("adala w tanmiya","saadedine othmani",1 ),
            new Partie_politique ("tractour","chi wahed mkn3rfouch", 2 ),
            
        };
    }
    public static List<Partie_politique> GetAll() => Partie_politiques;
        
    
    public static Partie_politique? Get(int id)
    {
        foreach(Partie_politique p in Partie_politiques)
        {
            if(p.id == id)
            {
                return p;
            }
            
        }
        return null;
    }

    public static void Add(Partie_politique partie_pol)
    {
        partie_pol.id = nextId++;
        Partie_politiques.Add(partie_pol);
    }

    public static void Delete(int id)
    {
        var Partie_politique = Get(id);
        if(Partie_politique is null)
            return;

        Partie_politiques.Remove(Partie_politique);
    }

    public static void Update(Partie_politique partie_pol)
    {
        var index = Partie_politiques.FindIndex(p => p.id == p.id);
        if(index == -1)
            return;

        Partie_politiques[index] = partie_pol;
    }
    }
}