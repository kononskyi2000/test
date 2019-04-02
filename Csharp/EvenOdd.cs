using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace csharp {
    public class EvenOdd{
            public bool isEven (int val){
                int k = val / 2;
                if ( k == (double)val/2){
                    return true;}
                else {
                    return false;}

            }
    }
}