using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace oopbasic
{
    public class Bicycle{ 
        private int wheelSize;
        private string color;
        public Bicycle(int wheelSize, string color) {
            this.color = color;
            this.wheelSize = wheelSize;}
        public Bicycle (int wheelSize)
        :this()
        {
            this.wheelSize = wheelSize;
        }
        public Bicycle() {
            wheelSize = 26; color = "red";
        }
        public string RIde(){
            
            Console.WriteLine("Bycicle color is " + color + " size is " + wheelSize);
            return "Wriim!";
        }
        }
    }