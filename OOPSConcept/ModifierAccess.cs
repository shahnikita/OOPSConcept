using System;
using TestLib;



namespace OOPSConcept
{
    public class C : A
    {
        public C() {
          
            PublicDisplay();
            ProtectedDisplay();
            ProtectedInternalDisplay();
        }
    }
    
   public class ModifierAccess
    {
       public ModifierAccess()
       {

           Console.WriteLine("\n");
           Console.WriteLine("Base Class");
           A a = new A(5);

           Console.WriteLine("\n");
           Console.WriteLine("Derived Class in same namespace.method access in same namespcase");
           B b1 = new B(6);

           Console.WriteLine("\n");
           Console.WriteLine("Derived Class in another namespace.");
           C c = new C();

          
           
       
       }
    }
}



