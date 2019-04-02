using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace csharp {
    public class CircleArea{
        public const double PI = 3.14d;
            static double radius1, radius2, area1, area2;
            public void CalculateBigger(){

            Console.WriteLine("Enter radius1");
            radius1 = Convert.ToDouble(Console.ReadLine());
            area1 = radius1 * radius1 * PI;

            Console.WriteLine("Enter radius2");
            radius2 = Convert.ToDouble(Console.ReadLine());
            area2 = radius2 * radius2 * PI;

            if (area1 > area2){
                Console.WriteLine("Area1 is bigger");
            } else {
                Console.WriteLine("Area2 is bigger");
            }

            Console.ReadLine();
        
        }
    }
}