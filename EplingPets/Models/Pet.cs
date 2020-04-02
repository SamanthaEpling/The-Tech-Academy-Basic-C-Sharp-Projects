using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EplingPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public string PetSex { get; set; }
        public virtual ICollection<Breed> Breed { get; set; }
        public virtual ICollection<Species> Species { get; set; }
    }
}