using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class fruitstask
    {
        public void displayfruits()
        {
            string[] strings = { "Apple", "Orange", "banana", "cherry" };
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
        public void fruits()
        {
            string[] strings = { "Apple", "Orange", "banana", "cherry" };
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
        public void menubar()
        {
            Console.WriteLine("MenuBar");
            Console.WriteLine("1.Display Fruits");
            Console.WriteLine("2.Find Fruits");
            Console.WriteLine("3.close");
            Console.WriteLine("Enter the option :");
            int option =Convert.ToInt32( Console.ReadLine());
            operation(option);
        }
        public void operation(int i)
        {
            switch (i)
            {
                case 1:
                    displayfruits();
                    menubar();
                    break;
                case 2:
                    fruits();
                    menubar();
                    break;
                case 3:
                    break;
                default:
                    menubar();
                    break;
            }

        }
    }
}
