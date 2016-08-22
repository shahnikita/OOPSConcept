using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
   
    public class DisposeFinallyFinalize:IDisposable
    {

        public void Test()
        {
            try
            {
                int i = 0;
                int j = 7 / i;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            finally
            {
               
                Console.WriteLine("Finally");
                
            }
        }
        //Destrucor also called Finalize   
        ~DisposeFinallyFinalize()
        {
            Console.WriteLine("Finalize-used to free unmanaged resources-By GC-DisposeFinallyFinalize");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose-free unmanaged resources like files, database connections etc. at any time.");
        }

        
    }

    public class DiffDisposeFinallyFinalize
    {
        public DiffDisposeFinallyFinalize(){
            using (DisposeFinallyFinalize w = new DisposeFinallyFinalize())
            {
                w.Test();
                
            }
        
        }
    }

}
