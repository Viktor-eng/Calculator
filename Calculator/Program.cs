using System;
using CalculatorLibrary;

namespace UseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = CalculatorFactory.GetCalculator();

            Console.WriteLine($"Результат сложения всех чисел в массиве = {calculator.Addition(2, 3, 5)}");
            Console.WriteLine($"Результат вычитания всех чисел в массиве = {calculator.Subtraction(7, 8, 9)}");
            Console.WriteLine($"Результат умножения всех чисел в массиве = {calculator.Multiplication(10, 5, 2)}");
            Console.WriteLine($"Результат деления всех чисел в массиве = {calculator.Division(10, 2, 5)}");
        }
    }
}
