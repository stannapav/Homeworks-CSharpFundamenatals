namespace Homewokr9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int numOfShapes = 6;

            Console.WriteLine($"You are going to make {numOfShapes} different shapes that you choose");
            makingShapes:
            try
            {
                for (int i = 0; i < numOfShapes; i++)
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
            catch (FormatException)
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto makingShapes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto makingShapes;
            }

            Console.WriteLine("Your list of shapes:");
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
            Console.WriteLine();


            string shapesFile = @"E:\shapes.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(shapesFile, false, System.Text.Encoding.Default))
                {
                    IEnumerable<Shape> shapesInRange = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
                    foreach (Shape shape in shapesInRange)
                        sw.WriteLine(shape);

                    IEnumerable<Shape> shapesWithLetterA = shapes.Where(shape => shape.Name.Contains('a'));
                    foreach (Shape shape in shapesWithLetterA)
                        sw.WriteLine(shape);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Wrote all shapes that meet requirement in file {shapesFile}\n");

            shapes = shapes.Except(shapes.Where(shape => shape.Perimetr() < 5)).ToList();

            Console.WriteLine("Your list of shapes after removal shapes that have perimetr that less than 5:");
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
        }
    }
}