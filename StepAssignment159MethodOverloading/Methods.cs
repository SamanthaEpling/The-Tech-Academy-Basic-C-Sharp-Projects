using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment159MethodOverloading
{
    public class Methods
    {
        public static string TimesTen(string givenNumber)
        {
            return (givenNumber +" 10");
        }

        public static int TimesTen(decimal givenNumber2)
        {
            return Convert.ToInt32(givenNumber2) / 4;
        }

        public static int TimesTen(int givenNumber3, int givenNumber4)
        {
            return (givenNumber3) * (givenNumber4);
        }
    }
}
