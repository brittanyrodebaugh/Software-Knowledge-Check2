using KnowledgeCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Dog>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myDog = new Dog();

                Console.WriteLine("What's your Dog's name? ");
                myDog.Name = Console.ReadLine();

                Console.WriteLine($"What breed is {myDog.Name}?");
                myDog.Breed = Console.ReadLine();

                Console.WriteLine($"What color fur does {myDog.Name} have?");
                myDog.FurColor = Console.ReadLine();

                Console.WriteLine($"How old is {myDog.Name}?");
                myDog.Age = int.Parse(Console.ReadLine());


                recordList.Add(myDog);
            }

            // Print out the list of records using Console.WriteLine()
            foreach(var myDog in recordList)
            {
                Console.WriteLine("*************************");
                Console.WriteLine($" Name | {myDog.Name}");
                Console.WriteLine($"Breed | {myDog.Breed}");
                Console.WriteLine($"Color | {myDog.FurColor}");
                Console.WriteLine($"  Age | {myDog.Age}");
                Console.WriteLine("*************************");
            }
        }
    }
}