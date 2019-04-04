using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork1_2
    {
        public void Odd2 (){
            int[] intArray = new int[10];

            for (int j=0; j < 1; j++){
                for (int k = 2; k < 21; k= k+2){
                    Console.Write(k + " ");
                }
            }
            Console.WriteLine();
            foreach (int val in intArray)
            {
                Console.WriteLine(val + " ");
            }
            

        }
    }
}
