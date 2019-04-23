using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;


namespace getset
{
    public class Student {
        //private string university;
        private string response = "Ehhhh, what was the question?";
        public string GetResponse(){
            return response;
        }
        public void SetResponse(string response){
            if (!response.Equals(" ")){
                this.response = response;
            }
            }
        }

    }