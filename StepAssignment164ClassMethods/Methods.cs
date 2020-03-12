using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment164ClassMethods
{
    public class Methods
    {
        public static void DivideByTwo(int numberOne, out int result)
        {
            result = numberOne / 2;
        }
        public static int DivideByQuarter(int numberTwo, out int result2)
        {
            result2 = numberTwo * (1 / 4);
            return result2;
        }

        public static decimal DivideByQuarter(decimal numberThree, out decimal result3)
        {
            result3 = numberThree / 4;
            return result3;
        }
    }
}
