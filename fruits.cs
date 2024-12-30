using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class fruits
    {
        public void ShowStringReplace()
        {
            int count = 0;
            string[] fruits = { "Banana", "Apple", "Orange", "Grapes" };
            Console.WriteLine("enter the fruit to replace");
            string change = Console.ReadLine();
            Console.WriteLine("Enter the fruit to add ");
            string changenew = Console.ReadLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Equals(change, StringComparison.OrdinalIgnoreCase))
                {
                    fruits[i] = fruits[i].Replace(change, changenew, StringComparison.OrdinalIgnoreCase);
                    break;
                }
                else
                {
                    count++;

                }
            }
            if (count == 4)
            {
                Console.WriteLine($"The Enter Value {change} is not avalaible");

            }
            else
            {
                Console.WriteLine("Array After Replace :");
                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine(fruits[i]);
                }
            }

        }
        public void Stringcount()
        {
            string input = "She sells sea shells by the sea shore";
            int count = 1;
            char letter = 'S';
            int lcount = 0;
            char[] ch = input.ToCharArray();
            foreach (char c in ch)
            {
                if (c == ' ')
                {
                    count += 1;
                }

                if (letter == c)
                {
                    lcount++;
                }
            }
            Console.WriteLine("The count of words: " + count);
            Console.WriteLine("The count of letter: " + lcount);
        }
    }
}
