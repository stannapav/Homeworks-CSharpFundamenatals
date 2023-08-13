namespace Hw5_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            List<IFlyable> flyables = new List<IFlyable>();

            string choice;
            do
            {
                Console.Write("Who do you want to add Bird(b) or Plane(p): ");
                choice = Console.ReadLine();

                if (choice.ToLower().Trim() == "b")
                    flyables.Add(Bird.Input());
                else if (choice.ToLower().Trim() == "p")
                    flyables.Add(Plane.Input());
                else
                    Console.WriteLine("Wrong input");

                Console.Write("Do you want to and more items(y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice.ToLower().Trim() == "y");

            Console.WriteLine("List of all things you added:");
            foreach (IFlyable flyable in flyables)
                flyable.Fly();

            Console.WriteLine();
            //Task 2
            List<int> myColl = new List<int>();
            int collElems = 10;

            for(int i = 0; i < collElems; i++)
            {
                Console.Write($"Enter {i + 1} num to collection: ");
                myColl.Add( Convert.ToInt32(Console.ReadLine()) );
            }
            Console.WriteLine();

            Console.WriteLine("Print all positions of element \"-10\" in this collection");
            for (int i = 0; i < myColl.Count; i++)
                Console.Write((myColl[i] == -10) ? $"index of \"-10\" is {i}\n" : "");
            Console.Write("\n\n");

            Console.WriteLine("Removing from collection elements, which are greater then 20 and print new collection");
            myColl.RemoveAll(greaterThan20);
            foreach (int elem in myColl)
                Console.Write($"{elem} ");
            Console.Write("\n\n");

            Console.WriteLine("Inserting elements 1,-3,-4 in positions 2, 8, 5. Print new collection");
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            foreach (int elem in myColl)
                Console.Write($"{elem} ");
            Console.Write("\n\n");

            Console.WriteLine("Sort collection");
            myColl.Sort();
            foreach (int elem in myColl)
                Console.Write($"{elem} ");
        }

        public static bool greaterThan20(int item)
        {
            return (item > 20) ? true : false;
        }
    }
}