using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EplingPets.Models
{
    public class Species
    {
        public int SpeciesId { get; set; }
        public string SpeciesName { get; set; }
        public string SpeciesDescription { get; set; }
        public int BreedId { get; set; }
        public virtual ICollection<Breed> Breeds { get; set; }
    }
}