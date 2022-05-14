using Microsoft.AspNetCore.Mvc;
using systemvote.services;
using systemvote.Models;
using System.Collections.Generic;
namespace systemvote.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Partie_polController : ControllerBase
    {
       [HttpGet]
       public ActionResult<List<Partie_politique>> GetAll() =>partie_polServices.GetAll();
       [HttpGet("{id}")]
       public ActionResult<Partie_politique> Get(int id)
       {
     var partie_pol = partie_polServices.Get(id);

    if(partie_pol == null)
        return NotFound();

    return partie_pol;
       }

    }
    
    }
