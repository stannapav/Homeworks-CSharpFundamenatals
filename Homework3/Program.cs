namespace Homework3
{
    internal class Program
    {
        enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };

        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter first num: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (; a <= b; a++)
                Console.Write((a % 3 == 0) ? $"{a} can be divided by 3 without remainder\n" : "");
            Console.WriteLine();

            //Task 2
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();
            foreach (char letter in str)
                Console.WriteLine(letter);
            Console.WriteLine();

            //Task 3
            Console.Write("Enter name of drink(coffee, tea, juice, water): ");
            string drink = Console.ReadLine();
            Console.WriteLine((drink.Trim().ToLower() == "coffee") ? "5$ and enjoy your coffee" :
                (drink.Trim().ToLower() == "tea") ? "4$ and enjoy your tea" :
                (drink.Trim().ToLower() == "juice") ? "6$ and enjoy your juice" :
                (drink.Trim().ToLower() == "water") ? "3$ and enjoy your water" :
                $"Sorry we don't have {drink.Trim().ToLower()}");
            Console.WriteLine();

            //Task 4
            double number = 0.0;
            double sum = 0.0;
            int count = 0;
            do
            {
                Console.Write("Enter your number to sum: ");
                number = Convert.ToDouble(Console.ReadLine());
                sum += (number >= 0) ? number : 0;
                count++;
            } while (number >= 0);
            Console.WriteLine($"Avarage is {sum / (count - 1)}");
            Console.WriteLine();

            //Task 5
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((year % 4 == 0) || (year % 100 == 0) || (year % 400 == 0) ? $"{year} is a leap year" :
              $"{year} isn't a leap year");
            Console.WriteLine();

            //Task 6
            Console.Write("Enter your three digit number: ");
            int threeDigitNum = Convert.ToInt32(Console.ReadLine());
            int digit1 = threeDigitNum / 100;
            int digit2 = (threeDigitNum - digit1 * 100) / 10;
            int digit3 = threeDigitNum - (digit1 * 100 + digit2 * 10);
            Console.WriteLine($"Sum of digits {threeDigitNum} => {digit1} + {digit2} + {digit3} = {digit1 + digit2 + digit3}");
            Console.WriteLine();

            //Task 7
            Console.Write("Enter your number(you can write big numbers): ");
            int numToCheck = Convert.ToInt32(Console.ReadLine());
            int digits = 0;
            for (int i = 1; numToCheck / Math.Pow(10, i - 1) >= 1; i++)
                digits = i;

            int countOdd = 0;
            for (; digits > 0; digits--)
            {
                int oddOrNot = numToCheck / (int)Math.Pow(10, digits - 1);
                Console.WriteLine((oddOrNot % 2 != 0) ? $"{oddOrNot} is odd" : $"{oddOrNot} isn't odd");
                numToCheck -= oddOrNot * (int)Math.Pow(10, digits - 1);
                countOdd += (oddOrNot % 2 != 0) ? 1 : 0;
            }
            Console.WriteLine((countOdd == digits) ? $"All numbers are odd" : $"Some numbers are even");
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //Homework 1
            Console.Write("Enter your sentence: ");
            string sentence = Console.ReadLine();
            int[] vowels = new int[4] { 0, 0, 0, 0 };
            foreach (char letter in sentence.ToLower())
            {
                vowels[0] += (letter == 'a') ? 1 : 0;
                vowels[1] += (letter == 'o') ? 1 : 0;
                vowels[2] += (letter == 'i') ? 1 : 0;
                vowels[3] += (letter == 'e') ? 1 : 0;
            }
            Console.WriteLine($"There is {vowels[0]} letters 'a', {vowels[1]} letters 'o', {vowels[2]} letters 'i', " +
                $"{vowels[3]} letters 'e' in your sentence");
            Console.WriteLine();

            //Homework 2
            Console.Write("Enter number of month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int yearForMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{DateTime.DaysInMonth(yearForMonth, month)} day in {(Months)month} {yearForMonth}");
            Console.WriteLine();

            //Homework 3
            Console.WriteLine("Enter 10 numbers:");
            int[] numbers = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sumOf5 = 0;
            bool first5ContainsPositive = false;
            for (int i = 0; i < 5; i++)
            {
                first5ContainsPositive = (numbers[i] >= 0) ? true : false;
                if (!first5ContainsPositive)
                    break;
            }

            if (first5ContainsPositive)
            {
                for (int i = 0; i < 5; i++)
                    sumOf5 += numbers[i];
                Console.WriteLine($"Sum of your first 5 numbers {sumOf5}");
            }
            else
            {
                for (int i = 5; i < 10; i++)
                    sumOf5 += numbers[i];
                Console.WriteLine($"Sum of your last 5 numbers {sumOf5}");
            }          
        }
    }
}