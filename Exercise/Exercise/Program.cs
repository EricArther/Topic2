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

            Console.WriteLine("choose the task. enter the number.");
            string task = Console.ReadLine();

            switch (task)
            {
                case "1":
                    TaskOne();
                    break;

                case "2":
                    TaskTwo();
                    break;

                case "3":
                    TaskThree();
                    break;

                default:
                    Console.WriteLine("the task doesn't exist.");
                    break;
            }

            Console.ReadLine();

            
        }

        public static void TaskOne()
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
        }

        public static void TaskTwo()
        {
            Console.WriteLine("give me 2 numbers.");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("what do you want me to do with these? (+, -, * or /)");
            string operation = Console.ReadLine();
            int answer;
            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    Console.WriteLine(number1 + " + " + number2 + " = " + answer);
                    break;

                case "-":
                    answer = number1 - number2;
                    Console.WriteLine(number1 + " - " + number2 + " = " + answer);
                    break;

                case "*":
                    answer = number1 * number2;
                    Console.WriteLine(number1 + " * " + number2 + " = " + answer);
                    break;

                case "/":
                    answer = number1 / number2;
                    Console.WriteLine(number1 + " / " + number2 + " = " + answer);
                    break;

                default:
                    Console.WriteLine("the operation doesn't exist.");
                    break;
            }

            Console.WriteLine("your welcome.");
        }

        public static void TaskThree()
        {
            Console.Write("what is your first name? ");
            string first = Console.ReadLine();
            Console.Write("what is your last name? ");
            string last = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("you are " + first + " " + last + ".");
            Console.WriteLine("good to know.");
        }
    }
}
