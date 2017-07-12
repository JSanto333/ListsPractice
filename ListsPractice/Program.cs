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

            //List<string> faveFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "Nachos" };

            //if(faveFoods.Contains("fish"))
            //{
            //    Console.WriteLine("I like fish too!!!" );
            //}

            //create a list with the following numbers: 1, 23, 9, 77, 922, 6, 32, 63, 14, 5
            //use the contains method with the following values: 23, 77, 15
            //Remove these elements: 23, 77, 32, and 6
            // use Contains() again on these values: 23, 77, 15
            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));


            //Ask the user for a movie

            //if the movie is not in the list, add it
            //inform the user that the movie has been added
            //if the user enters quit, the program should exit
            //the user should be able to add as many movies as they want

            List<string> movies = new List<string> { "Step Brothers", "The Avengers", "Scarface", "Jaws", "Friday" };
            Console.WriteLine("Hey, which movie would you like?");
            string userInput = Console.ReadLine();
            movies.Add(userInput);
            foreach(string movieChoices in movies)
            {
                Console.WriteLine();
            }
            Console.WriteLine("I would like to have The Avengers");


        }
    }
}
