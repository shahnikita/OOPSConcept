using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ModifierAccess");
            ModifierAccess modifierAccess = new ModifierAccess();
            Console.WriteLine("End---ModifierAccess");

            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("PolymorphismDemo");
            PolymorphismDemo polymorphismDemo = new PolymorphismDemo();
            Console.WriteLine("End---PolymorphismDemo");

            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("OverloadingDemo");
            OverloadingDemo overloadingDemo = new OverloadingDemo();
            Console.WriteLine("End---OverloadingDemo");


            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("DiffConstReadOnlyStatic");
            DiffConstReadOnlyStatic diffConstReadOnlyStatic = new DiffConstReadOnlyStatic();
            Console.WriteLine("End---DiffConstReadOnlyStatic");


            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("DiffDisposeFinallyFinalize");
            DiffDisposeFinallyFinalize diffDisposeFinallyFinalize = new DiffDisposeFinallyFinalize();
            Console.WriteLine("End---DiffDisposeFinallyFinalize");


            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("DiffRefOut");
            DiffRefOut diffRefOut = new DiffRefOut();
            Console.WriteLine("End---DiffRefOut");


            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("DiffStringAndStringBuilder");
            DiffStringAndStringBuilder diffStringAndStringBuilder = new DiffStringAndStringBuilder();
            Console.WriteLine("End---DiffStringAndStringBuilder");


            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("ArrayCopyToClone");
            ArrayCopyToClone arrayCopyToClone = new ArrayCopyToClone();
            Console.WriteLine("End---ArrayCopyToClone");

            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("IsAndAsOperators");
            IsAndAsOperators isAndAsOperators = new IsAndAsOperators();
            Console.WriteLine("End---IsAndAsOperators");



            Console.ReadKey();
        }
    }
}
