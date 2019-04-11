using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace lesson7
{
    public class IterateString
    {
        public void Iterate(){
            string strOriginal = "THese functions will come handly";
            
            foreach (char c in strOriginal){
                Console.WriteLine(c.ToString() + ' ');
            }


    }
}
}