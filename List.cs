using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class List
    {
        public void showList() 
        {
        List <int> numbers = new List <int>() { 40,50,10,30,20 };
            List<int> newnumbers = new List<int>() { 80, 60, 100 };
            numbers.Add (70);
            //numbers.Insert(2, 90);
            numbers.InsertRange(3, newnumbers);
            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Remove(100);
            numbers.RemoveAt(2);
            for (int i = 0; i < numbers.Count; i++)
            {
                 Console.WriteLine(numbers[i]); 
            }
        }
    }
}
