using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace inheritance
{
    public class Program
    {
        static void Main (string[] args)
        {  
            Student student = new Student("Oleg", "KPI");
            
            Console.WriteLine(student.GetResponse(" WTF??"));

        }
    }
}
