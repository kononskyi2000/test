using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace getset
{
    public class Program
    {
        static int[] array1 = {1, 2, 3};

        static void Main (string[] args)
        {  
            Student student = new Student();

            Console.WriteLine(student.SetResponse("DFDSFSDF"));

           

        }
    }
}
