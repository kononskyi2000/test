using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace lesson7
{
    public class PlayWithChar
    {
        public void CharToString(){
        char[] charMyString = {'a', 'b', 'f', 'b'};
        string myResult = "";

        for (int i = 0; i < charMyString.Length; i++){
            myResult = myResult + charMyString[i];

        }
        Console.WriteLine(myResult);

        }


    }
}
