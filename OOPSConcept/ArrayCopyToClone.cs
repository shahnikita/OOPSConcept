using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class ArrayCopyToClone
    {
        public ArrayCopyToClone() {

            ArrayClone();
            ArrayCopyTo();
        }

        public void ArrayCopyTo()
        {
            string[] Original = new string[1];
            Original[0] = "original";

            string[] CopyToArray = new string[1];
            Original.CopyTo(CopyToArray, 0);//copies the elements into another existing array
            CopyToArray[0] = "CopyToArray";

            Console.WriteLine(Original[0]);
            Console.WriteLine(CopyToArray[0]);
         
        }

        public void ArrayClone()
        {
            string[] Original = new string[1];
            Original[0] = "original";

            string[] CloneArray = (string[])Original.Clone();//returns a new array (a shallow copy) object containing all the elements in the original array
            CloneArray[0] = "Clone";
            Console.WriteLine(Original[0]);
            Console.WriteLine(Original[0]);
           
        }
    }
}
