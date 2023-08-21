using System.Collections;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int numOdShapes = 3;

            Console.WriteLine($"You are going to make {numOdShapes} different shapes that you choose");
            makingShapes:
            try
            {
                for (int i = 0; i < numOdShapes; i++)
                {
                    string choice;
                    Console.Write($"What {i + 1} shape you want to create? Circle(c), Square(s), Triangle(t): ");
                    choice = Console.ReadLine();

                    if (choice.Trim().ToLower() == "c" || choice.Trim().ToLower() == "circle")
                        shapes.Add(Circle.Input());
                    else if (choice.Trim().ToLower() == "s" || choice.Trim().ToLower() == "square")
                        shapes.Add(Square.Input());
                    else if (choice.Trim().ToLower() == "t" || choice.Trim().ToLower() == "triangle")
                        shapes.Add(Triangle.Input());
                    else
                    {
                        Console.WriteLine("Wrong input");
                        i--;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto makingShapes;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto makingShapes;
            }
            Console.WriteLine();

            Console.WriteLine("Your list of shapes:");
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
            Console.WriteLine();

            Console.Write("The biggest perimetr is: ");
            double maxArea = shapes[0].Area();
            int index = 0;
            for(int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Area() > maxArea)
                {
                    maxArea = shapes[i].Area();
                    index = i;
                }                   
            }
            Console.WriteLine(maxArea + " from " + shapes[index] + "\n");

            Console.WriteLine("Sorting your shapes by area...");
            shapes.Sort();
            Console.WriteLine("Done\n");

            Console.WriteLine("Your sorted list of shapes:");
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
        }
    }
}