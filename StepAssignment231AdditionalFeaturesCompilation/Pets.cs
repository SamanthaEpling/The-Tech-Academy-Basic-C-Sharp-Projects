using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment231AdditionalFeaturesCompilation
{
    class Pets
    {
        public Pets(string name) : this(name, 5)
        { }
        public Pets(string name, int startingAge)
        {
            Name = name;
            Age = startingAge;

        }

        public int Age { get; set; }
        public string Name { get; set; }

        public Guid Id { get; set; }
    }
}
