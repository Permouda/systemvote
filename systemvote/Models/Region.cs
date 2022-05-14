using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace systemvote.Models
{
    public class Region
    {
        public Region(int id, int code_region,string Name)
        {
            this.id = id;
            this.Code_region = code_region;
            this.Name = Name;

        }
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public int Code_region { get; set; }
        public ICollection<Citoyen> citoyens { get; set; }

    }

}