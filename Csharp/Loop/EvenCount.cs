using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace loop {
    public class EvenCount{

        public void CountEven(){
            int count = 0;
            for (int i = 0; i < 21; i = i + 2) {
                   count ++;
                }
            Console.WriteLine(count);
            }


        }
    }

