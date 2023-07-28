using System.Xml.Linq;

namespace Hw2_AdidtionalTask
{
    internal class Program
    {
        struct Student
        {
            public string lastName;
            public string groupName;

            public override string ToString()
            {
                return $"Students last name is {lastName} from group \"{groupName.Trim().ToLower()}\"";
            }
        }

        static void Main(string[] args)
        {
            //Cat
            Cat myCat = new Cat("Diana", 12);

            bool fullOrNot = false;
            do
            {
                Console.WriteLine("Feed your cat.");
                Console.WriteLine("1: Fish");
                Console.WriteLine("2: Mouse");
                Console.WriteLine("3: Meat");
                Console.WriteLine("4: Bird");
                Console.WriteLine("5: Feed");
                Console.Write("Choose what you will give it: ");

                int? readReasult = Convert.ToInt32(Console.ReadLine());
                Food choice = (readReasult != null) ? (Food)readReasult : (Food)0;
                Console.WriteLine();

                myCat.EatSomething(choice);
                fullOrNot = myCat.checkFullness();
                Console.WriteLine();
            } while (!fullOrNot);

            //Student
            int sizeOfArray = 3;
            Student[] students = new Student[sizeOfArray];

            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.Write($"Enter {i + 1} student last name: ");
                students[i].lastName = Console.ReadLine();
                Console.Write("and group name: ");
                students[i].groupName = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Write("Enter group name: ");
            string groupName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"List of student in group \"{groupName.Trim().ToLower()}\"");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write( (groupName.Trim().ToLower() == students[i].groupName.Trim().ToLower() ) ? $"{i + 1}: " + students[i] + "\n" : "");
            }
        }
    }
}