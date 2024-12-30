using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
   class Faculty : Student
    {

        //public char gender { get; set; }

        //public string pname { get; set; }

        //public static int id = 0;
        //public string City { get; set; }
        //public string State { get; set; }
        //public long ZipCode { get; set; }
        //public long mobile { get; set; }
        //public string emailId { get; set; }

        public void showDetails()
        {

            if (pname != "")
            {
                Console.WriteLine("Name of the faculty :" + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender :" + gender);
            }
        }
        //public string getAddress()
        //{
        //    return $"Address is City :{City}, State : {State} , Pincode : {ZipCode}";
        //}
        //public void showContact()
        //{
        //    Console.WriteLine("Contact Number :" + mobile);
        //    Console.WriteLine("Email Id :" + emailId);
        //    }
    }
}
