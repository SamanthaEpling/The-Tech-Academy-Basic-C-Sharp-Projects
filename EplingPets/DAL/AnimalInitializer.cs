using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EplingPets.Models;

namespace EplingPets.DAL
{
    public class AnimalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            var pets = new List<Pet>
                {
                    new Pet{PetName="Lionel",PetAge=5, PetSex="MN"},
                    new Pet{PetName="Romani", PetAge=22, PetSex="Gelding"},
                    new Pet{PetName="Mr. Bubbles", PetAge=12, PetSex="MN"}
                };

            pets.ForEach(p => context.Pets.Add(p));
            context.SaveChanges();

            var breeds = new List<Breed>
            {
                new Breed{BreedName="Tibetan Spaniel/Dachshund Mix", BreedCountryOfOrigin="China", BreedDescription=""},
                new Breed{BreedName="Arabian", BreedCountryOfOrigin="Middle East, Arabian peninsula", BreedDescription=""},
                new Breed{BreedName="Domestic Shorthair", BreedCountryOfOrigin="United States of America", BreedDescription=""}
            };

            breeds.ForEach(b => context.Breeds.Add(b));
            context.SaveChanges();

            var species = new List<Species>
            {
                new Species{SpeciesName="Canine", SpeciesDescription=""},
                new Species{SpeciesName="Equine", SpeciesDescription=""},
                new Species{SpeciesName="Feline", SpeciesDescription=""}
            };

            species.ForEach(s => context.SpeciesList.Add(s));
            context.SaveChanges();

        }
    }
}