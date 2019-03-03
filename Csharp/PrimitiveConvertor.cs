using System;
using System.Threading.Tasks;
using System.Text;

namespace csharp{
    public class PrimitiveConvertor{

        public void FloatToChar(float float1) {
            char char1;
            char1 = (char) float1;
            Console.WriteLine("Input float value is " + float1 + " Output char value is " + char1);

        }

        public void IntToChar(int int1, char char1) {

            char1 = (char) int1;
            Console.WriteLine("Input float value is " + int1 + " Output char value is " + char1);

        }

        public void CharToInt(int int1, char char1) {

            int1 = (int) char1;
            Console.WriteLine("Input float value is " + char1 + " Output char value is " + int1);
    
        }
    }
}