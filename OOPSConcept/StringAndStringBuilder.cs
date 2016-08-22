using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class StringAndStringBuilder
    {
        //hen you create a string you can never change it, rather it will create a new string to store the new value, this can be inefficient if you need to change the value of a string variable a lot.
        public void TestForString()
        {
            string foo = "Foo";
            Console.WriteLine("Original String: " + foo);
            // returns a new string instance instead of changing the old one
            string bar = foo.Replace('o', 'a');
            string baz = foo + "bar";
            Console.WriteLine("Appended String: " + foo);
        }

        public void TestForStringBuilder()
        {
            StringBuilder sb = new StringBuilder("foo ");
            Console.WriteLine("Original StringBuilder: " + sb.ToString());
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
                sb.Append(' ');
            }
            Console.WriteLine("Appended StringBuilder: " + sb.ToString());
        }
    }

    public class DiffStringAndStringBuilder
    {
        public DiffStringAndStringBuilder()
        {
            StringAndStringBuilder stringAndStringBuilder = new StringAndStringBuilder();
            stringAndStringBuilder.TestForString();
            stringAndStringBuilder.TestForStringBuilder();
        }
    }
}
