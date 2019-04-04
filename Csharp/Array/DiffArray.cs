using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace array
{
    public class DiffArray
    {

        public void Arrays (){
            
             int[ ] intArray = {1, 2, 3};
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            bool[ ] booleanArray = {true, false, false};
            for (int j = 0; j < booleanArray.Length; j++)
            {
                Console.WriteLine(booleanArray[j]);
            }

            char[] charArray = {'s', '1', 't'};
            for (int j = 0; j < charArray.Length; j++)
            {
                Console.WriteLine(charArray[j]);
            }
        }
        
    }
}
