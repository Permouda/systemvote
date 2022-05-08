using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core;
namespace systemvote.Models
{
	public class Vote
{
        public Vote(int id, int citoyenid,DateTime dt)
        {
			this.id = id;
			this.Citoyen_id = citoyenid;
			this.date_vote = dt;
             Console.WriteLine($"date is:{dt}");
        }

        [ForeignKey("Citoyen")]
	public int Citoyen_id { get; set; }
	[Key]
	public int id { get; set; }
	DateTime date_vote{get;set;}
	public virtual Citoyen citoyen{get;set;}
	

}

}

