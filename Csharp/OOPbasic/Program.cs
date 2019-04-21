using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace oopbasic
{
    public class Program
    {
        static int[] array1 = {1, 2, 3};

        static void Main (string[] args)
        {  
            Bicycle bicycle = new Bicycle();
            bicycle.RIde();

            bicycle = new Bicycle(25);
            bicycle.RIde();

            bicycle = new Bicycle(24, "green");
            bicycle.RIde();

            Console.ReadKey();

        }
    }
}
