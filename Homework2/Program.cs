namespace Homework2
{
    internal class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }

        enum HTTPError { BadRequest = 400, Unauthorized, PaymentRequired, Forbidden, NotFound }

        struct RGB
        {
            public byte red, green, blue;

            public RGB(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }

            public override string ToString()
            {
                return $"{red}, {green}, {blue}";
            }
        }

        struct Dog
        {
            public string name;
            public int age;
            public string mark;

            public override string ToString()
            {
                return $"Name of your dog is {name} it's age is {age} and it's mark is {mark}";
            }
        }

        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num < 0) ? $"{num} cannot be a day or a month" :
                (num >= 1) && (num <= 12) ? $"{num} can be a day or a month" :
                (num <= 31) ? $"{num} can be a day" :
                $"{num} cannot be a day or a month");
            Console.WriteLine();

            //Task 2
            Console.Write("Enter number: ");
            double numWithDot = Convert.ToDouble(Console.ReadLine());
            int firstNum = (int)(numWithDot * 10) % 10;
            int secondNum = (int)(numWithDot * 100) % 10;
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            Console.WriteLine();

            //Task 3 
            Console.Write("What time is it? ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((hour >= 0 && hour < 6) || (hour == 24) ? "Why not sleeping? Well good night :)" :
                (hour >= 6) && (hour <= 12) ? "Good morning" :
                (hour >= 13) && (hour <= 16) ? "Good afternoon" :
                (hour >= 17) && (hour < 24) ? "Good evening" :
                $"What are you talking about {hour} cannot be an hour");
            Console.WriteLine();

            //Task 4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            Console.WriteLine();

            //Task 5
            RGB white = new RGB(0, 0, 0);
            Console.WriteLine("White " + white);
            RGB black = new RGB(255, 255, 255);
            Console.WriteLine("Black " + black);
            Console.WriteLine();

            //Homework 1
            int size = 3;
            float[] numbersWithDot = new float[3];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i + 1} number with point: ");
                numbersWithDot[i] = float.Parse(Console.ReadLine());
            }

            foreach (float numberWithDot in numbersWithDot)
                Console.WriteLine((numberWithDot >= -5) && (numberWithDot <= 5) ? $"{numberWithDot} is in range [-5;5]" :
                    $"{numberWithDot} isn't in range [-5;5]");
            Console.WriteLine();

            //Homework 2
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0], min = numbers[0];
            foreach (int number in numbers)
            {
                max = (number > max) ? number : max;
                min = (number < min) ? number : min;
            }
            Console.WriteLine($"Max = {max} Min = {min}");
            Console.WriteLine();

            //Homework 3
            Console.Write("Enter number of Error: ");
            HTTPError error = (HTTPError)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(error);
            Console.WriteLine();

            //Homework 4
            Dog myDog;
            Console.Write("Enter name of your dog: ");
            myDog.name = Console.ReadLine();
            Console.Write("Enter age of your dog: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter mark of your dog: ");
            myDog.mark = Console.ReadLine();
            Console.WriteLine(myDog);
            Console.WriteLine();
        }
    }
}