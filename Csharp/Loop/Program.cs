using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace loop
{
    public class Program
    {

        static void Main (string[] args)
        {
            EvenCount evenCount = new EvenCount();
            evenCount.CountEven();
        }
    }
}
