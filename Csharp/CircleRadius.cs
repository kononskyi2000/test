using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace csharp {
    public class CircleRadius{
        static double radius, pi, circleArea;
        public void Calculate(){
            Console.WriteLine("Input radius");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input pi");
            pi = Convert.ToDouble(Console.ReadLine());
            
            circleArea = pi * radius * radius;
            Console.WriteLine("Area is " + circleArea);
            Console.ReadLine();
        }
    }
}