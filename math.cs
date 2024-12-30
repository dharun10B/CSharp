using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class math
    {
       
        public void mathematicFunction()
        {
            //Console.WriteLine("Enter x value :");
            //int x=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter y value :");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter z value :");
            //double z = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter v value :");
            //double v = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter num value :");
            //int num = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Minimum of  x and y is :" +Math.Min(x,y));
            //Console.WriteLine("Maximum of x and y is :" +Math.Max(x,y));
            //Console.WriteLine("round of lower value of z:" +Math.Floor(z));
            //Console.WriteLine("Round of higher value of v :" +Math.Ceiling(v));
            //Console.WriteLine("Power of x^2 : " +Math.Pow(x,2));
            //Console.WriteLine("Square root of x : " +Math.Sqrt(x));
            //Console.WriteLine("Give only positive values of num :" +Math.Abs(num));
            //Console.WriteLine("Gives round of values of v :" +Math.Round(v));

            //Console.WriteLine("Enter the Array Size :");
            //int size = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Array Values :");
            //int[] numarr = new int[size];
            //for (int i = 0; i < numarr.Length; i++)
            //{
            //    numarr[i]= Convert.ToInt32(Console.ReadLine()); 
            //}
            //Array.Sort(numarr);
            //Console.WriteLine("Minimum value :" +numarr[0]);
            //Console.WriteLine("Maximum value :"+ numarr[numarr.Length-1]);

            int[] number = { 4, 2, 9, 6, 10 };
            Array.Sort(number);
            Console.WriteLine("Minimum :"+number[0]);
            Console.WriteLine("Maximum :" + number[number.Length - 1]);
            Console.WriteLine("---------------------------------------------------------------------------");
           
            int[] numbers = { 10, 25, 5, 34, 67, 23, 88, 2 };
            int maxValue = numbers[0];
            int minValue = numbers[0];
            for (int i=1;i<number.Length-1;i++) 
            {
                maxValue = Math.Max(maxValue, numbers[i]);
                minValue = Math.Min(minValue, numbers[i]);
            }
            Console.WriteLine("Max: " + maxValue);
            Console.WriteLine("Min: " + minValue);

        }
    }
}
