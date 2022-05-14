using Microsoft.AspNetCore.Mvc;
using systemvote.services;
using systemvote.Models;
using System.Collections.Generic;

namespace systemvote.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
       public AdminController()
       {
          
       }

       [HttpGet]
       public ActionResult<List<Administrateur>> GetAll() =>AdminServices.GetAll();
       [HttpGet("{id}")]
       public ActionResult<Administrateur> Get(int id)
       {
     var admin = AdminServices.Get(id);

    if(admin == null)
        return NotFound();

       return admin;
       }

       [HttpPost]
       public IActionResult Create(Administrateur admin)
       {
            AdminServices.Add(admin);
            return CreatedAtAction(nameof(Create), admin);

       }

       [HttpPut("{id}")]
       public IActionResult Update(int id,Administrateur admin)
       {
               if (id != admin.admin_id)
                return BadRequest();
           
    
             var existingAdmin = AdminServices.Get(id);
             if(existingAdmin is null)
               return NotFound();
   
             AdminServices.Update(admin);           
            return NoContent();    
       }

       [HttpDelete("{id}")]
       public IActionResult Delete(int id)
       {
           var admin = AdminServices.Get(id);
   
           if (admin is null)
             return NotFound();
       
           AdminServices.Delete(id);
           return NoContent();
       }

    }
}