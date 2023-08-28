using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Homework9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFile = @"E:\text.txt";
            List<string> text = new List<string>();

            try
            {
                using(StreamReader sr  = new StreamReader(textFile, System.Text.Encoding.Default))
                {
                    string line;
                    while( (line =  sr.ReadLine()) != null) 
                        text.Add(line);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Counting all symbols in line:");
            Regex allSymbols = new Regex(@"[\S]*");
            List<int> countLine = new List<int>();

            for (int i = 0; i < text.Count; i++)
            {
                MatchCollection mathc = allSymbols.Matches(text[i]);
                int count = 0;
                foreach (var m in mathc)
                    count += m.ToString().Count();

                Console.WriteLine($"{i + 1} line count: {count}");
                countLine.Add(count);
            }
            Console.WriteLine();

            int max = countLine.Max();
            int indexMax = countLine.IndexOf(max);
            Console.WriteLine($"Max line is {indexMax + 1} line and have {max} symbols");

            int min = countLine.Min();
            int indexMin = countLine.IndexOf(min);
            Console.WriteLine($"Max line is {indexMin + 1} line and have {min} symbols\n");

            Console.WriteLine("All lines that have 'var':");
            Regex varMask = new Regex("var");
            foreach(string line in text)
            {
                if (varMask.IsMatch(line))
                    Console.WriteLine(line);
            }
        }
    }
}