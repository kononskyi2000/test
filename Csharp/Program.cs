using System;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Program
    {

        static void Main (string[] args)
        {
            Console.WriteLine("Enter 1 for right-angled/ Enter 2 for calculate circle area/ Enter 3 for calculate EvenOdd ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 1){
                RightAngle rightAngle = new RightAngle();
                rightAngle.CalculateAngle(); 
            }
            else if (a == 2) {
                CircleArea circleArea = new CircleArea();
                circleArea.CalculateBigger();
            }
            else if (a == 3) {
                EvenOdd evenOdd = new EvenOdd();
                evenOdd.isEven(4);
            }
            else {
                Console.WriteLine("Please, enter from 1 - 3 digit");
                Console.ReadLine();
            }
            
        }
    }
}
