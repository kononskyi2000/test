using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace loop {
    public class Increment{

        public void ShomIncrement(){
            int a = 1;
            Console.WriteLine("Origin a value " + a);
            Console.WriteLine("Post-increment a " + a++);
            Console.WriteLine("After post-icrement " + a);
            Console.WriteLine("Pre-increment a" + ++a);
            Console.WriteLine("After pre-increment " + a);
        }
    }
}