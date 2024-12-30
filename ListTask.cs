using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace StudentApp
{
    internal class ListTask
    {
        UserInput ui = new UserInput();
        List<string> fruits = new List<string>() { "Apple", "orange", "Banana", "Grapes" };
        public void  showFruitsList() 
        {
            for (int i = 0; i < fruits.Count; i++)
            {

                fruits[i] = char.ToUpper(fruits[i][0]) + fruits[i].Substring(1).ToLower();
             }
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
        public int repeatfunction(string fruit)
        {
            int searched = -1;
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Equals(fruit, StringComparison.OrdinalIgnoreCase))
                {
                    searched = i;
                    break;
                }
            }
            return searched;
        }
        public void AddFruitsList()
        {
            //Console.WriteLine("Enter fruit to add :");
            string newfruit = ui.commonmethod("Enter fruit to add :");
            //int searched = -1;
            //for (int i = 0; i < fruits.Count; i++)
            //{
            //    if (fruits[i].Equals(newfruit, StringComparison.OrdinalIgnoreCase))
            //    {
            //        searched = i;
            //        break;
            //    }
            //}

            int searched=repeatfunction(newfruit);

            if (searched >= 0)
            {
                Console.WriteLine("Fruit is already present,Enter different fruit name :");
                AddFruitsList();
            }
            else
            {
                fruits.Add(newfruit);
                Console.WriteLine("Added successfully");
            }
        }
        public void updatefruitlist()
        {
            //Console.WriteLine("Enter old fruit to replace:");
            string oldfruit = ui.commonmethod("Enter old fruit to replace:");
            //int searched = -1;
            //for (int i = 0; i < fruits.Count; i++)
            //{
            //    if (fruits[i].Equals(oldfruit, StringComparison.OrdinalIgnoreCase))
            //    {
            //        searched = i;
            //        break;
            //    }
            //}
            int searched = repeatfunction(oldfruit);

            if (searched >= 0)
            {
                string up = fruits[searched];
                //Console.WriteLine("Enter new fruit to replace");
                string newfruit = ui.commonmethod("Enter new fruit to replace");

                int search=repeatfunction(newfruit);
                if (search >= 0)
                {
                    Console.WriteLine("Already present");
                    updatefruitlist();
                }
                else
                {
                    fruits[searched] = newfruit;
                    Console.WriteLine("Updated successfully");
                }
            }
            else
            {
                Console.WriteLine("Cannot able to find the fruit");
            }
        }
        public void Deletelist()
        {
            //Console.WriteLine("Enter fruit to delete :");
            string fruitToDelete = ui.commonmethod("Enter fruit to delete :");
            //int searched = -1;
            //for (int i = 0; i < fruits.Count; i++)
            //{
            //    if (fruits[i].Equals(fruitToDelete, StringComparison.OrdinalIgnoreCase))
            //    {
            //        searched = i;
            //        break;
            //    }
            //}
            int searched = repeatfunction(fruitToDelete);
            if (searched >= 0)
            {
                string dlt=fruits[searched];
                fruits.RemoveAt(searched);
                Console.WriteLine($"{dlt} deleted successfully.");
            }
            else
            {

                Console.WriteLine("Fruit not found in the list.");
            }
        }
        public void listmenubar()
        {
            Console.WriteLine("******************** MenuBar ********************");
            Console.WriteLine("1.Display Fruits");
            Console.WriteLine("2.Add Fruits");
            Console.WriteLine("3.update Fruits");
            Console.WriteLine("4.Delete Fruits");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter the option :");
            int option = Convert.ToInt32(Console.ReadLine());
            operation(option);
        }
        public void operation(int i)
        {
            switch (i)
            {
                case 1:
                    showFruitsList();
                    listmenubar();
                    break;
                case 2:
                    AddFruitsList();
                    listmenubar();
                    break;
                  case 3:
                    updatefruitlist();
                    listmenubar();
                    break;
                case 4:
                    Deletelist();
                    listmenubar();
                    break;
                case 5:
                    Console.WriteLine("Exiting....");
                    break;
                default:
                    listmenubar();
                    break;
            }

        }
    }
}
