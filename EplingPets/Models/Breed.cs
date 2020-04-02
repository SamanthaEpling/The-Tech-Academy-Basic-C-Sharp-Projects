using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EplingPets.Models
{
    public class Breed
    {
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        public string BreedCountryOfOrigin { get; set; }
        public string BreedDescription { get; set; }
        public virtual ICollection<Breed> Breeds { get; set; }
        public int SpeciesId { get; set; }
        public virtual ICollection<Species> Species { get; set; }
    }
}