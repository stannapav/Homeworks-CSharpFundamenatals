using System.Reflection.PortableExecutable;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter a = ");
            int a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter b = ");
            int b = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            Console.WriteLine();

            //Task 2
            Console.Write("How are you? ");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
            Console.WriteLine();

            //Task 3
            int size = 3;
            char[] characters = new char[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Write character {i + 1}: ");
                characters[i] = Convert.ToChar( Console.ReadLine() );
            }

            Console.Write("Your charecters are: ");
            foreach (char charecter in characters)
                Console.Write($"{charecter} ");
            Console.WriteLine();
            Console.WriteLine();

            //Task 4
            Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32( Console.ReadLine() );

            if (firstNum > 0 && secondNum > 0)
                Console.WriteLine("Both numbers are positive");
            else
                Console.WriteLine("Both numbers aren't positive");
            Console.WriteLine();

            //Homework 1
            Console.Write("Enter lenght of square side: ");
            int squareSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Area of square {squareSide * squareSide}");
            Console.WriteLine($"Perimeter of square {4 * squareSide}");
            Console.WriteLine();

            //Homework 2 
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.Write($"What's your age, {name}? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} is {age} years old");
            Console.WriteLine();

            //Homework 3
            Console.Write("Enter radius of circle: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Length of circle: 2 * {Math.PI:F2} * {r} = {(2 * Math.PI * r):F2}");
            Console.WriteLine($"Area of circle: {Math.PI:F2} * {r} * {r} = {(Math.PI * r * r):F2}");
            Console.WriteLine($"Volume of circle: 4/3 * {Math.PI:F2} * {r} ^ 3 = {( (4/3) * Math.PI * Math.Pow(r, 3) ):F2}");
        }
    }
}