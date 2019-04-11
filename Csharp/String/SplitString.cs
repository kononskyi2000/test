using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace lesson7
{
    public class SplitString
    {
        public void SplitStr(){

             string strOriginal = "THese functions will come handly";

             char[] delim = {' ', 'l'};
             string [] strArray = strOriginal.Split(delim);
             foreach (string s in strArray){
                 Console.WriteLine(s);
             }

        }
    }
}