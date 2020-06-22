using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input B:");
            int b = int.Parse(Console.ReadLine());

            Addition(a, b);

            Subtraction(a, b);

            Multiplication(a, b);

            Division(a, b);



        }
        public static void Addition(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"{a}+{b} is {result}");
        }
        public static void Subtraction(int a, int b)
        {
            var result = a - b;
            Console.WriteLine($"{a}-{b} is {result}");
        }
        public static void Multiplication(int a, int b)
        {
            var result = a * b;
            Console.WriteLine($"{a}*{b} is {result}");
        }
        public static void Division(int a, int b)
        {
            var result = a / b;
            var quotient = a % b;

            Console.WriteLine($"{a}/{b} is {result} remainder {quotient}");
        }
    }
}
