using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class MultiDimension
    {
        public void Thtouhgt (){
            int[][] intArray = new int[2][];
            for (int i=0; i <intArray.Length; i++){
                intArray[i] = new int [3];
            }
            
            for (int j=0; j < intArray.Length; j++){
                for (int k=0; k < intArray[j].Length; k++){
                    intArray[j][k] = j + k; 
                    Console.Write(intArray[j][k] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
