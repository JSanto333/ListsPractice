using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    //Console.WriteLine(number);
            //}
            ////Use the Count property to get the length of the list
            //Console.WriteLine(favNumbers.Count);
            //List<string> books = new List<string> { "Cat in the hat", "Toad and frog",
            //    "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            ////Inserts at the current index moving the previous element down one
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);
            //Create a List and add 5 animals using the .Add()
            //Print each animal in the list
            //List<string> animals = new List<string>();
            //animals.Add("Lion");
            //animals.Add("Tiger");
            //animals.Add("Elephant");
            //animals.Add("Monkey");
            //animals.Add("Giraffe");

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    Console.WriteLine(animals[i]);
            //}


            //Create the following list:
            //A bool list {true,false,false,true,false}
            //Loop through each value
            // if the value is true, print "Better bring an umbrella"
            // if the value is false, print "No rain today enjoy the sun"
            //List<bool> boolList = new List<bool> { true, false, false, true, false };

            //foreach(bool day in boolList)
            //{
            //    if(day == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun");
            //    }
            //} 

            List<string> faveFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "Nachos" };

            if(faveFoods.Contains("fish"))
            {
                Console.WriteLine("I like fish too!!!");
            }






        }
    }
}
