using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class IsAndAsOperators
    {
       public IsAndAsOperators() {

            TestIsOperator("45");
            TestAsOperator(546);
        }
        public void TestIsOperator(object o)
        {
            int a;
            string b;
            if (o is int)
            {
                Console.WriteLine("o is int");
                a = (int)o;
            }
            else if (o is string)
            {
                Console.WriteLine("o is string");
                b = (string)o;
            }
            else
            {
                Console.WriteLine("o is neither Class1 nor Class2.");
            }
        }


        public void TestAsOperator(object o) {

            string s = o as string;
          
            if (s != null)
                Console.WriteLine("'" + s + "'");
            else
                Console.WriteLine("not a string");
        }
    }
}
