using System.Collections.Generic;
using systemvote.Models;
namespace systemvote.services
{
    public class RegionServices
    {
    static List<Region> regions { get; }
    static int nextId = 3;
    static RegionServices()
    {
        regions = new List<Region>
        {
            new Region (1,22,"casablanca-settat"),
            new Region (2,14,"sale-rabat"),
            
        };
    }
    public static List<Region> GetAll() => regions;
        
    
    public static Region? Get(int id)
    {
        foreach(Region r in regions)
        {
            if(r.id == id)
            {
                return r;
            }
            
        }
        return null;
    }

    public static void Add(Region region)
    {
        region.id = nextId++;
        regions.Add(region);
    }

    public static void Delete(int id)
    {
        var region = Get(id);
        if(region is null)
            return;

        regions.Remove(region);
    }

    public static void Update(Region region)
    {
        var index = regions.FindIndex(r => r.id == region.id);
        if(index == -1)
            return;

        regions[index] = region;
    }
  }
}