using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Person
    {
        string name;
        DateTime birthday;

        public string Name { get { return name; } }
        public string Birthday { get {  return birthday.ToString("d"); } }

        public Person()
        {
            this.name = "Tom";
            this.birthday = new DateTime(1973, 4, 29);
        }

        public Person(string name, int year, int month, int day)
        {
            this.name = name;
            this.birthday = new DateTime(year, month, day);
        }

        public int Age()
        {      
            return (DateTime.Now.Month > this.birthday.Month) || 
                (DateTime.Now.Month == this.birthday.Month && DateTime.Now.Day >= this.birthday.Day) ? DateTime.Now.Year - this.birthday.Year :
                DateTime.Now.Year - this.birthday.Year - 1;
        }

        public static Person Input()
        {
            Console.Write("Enter persons name: ");
            string name = Console.ReadLine();
            Console.Write("Enter persons year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter persons month of birth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter persons day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Person temp = new Person(name, year, month, day);
            return temp;
        }

        public void Output()
        {
            Console.WriteLine($"{this.name} is {Age()} years old and their birthday is {this.birthday.ToString("d")}");
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name} is {Age()} years old and their birthday is {this.birthday.ToString("d")}";
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
    }
}