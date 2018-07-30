using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name? ");
            string name = Console.ReadLine();
            Console.Write("what is your age? ");
            string age = Console.ReadLine();
            Console.Write("what is your gender? ");
            string gender = Console.ReadLine();
            Console.Write("what is your address? ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("hello " + name + ".");
            Console.WriteLine("your age is " + age + ".");
            Console.WriteLine("your gender is " + gender + ".");
            Console.WriteLine("your address is " + address + ".");
            Console.WriteLine("I'll be watching you. hahahaha.");

            Console.ReadLine();

            Console.WriteLine("give me 2 numbers.");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int add = number1 + number2;
            int sub = number1 - number2;
            int mul = number1 * number2;
            int div = number1 / number2;
            Console.WriteLine();
            Console.WriteLine(number1 + " + " + number2 + " = " + add);
            Console.WriteLine(number1 + " - " + number2 + " = " + sub);
            Console.WriteLine(number1 + " * " + number2 + " = " + mul);
            Console.WriteLine(number1 + " / " + number2 + " = " + div);
            Console.WriteLine("your welcome.");

            Console.ReadLine();

            Console.Write("what is your first name? ");
            string first = Console.ReadLine();
            Console.Write("what is your last name? ");
            string last = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("you are " + first + " " + last + ".");
            Console.WriteLine("good to know.");

            Console.ReadLine();
        }
    }
}
