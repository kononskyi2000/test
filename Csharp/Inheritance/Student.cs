using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace inheritance {
    public class Student : Person {
        private String university;
        private string response = "Eehhhh,";

        public Student(String name, String university)
        : base(name)
        {
            this.university = university;
        }
        public String GetResponse(String question){
            return response;
        }
    
    }
}