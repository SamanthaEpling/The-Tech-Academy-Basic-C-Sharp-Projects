using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131AssignmentStringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========Section 1: Concatenate three strings. ==========

            string One = "horses and ";
            string Two = "cats make the best pets, ";
            string Three = "but don't forget dogs too!";
            Console.WriteLine(One + Two + Three);
            Console.ReadLine();

            // ==========Section 2: Convert a string to uppercase. ==========
            //string One = "Horses and ";
            //string Two = "cats make the best pets, ";
            //string Three = "but don't forget dogs too!";
            //Three = Three.ToUpper();
            //Console.WriteLine(One + Two + Three);
            //Console.ReadLine();

            // ==========Section 3: Create a Stringbuilder and build a paragraph of text, one sentence at a time. ==========

            //StringBuilder Paragraph = new StringBuilder();
            //Paragraph.Append("This paragraph is about my pets.");
            //Paragraph.Append("  My dog's name is Lionel.");
            //Paragraph.Append("  My horse's name is Romani.");
            //Paragraph.Append("  And my cats's names are: Mister, Hermione, Love Bug, Fiona, Rosie Tinker Bell, and Mr. Bubbles.");
            //Console.WriteLine(Paragraph);
            //Console.ReadLine();
        }
    }
}
