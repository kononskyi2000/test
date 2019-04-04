using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class HomeWork5
    {
        public void DifficultArray ()
        {
            int [][] intRandom = new int [8][];
            for (int i=0; i <intRandom.Length; i++){
                intRandom[i] = new int [5];
            }

            Random r = new Random();

            for (int m = 0; m < intRandom.Length; m++){
                for (int j = 0; j < intRandom[m].Length; j++)
                {
                    intRandom[m][j] = r.Next(0,999);
                    Console.Write(intRandom[m][j] + "\t");    
                }
                Console.WriteLine();    
            }
                Console.WriteLine();
        }
    }
}
