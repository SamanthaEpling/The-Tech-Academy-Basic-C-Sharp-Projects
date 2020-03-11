using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment161voidMethods
{
    public class Methods
    {
        public static void Calc1(int numberOne, int numberTwo, out bool result)
        {
            result = (numberOne * numberOne) > (numberTwo * numberTwo);
        }
    }
}
