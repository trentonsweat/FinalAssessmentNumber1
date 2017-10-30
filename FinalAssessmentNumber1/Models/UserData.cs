using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalAssessmentNumber1.Models
{
    public class UserData
    {
        private int num1;
        private int num2;
      


        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }

        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }

        

        //default constructor
        public UserData()
        {
            Num1 = 0;

            Num2 = 0;

            
        }

        //overloaded constructor
        public UserData(int n1, int n2)
        {
            Num1 = n1;

            Num2 = n2;

           
        }


    }
}