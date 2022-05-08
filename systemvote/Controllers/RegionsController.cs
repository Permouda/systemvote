using Microsoft.AspNetCore.Mvc;
using systemvote.services;
using systemvote.Models;
using System.Collections.Generic;
namespace systemvote.Controllers
{  
    
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : ControllerBase
    {
     public RegionsController()
     {

     }

       [HttpGet]
       public ActionResult<List<Region>> GetAll() =>RegionServices.GetAll();
       [HttpGet("{id}")]
       public ActionResult<Region> Get(int id)
       {
     var region = RegionServices.Get(id);

    if(region == null)
        return NotFound();

    return region;
       }


    }

    }
