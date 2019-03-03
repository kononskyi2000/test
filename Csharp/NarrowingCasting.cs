using System;
using System.Threading.Tasks;
using System.Text;

namespace csharp{
    public class NarrowingCasting{
        int int1 = 127;
        float float1 = 0.0F;

        public void Narrowing(){
            float1 = int1;
            Console.WriteLine(float1);
        }
    }
}