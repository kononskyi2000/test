using System;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    public class Program
    {

        static void Main (string[] args)
        {
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
    
                //Console.WriteLine("a equel = " + a, "b equel = " + b);
        
            
        }
    }
}
