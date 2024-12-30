using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Arayfunction
    {
        public void Arrayfunction()
        {
            int[] numbers = { 21, 10, 5, 233, 500 };

            int[] newnumbers =new int[5];
            numbers.CopyTo(newnumbers, 0);
            
            Array.Resize(ref newnumbers,7);
            newnumbers[5] = 9;
            newnumbers[6] = 69;

            Array.Clear(newnumbers,3,2);
            Console.WriteLine("find the index value of 500 :"+Array.IndexOf( numbers,500));
            Console.WriteLine("find the index value of 5:"+Array.BinarySearch( numbers,5));

            //Array.Sort( numbers );
            //Array.Reverse( numbers );
            Console.WriteLine("-------------------------------------------------------------");
            foreach( int i in newnumbers)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
