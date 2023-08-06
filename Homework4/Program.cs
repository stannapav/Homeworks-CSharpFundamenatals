namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task
            Car[] cars = new Car[4];
            cars[0] = new Car();
            for (int i = 1; i < cars.Length; i++)
                cars[i] = Car.Input(i);
            Console.WriteLine();

            Console.WriteLine("Decreasing price of cars to 10%");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(10);
                cars[i].Print();
            }
            Console.WriteLine();

            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if ((cars[i] == cars[j]))
                        Console.WriteLine($"{cars[i]} and {cars[j]} have same model and color");
                    else if (cars[i].Color == cars[j].Color)
                        Console.WriteLine($"{cars[i]} and {cars[j]} have same color");
                    else
                        Console.WriteLine("Cars aren't equals");
                }
            }
            Console.WriteLine();

            //Homework
            Person[] people = new Person[6];
            for(int i = 0; i < people.Length; i++)
                people[i] = Person.Input();
            Console.WriteLine();

            Console.WriteLine("All peoples age");
            foreach(Person person in people)
                Console.WriteLine($"{person.Name} is {person.Age()} years old");
            Console.WriteLine();

            Console.WriteLine("If your age is under 16 your name will change to \"Very Young\"");
            for (int i = 0; i < people.Length; i++)
            {                                            
                if (people[i].Age() < 16)                
                    people[i].ChangeName("Very Young");  
            }

            foreach (Person person in people)
                person.Output();
            Console.WriteLine();

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                    Console.WriteLine((people[i] == people[j]) ? $"{people[i]} and {people[j]} are same" : "People aren't same");
            }
        }
    }
}