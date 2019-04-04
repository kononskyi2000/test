using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork3
    {
        public void Random1 ()
        {
            int [] intRandom = new int [15];
            Random r = new Random();
            int k = 0;

            for (int i = 0; i < intRandom.Length; i++){
                intRandom[i] = r.Next(0,9);
                Console.Write(intRandom[i] + " ");
                }
            
            Console.WriteLine();

            for (int j =0; j < 15; j++){

                if (intRandom[j] %2 == 0){
                    k = k+1;
                }

            }
            Console.WriteLine("Sum = " + k);
            
            Console.WriteLine();

        }
    }
}
