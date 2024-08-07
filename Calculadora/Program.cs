﻿namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo response;

            do
            {
                Console.Write("Primeiro numero: ");
                double.TryParse(Console.ReadLine(), out double firstNumber);

                Console.Write("Segundo numero: ");
                double.TryParse(Console.ReadLine(), out double secondNumber);

                Console.Write("Operação: ");
                response = Console.ReadKey();
                Console.WriteLine();
                try
                {
                    switch (response.Key)
                    {
                        case ConsoleKey.Add:
                            Console.WriteLine(
                                $"{firstNumber} + {secondNumber} = {Calculator.Add(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Subtract:
                            Console.WriteLine(
                                $"{firstNumber} - {secondNumber} = {Calculator.Sub(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Multiply:
                            Console.WriteLine(
                                $"{firstNumber} * {secondNumber} = {Calculator.Multiply(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Divide:
                            Console.WriteLine(
                                $"{firstNumber} / {secondNumber} = {Calculator.Divide(firstNumber, secondNumber)}");
                            break;
                        default:
                            Console.WriteLine("Operação não disponível");
                            break;
                    }
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch(ArithmeticException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                
                Console.Write("Repetir (S/N)? ");
                response = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
            } while (response.Key == ConsoleKey.S);
        }
    }
}
