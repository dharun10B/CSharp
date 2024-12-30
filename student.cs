using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student : IPerson,IAddress,IContact
    {
        public int rollno { get; set; }

       // public string sname { get; set; }

        public char gender { get; set; }
        
        public string pname {  get; set; }

        public static int id = 0;
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }
        public long mobile { get; set; }
        public string emailId { get; set; }
       
        public static int incrementId()
        {
            return ++id;
        }

        //public void displayDetails(int rollno = 0,string sname =" ",char gender=' ')
        //{
        //    if (rollno > 0)
        //    {
        //        Console.WriteLine("Roll No :"+rollno);
        //    }
        //    if (sname != "") {
        //    Console.WriteLine("Name of Student :" + sname);
        //    }
        //    if (gender != ' ')
        //    {
        //        Console.WriteLine("Gender :"+ gender);
        //    }
        //}

        public void showDetails()
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No :" + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of Student :" + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender :" + gender);
            }
        }
        public string getAddress()
        {
            return $"Address is City :{City}, State : {State} , Pincode : {ZipCode}";
        }
        public void showContact()
        {
            Console.WriteLine("Contact Number :"+ mobile);
            Console.WriteLine("Email Id :" + emailId);
        }
    }
}
