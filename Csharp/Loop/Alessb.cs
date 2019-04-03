using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace loop {
    public class Alessb{

        public void Compareab(){

                Console.WriteLine("Enter a number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter b number");
                int b = Convert.ToInt32(Console.ReadLine());

                do {
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                        a = a -1;
                }
                while (a > b);
            }
    }
}
