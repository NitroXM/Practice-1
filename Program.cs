using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which task do you want to execute?");
            string choise = Console.ReadLine();
            switch (choise) {
                case "1":
                    task1();
                    break;
                    case "2":
                    task2();
                    break;
                case "3":
                    task3();
                    break;

            }
            void task1 ()
            {
                // Lambda operators for arithmetic operations
                Func<double, double, double> Add = (x, y) => x + y;
                Func<double, double, double> Sub = (x, y) => x - y;
                Func<double, double, double> Mul = (x, y) => x * y;
                Func<double, double, object> Div = (x, y) => y != 0 ? x / y : "Undefined";

                // Get user input
                Console.Write("Enter an arithmetic operation (+, -, *, /): ");
                string operation = Console.ReadLine();
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                // Perform arithmetic operation
                double result;
                if (operation == "+")
                    result = Add(num1, num2);
                else if (operation == "-")
                    result = Sub(num1, num2);
                else if (operation == "*")
                    result = Mul(num1, num2);
                else if (operation == "/")
                    result = (double)Div(num1, num2);
                else
                    throw new ArgumentException("Invalid operation.");

                // Print the result
                Console.WriteLine($"Result: {result}");
            }
            
            void task2 ()
            {
                Func<Func<int>[], double> average = delegate (Func<int>[] delegatesArray)
                {
                    int sum = 0;
                    foreach (Func<int> func in delegatesArray)
                    {
                        sum += func();
                    }
                    return (double)sum / delegatesArray.Length;
                };
            }

            void task3 ()
            {
                
                Func<int, int, int, double> average = delegate (int num1, int num2, int num3)
                {
                    return (double)(num1 + num2 + num3) / 3;
                };
               double x = average(4, 2, 21);
                Console.WriteLine(x);
            }
        }
    }
}