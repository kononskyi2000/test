using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace csharp {
    public class RightAngle{
            static double a, b, c, p1, p2;
            public void CalculateAngle(){

            Console.WriteLine("Enter side a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side c");
            c = Convert.ToDouble(Console.ReadLine());
            
            p1 = Math.Sqrt(a*a + b*b);
            p2 = Math.Sqrt(c*c);

            if ((p1 == p2) || (a*a == c*c + b*b) || (b*b == a*a + c*c)) {
                Console.WriteLine("Right-angeled triangle");
            } else {
                Console.WriteLine("Not Right-angeled triangle");
            }

            Console.ReadLine();
        
        }
    }
}