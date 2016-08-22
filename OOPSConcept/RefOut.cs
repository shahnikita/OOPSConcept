using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class RefOut
    {
        public string Test(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;

        }
       // public void Test(out int id)// compiler error “cannot define overloaded”
        public void Test1(out int id) //An argument that is passed using an out keyword must be initialized 
        {
            id = 100;//must be intialized       
            id += 1;
        }
    }
    public class DiffRefOut
    {
      public DiffRefOut()
        {
            RefOut refOut = new RefOut();
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = refOut.Test(ref i);
            Console.WriteLine("Current value of integer i:" + i.ToString());

            refOut.Test1(out i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
        }

    }
}
