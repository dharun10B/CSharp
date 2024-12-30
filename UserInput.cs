using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class UserInput
    {
        public string commonmethod(string msg)
        {
            Console.WriteLine(msg);
            string val = Console.ReadLine();
            return val;
        }
        
    }
}
