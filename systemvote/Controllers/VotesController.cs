using Microsoft.AspNetCore.Mvc;
using systemvote.services;
using systemvote.Models;
using System.Collections.Generic;

namespace systemvote.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class VotesController:ControllerBase
    {
               public VotesController()
                {
           
                }

       [HttpGet]
       public ActionResult<List<Vote>> GetAll() =>VoteServices.GetAll();
       [HttpGet("{id}")]
       public ActionResult<Vote> Get(int id)
       {
         var vote = VoteServices.Get(id);

    if(vote == null)
        return NotFound();

    return vote;
       }

    }
}