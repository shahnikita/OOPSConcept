using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class BaseClass
    {
        public virtual void OverrideVirtual() {
            Console.WriteLine("OverrideVirtual-BaseClass");
        }

        public void HidingBaseClass()
        {
            Console.WriteLine("HidingBaseClass-BaseClass");
        }

        public virtual void UsageSealedClass() {
            Console.WriteLine("UsageSealedClass-BaseClass");
        }


        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void OverrideVirtual()
        {
            Console.WriteLine("OverrideVirtual-DerivedClass");
        }

        public new void HidingBaseClass()
        {
            Console.WriteLine("HidingBaseClass-DerivedClass");
        }
        public override int WorkProperty
        {
            get { return 10; }
        }

        public sealed override void UsageSealedClass()
        {
            Console.WriteLine("UsageSealedClass-DerivedClass");
        }

        //Accessing Base Class Virtual Members from Derived Classes
        public void AccessingBaseClassVirtual() {
            Console.WriteLine("Accessing Base Class:" + base.WorkProperty);
        } 
    }

    public class PolymorphismDemo {
        public PolymorphismDemo() {

            DerivedClass B = new DerivedClass();
            B.OverrideVirtual();  // override virtual members in the base class,
            B.HidingBaseClass();//Hiding Base Class Members with New Members
            B.UsageSealedClass();//Preventing Derived Classes from Overriding Virtual Members
            B.AccessingBaseClassVirtual();////Accessing Base Class Virtual Members from Derived Classes

            BaseClass A = (BaseClass)B;
            A.OverrideVirtual();  // override virtual members in the base class,
            A.HidingBaseClass();//Hiding Base Class Members with New Members
            A.UsageSealedClass();//Preventing Derived Classes from Overriding Virtual Members
            
        }
    
    }
   
}
