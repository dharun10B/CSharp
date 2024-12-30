using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class ArrayTask
    {
        public void showArraySearch()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            Console.WriteLine("Enter element to search:");
            int search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == search)
                {
                    count=1;
                    
                }
               
            }
            if(count ==1)
            {
                Console.WriteLine("element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }
        public void showArraySearch2()
        {
            int[] arr1 = { 1,2,3,4,5,6 };
            Console.WriteLine("Enter element to search :");
            int search = Convert.ToInt32(Console.ReadLine());
            int searched =Array.IndexOf(arr1, search);
            if(searched >= 0)
            {
                Console.WriteLine("Elemnt is present ");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }
        public void showArrayfruits()
        {
            string[] strings = { "Apple" ,"Orange","banana", "cherry" };
            Console.WriteLine("Enter the fruit name to search :");
            string search = Console.ReadLine();
            int searched = -1;

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    searched = i;
                    break;
                }
            }

            if (searched >= 0)
            {
                Console.WriteLine("Element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }
    }
}
