using System;

namespace _3sezon1tema
{
    public class Program
    {
        static void Main()
        {
            Division division = new Division();
            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();

            Console.WriteLine(($"Division: first number={5}, second number={6}, result={division.Operate(5, 6)}"));
            Console.WriteLine($"Addition: first number={5}, second number={6}, result={addition.Operate(5, 6)}");
            Console.WriteLine($"Addition: first number={5}, second number={6}, result={substraction.Operate(5, 6)}");
            Console.WriteLine($"Addition: first number={5}, second number={6}, result={multiplication.Operate(5, 6)}");

            /*Console.WriteLine($"Division: first number={number1}, second number={number2}, result={result}");*/

        }
    }
}
