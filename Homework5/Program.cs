using System;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            foreach (IDeveloper developer in developers)
                Console.WriteLine(developer);
        }
    }
}