using System;
using System.Collections.Generic;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework 2
            List<IDeveloper> developers = new List<IDeveloper>();

            string choice;
            do
            {
                Console.Write("Who do you want to recruit: Programmer(p) or Builder(b): ");
                choice = Console.ReadLine();

                if (choice.ToLower().Trim() == "p")
                    developers.Add(Programmer.Input());
                else if(choice.ToLower().Trim() == "b")
                    developers.Add(Builder.Input());
                else
                    Console.WriteLine("Wrong input");

                Console.Write("Do you want to recruit more people(y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice.ToLower().Trim() == "y");

            foreach (IDeveloper developer in developers)
                Console.WriteLine(developer);

            foreach (IDeveloper developer in developers)
            {
                Console.Write("Enter whatever you want this developer to create and then destroy: ");
                string something = Console.ReadLine();

                developer.Create(something);
                developer.Destroy(something);
                Console.WriteLine();
            }

            developers.Sort();
            Console.WriteLine("Sorting developers");
            foreach (IDeveloper developer in developers)
                Console.WriteLine(developer);
            Console.WriteLine();

            //Homework 2
            Dictionary<uint, string> peopleID = new Dictionary<uint, string>();
            int pairs = 7;

            Console.WriteLine("You'll enter people names and IDs");
            for (int i = 0; i < pairs; i++)
            {
                Console.Write($"Enter {i + 1} name: ");
                string name = Console.ReadLine();
                Console.Write($"Enter {i + 1} ID: ");
                uint ID = Convert.ToUInt32(Console.ReadLine());
                peopleID.Add(ID, name);
                Console.WriteLine();
            }

            Console.Write("Enter your ID: ");
            uint seek = Convert.ToUInt32(Console.ReadLine()); ;
            if (peopleID.ContainsKey(seek))
                Console.WriteLine($"Your name is {peopleID[seek]}");
            else
                Console.WriteLine("Sorry we coudn't find your ID and name");
        }
    }
}