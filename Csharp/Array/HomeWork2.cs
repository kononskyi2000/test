using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork2
    {
        public void Even (){
            int [] intEven = new int [50];
            
            int j = 0;
            for (int i = 1; i < 100; i = i +2)
            {
                intEven[j] = i;
                Console.Write(intEven[j] + " ");
                j ++ ;
                
            }
            Console.WriteLine();

            Array.Reverse(intEven);
            foreach (int val in intEven){
                Console.Write(val + " ");
            }

            Console.WriteLine();
        }
    }
}

