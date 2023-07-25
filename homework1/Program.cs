using System;

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

            Console.WriteLine($"Enter {size} characters");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1} : ");
                characters[i] = Convert.ToChar( Console.ReadLine() );
            }

            Console.Write("Your characters: ");
            foreach(char character in characters)
                Console.Write($"{character} ");

            Console.WriteLine();
            Console.WriteLine();

            //Task 4
            Console.Write("Enter first number = ");
            int firstNum = Convert.ToInt32( Console.ReadLine() ) ;
            Console.Write("Enter second number = ");
            int secondNum = Convert.ToInt32( Console.ReadLine() );

            if (firstNum > 0 && secondNum > 0)
                Console.WriteLine("Both numbers are positive");
            else
                Console.WriteLine("Both numbers aren't positive");

            Console.WriteLine();

            //Homework 1
            Console.Write("Enter the length of the sides of the square: ");
            int squareSide = Convert.ToInt32( Console.ReadLine()) ;

            Console.WriteLine($"Area of square: {squareSide} * {squareSide} = {squareSide * squareSide}");
            Console.WriteLine($"Perimeter of square: 4 * {squareSide} = {4 * squareSide}");
            Console.WriteLine();

            //Homework 2
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"What's your age, {name}?");
            int age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"{name} is {age} years old");
            Console.WriteLine();

            //Homework 3
            Console.Write("Enter radius of circle: ");
            double circleRadius = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine($"Length of circle: 2 * {Math.PI:F2} * {circleRadius} = {(2 * Math.PI * circleRadius):F2}");
            Console.WriteLine($"Area of circle: {Math.PI:F2} * {circleRadius} * {circleRadius} = {(Math.PI * circleRadius * circleRadius):F2}");
            Console.WriteLine($"Volume of circle: 4/3 * {Math.PI:F2} * {circleRadius}^3 = {( (4/3) * Math.PI * Math.Pow(circleRadius, 3) ):F2}");
        }
    }
}