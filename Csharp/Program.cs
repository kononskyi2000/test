using System;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            WideningCasting wideningCasitng = new WideningCasting();
            wideningCasitng.Conversion(); 

            NarrowingCasting narrowingCasting = new NarrowingCasting();
            narrowingCasting.Narrowing();

            Console.ReadLine();

        }
    }
}
