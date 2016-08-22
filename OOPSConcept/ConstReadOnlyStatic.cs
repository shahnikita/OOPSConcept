using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class ConstReadOnlyStatic
    {
        const string co = "Constant";//a variable of which the value is constant but at compile time
        readonly string re;
        static string s;
        readonly static string Sre;

         static ConstReadOnlyStatic() {
            Sre = " readonly static Variable from Static default constructor only.";
            Console.WriteLine(Sre);
        
        }
        public  ConstReadOnlyStatic(string className) {

            Console.WriteLine(co);

            re = "readonly intialized by parameter constructor "+className;
            Console.WriteLine(re);

            s += " static Variable " + className;
            Console.WriteLine(s);

         
        }

    }

    public class DiffConstReadOnlyStatic {
        ConstReadOnlyStatic c1;
        ConstReadOnlyStatic c2;

       public DiffConstReadOnlyStatic() {
           c1 = new ConstReadOnlyStatic("c1");
           c2 = new ConstReadOnlyStatic("c2");

        
        }
    }
}
