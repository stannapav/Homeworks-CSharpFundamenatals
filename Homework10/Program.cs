namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 1);
            Point b = new Point(1, 1);
            Point c = new Point(1, 0);
            Triangle test = new Triangle(a, b, c);

            test.Print();
        }
    }
}