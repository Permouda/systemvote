using System.Collections.Generic;
using systemvote.Models;
namespace systemvote.services

{

    public static class CitoyenServices
    {
    static List<Citoyen> Citoyens { get; }
    static int nextId = 3;
    static CitoyenServices()
    {
        Citoyens = new List<Citoyen>
        {
            new Citoyen (1,"Ennaoui","ayoub",129888990 ),
            new Citoyen (2,"Rattal","mohammed", 9888666 ),
            
        };
    }
    public static List<Citoyen> GetAll() => Citoyens;
        
    
    public static Citoyen? Get(int id)
    {
        foreach(Citoyen c in Citoyens)
        {
            if(c.Citoyen_id == id)
            {
                return c;
            }
            
        }
        return null;
    }

    public static void Add(Citoyen citoyen)
    {
        citoyen.Citoyen_id = nextId++;
        Citoyens.Add(citoyen);
    }

    public static void Delete(int id)
    {
        var citoyen = Get(id);
        if(citoyen is null)
            return;

        Citoyens.Remove(citoyen);
    }

    public static void Update(Citoyen citoyen)
    {
        var index = Citoyens.FindIndex(C => C.Citoyen_id == citoyen.Citoyen_id);
        if(index == -1)
            return;

        Citoyens[index] = citoyen;
    }

    }
}