using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class FunctionOverloadingDemo
    {
        public void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void Print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        public void DispalyData()
        {

            // Call print to print integer
            Print(5);

            // Call print to print float
            Print(500.263);

            // Call print to print string
            Print("Hello C++");


        }
    }


    public class OperatorOverloadingDemo
    {
        public static OperatorOverloadingDemo operator ++(OperatorOverloadingDemo i)
        {
            Console.WriteLine("Printing instead of increment in {0}", i.ToString());
            return i;
        }

    }

    public class OverloadingDemo
    {
        OperatorOverloadingDemo operatorOverloadingDemo;
        FunctionOverloadingDemo functionOverloadingDemo;
        public OverloadingDemo()
        {

            functionOverloadingDemo = new FunctionOverloadingDemo();
            functionOverloadingDemo.DispalyData();
            operatorOverloadingDemo = new OperatorOverloadingDemo();
            operatorOverloadingDemo++;

        }
    }
}
