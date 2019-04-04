using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork4
    {
        public void MinMax ()
        {
            int [] intRandom = new int [15];
            Random r = new Random();
            int max = 0;
            int min = 999;

            for (int i = 0; i < intRandom.Length; i++){
                intRandom[i] = r.Next(0,999);
                Console.Write(intRandom[i] + " ");
                }
                Console.WriteLine();

            foreach (int a in intRandom){
                if (a > max){
                    max = a;
                }
            }
            foreach (int b in intRandom){
                if (b < min){
                    min = b;
                }
            }
            //int maxValue = intRandom.Max();
            //int minValue = intRandom.Min();
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);


        }
    }
}
