using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            string dirС = @"C:\";
            string textDoc = @"E:\DirectoryC.txt";
            if (Directory.Exists(dirС))
            {
                Console.WriteLine($"Writing info about directory {dirС} in file {textDoc}...");
                try
                {
                    using (StreamWriter sw = new StreamWriter(textDoc, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Підкаталоги:");
                        string[] dirs = Directory.GetDirectories(dirС);

                        foreach (string s in dirs)
                            sw.WriteLine(s);

                        sw.WriteLine();
                        sw.WriteLine("Файли:");
                        string[] files = Directory.GetFiles(dirС);

                        foreach (string s in files)
                            sw.WriteLine(s);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Done.\n");
            }

            //Task 3
            string dirE = @"E:\";
            if (Directory.Exists(dirE))
            {
                Console.WriteLine($"Taking info from directory {dirE} and will display .txt files");
                string[] files = Directory.GetFiles(dirE);
                List<string> txtFilePath = new List<string>();
                foreach (string s in files)
                {
                    FileInfo file = new FileInfo(s);
                    if (file.Extension == ".txt")
                        txtFilePath.Add(s);
                }

                try
                {
                    foreach (string path in txtFilePath)
                    {
                        Console.WriteLine($"text from file {path}:");
                        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                        {
                            string text = sr.ReadToEnd();
                            Console.WriteLine(text);
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }

            //Homework
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string phoneNumbers = @"E:\phoneNumbers.txt";
            string phonePairs = @"E:\phones.txt";
            string newFile = @"E:\New.txt";
            try
            {
                using(StreamReader sr = new StreamReader(phonePairs, System.Text.Encoding.Default))
                {
                    string phone;
                    while((phone = sr.ReadLine()) != null)
                    {
                        string[] pair = phone.Split(':');
                        PhoneBook.Add(pair[0], pair[1]);
                    }
                }

                string choice = "";
                do
                {
                    Console.Write("Enter name to find in Phone Book: ");
                    string name = Console.ReadLine();
                    if (PhoneBook.ContainsValue(name))
                    {
                        foreach (var pair in PhoneBook)
                        {
                            if (pair.Value.ToLower().Trim() == name.ToLower().Trim())
                                Console.WriteLine($"{pair.Value}: {pair.Key}");
                        }
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Contact not found\n");

                    Console.WriteLine("Do you want to find another contact(y/n): ");
                    choice = Console.ReadLine();
                } while (choice == "y");
                Console.ReadLine();

                Console.WriteLine("Creating new file with formated numbers if needed");
                using (StreamReader sr = new StreamReader(phoneNumbers, System.Text.Encoding.Default))
                {
                    string phone;
                    while ((phone = sr.ReadLine()) != null)
                    {
                        using (StreamWriter sw = new StreamWriter(newFile, true, System.Text.Encoding.Default))
                        {
                            if (phone.StartsWith("80"))
                                sw.WriteLine(phone.Replace("80", "+380"));
                            else if (!phone.StartsWith("+380"))  
                                sw.WriteLine("+38" + phone);                            
                            else
                                sw.WriteLine(phone);
                        }
                    }
                }
                Console.WriteLine("Done.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}