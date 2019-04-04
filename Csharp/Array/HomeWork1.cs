using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork1
    {
        public void Odd (){
            int[][] intArray = new int[2][];
            for (int i=0; i <intArray.Length; i++){
                intArray[i] = new int [1];
            }
            
            for (int j=0; j < intArray[0].Length; j++){
                for (int k = 2; k < 21; k= k+2){
                    Console.Write(k + " ");
                }
            }
            Console.WriteLine();
            for (int n=0; n < intArray[1].Length; n++){
                for (int m = 2; m < 21; m= m+2){
                    Console.WriteLine(m);
                }
            }

        }
    }
}
