using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLib
{
    public class A
    {
        public A() { }
        public A(int i) {
            PublicDisplay();
            ProtectedDisplay();
            ProtectedInternalDisplay();
            InternalDisplay();            
            PrivateDisplay();
        }

        internal void InternalDisplay()
        {
            Console.WriteLine("Internal Display Method.Access is limited to the current assembly.");
        }

        protected void ProtectedDisplay()
        {
            Console.WriteLine("Protected Display Method.Access is limited to the containing class or types derived from the containing class.");
        }

        protected internal void ProtectedInternalDisplay()
        {
            Console.WriteLine("ProtectedInternal Display Method.Access is limited to the current assembly or types derived from the containing class.");
        }

        public void PublicDisplay()
        {
            Console.WriteLine("Public Display Method.Access is not restricted.");
        }
        private void PrivateDisplay()
        {
            Console.WriteLine("Private Display Method.Access is limited to the containing type.");
        }
    }

    public class B : A
    {

        public B() { }
        public B(int s)
        {
            PublicDisplay();
            ProtectedDisplay();
            ProtectedInternalDisplay();
            InternalDisplay();           
        }
    }
}
