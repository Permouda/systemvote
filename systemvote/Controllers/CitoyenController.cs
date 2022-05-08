using Microsoft.AspNetCore.Mvc;
using systemvote.services;
using systemvote.Models;
using System.Collections.Generic;


namespace systemvote.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitoyensController: ControllerBase
    {
    
       public CitoyensController()
       {
           
       }

       [HttpGet]
       public ActionResult<List<Citoyen>> GetAll() =>CitoyenServices.GetAll();
       [HttpGet("{id}")]
       public ActionResult<Citoyen> Get(int id)
       {
     var citoyen = CitoyenServices.Get(id);

    if(citoyen == null)
        return NotFound();

    return citoyen;
       }
       [HttpPost]
       public IActionResult Create(Citoyen citoyen)
       {
            CitoyenServices.Add(citoyen);
            return CreatedAtAction(nameof(Create), citoyen);

       }
       [HttpPut("{id}")]
       public IActionResult Update(int id,Citoyen citoyen)
       {
               if (id != citoyen.Citoyen_id)
                return BadRequest();
           
    
             var existingCitoyen = CitoyenServices.Get(id);
             if(existingCitoyen is null)
               return NotFound();
   
             CitoyenServices.Update(citoyen);           
            return NoContent();    
       }
       [HttpDelete("{id}")]
       public IActionResult Delete(int id)
       {
           var citoyen = CitoyenServices.Get(id);
   
           if (citoyen is null)
             return NotFound();
       
           CitoyenServices.Delete(id);
           return NoContent();
       }


    }

}