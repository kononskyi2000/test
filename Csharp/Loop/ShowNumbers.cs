using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace loop {
    public class ShowNumbers{
        
        public void Showlist(){
            // Show 0 2 4 6 8 10
            for (int i = 0; i < 11; i = i + 2) {
                
                Console.Write(i + " ");
            }
        
            // Show 0 1 2 3 4 ....
            for (int j = 0; j < 11; j++) {
                
                Console.WriteLine(j + " ");
            }
        }

    }
}