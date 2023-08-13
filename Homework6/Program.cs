namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            task1:
            try
            {
                Console.WriteLine("write 2 int nums");
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto task1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto task1;
            }
            
            Console.WriteLine();

            //Homework
            homework:
            try
            {
                Console.WriteLine("Enter 2 int number with minimum range of 10 between them");
                Console.Write("Enter start: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter end: ");
                int end = Convert.ToInt32(Console.ReadLine());
                ReadNumber(start, end);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto homework;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto homework;
            }
            
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static void ReadNumber(int start, int end)
        {
            if (end < start) throw new ApplicationException("End must be > than start");
            if (end - start < start + 10) throw new ApplicationException("Range between start and end is less than 10");

            Stack<int> numsInRange = new Stack<int>();
            Console.WriteLine("You must enter number that is bigger then previous");
            int peek = start;
            int num = 0;

            readingNums:
            try
            {
                while (numsInRange.Count != 10)
                {
                    Console.Write($"Enter {numsInRange.Count + 1} num: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (numsInRange.Count == 0)
                    {
                        numsInRange.Push(num);
                        peek = num;
                    }
                    else if (numsInRange.Count < 10 && (peek == end || end - peek < 10 - numsInRange.Count))
                        throw new ApplicationException("You cannot write all 10 number with range that is left." +
                            "You'll start over again.");
                    else if (num < peek)
                        throw new ApplicationException("Number is smaller than previous");
                    else if (num > peek)
                    {
                        numsInRange.Push(num);
                        peek = num;
                    }
                }
            }
            catch (ApplicationException ex) when (numsInRange.Count < 10 && (peek == end || end - peek < 10 - numsInRange.Count)) 
            {
                throw new ApplicationException("You cannot write all 10 number with range that is left. You'll start over again.");
            }
            catch (ApplicationException ex) when (num < peek)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.WriteLine("____________\n");
                goto readingNums;
            }

            Console.WriteLine("All nums that you wrote: ");
            foreach (int elem in numsInRange)
                Console.Write($"{elem} ");
        }

    }
}