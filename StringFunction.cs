using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StringFunction
    {
        String fullName = "Monkey D Luffy ";
        String Greetmsg = "King of the Pirates";
        String city = "Marineford";
        String city1 = "mArineFord";
    public void ShowStringFunction() {

            //Console.WriteLine("Original String :" +fullName);
            //Console.WriteLine("Original String :" + fullName.Trim());
            //Console.WriteLine("LowerCase :" + fullName.ToLower());
            //Console.WriteLine("UpperCase :" + fullName.ToUpper());
            //Console.WriteLine(fullName[1]);
            //Console.WriteLine("To Print Particular Charachter Substring :" + fullName.Substring(1,5));
            //Console.WriteLine("To Remove particular charachter :" + fullName.Remove(3,5));
            //Console.WriteLine("check whether the given name is starting with :"+fullName.StartsWith("Monkey"));
            //Console.WriteLine("check the name is ending with Monkey or not :"+fullName.EndsWith("Monkey"));
            //Console.WriteLine("check the name is contain or not"+fullName.Contains("D"));
            Console.WriteLine("check both values or equal :"+city.Equals(city1,StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(fullName.IndexOf(" "));
            //Console.WriteLine(fullName.LastIndexOf(" "));
            //Console.WriteLine(string.Format("Good Mprning {0}",fullName));
            //char[] chars = city.ToCharArray();
            //foreach(char c in chars) Console.WriteLine(c);
            //string[] nameArr = fullName.Split(" ");
            //foreach (string s in nameArr) Console.WriteLine(s);
            //Console.WriteLine(string.Join(" ", nameArr));
            Console.WriteLine("Replace :"+ fullName.Replace("Luffy","Garp",StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine("Enter the Input :");
            //String Input = Console.ReadLine();
            //string[] words = Input.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
                
            //        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                
            //}
            //Console.WriteLine( string.Join(" ", words));


            //Console.WriteLine("Enter City Name:");
            //string cityInput = Console.ReadLine();
            //string revcity = "";
            //for (int i = cityInput.Length - 1; i >= 0; i--)
            //{
            //   revcity += cityInput[i];
            //}
            //Console.WriteLine("After Reverse word :"+revcity); 
           
        }
       
    }
}
