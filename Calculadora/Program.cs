namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new();
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
                                $"{firstNumber} + {secondNumber} = {calc.Add(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Subtract:
                            Console.WriteLine(
                                $"{firstNumber} - {secondNumber} = {calc.Sub(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Multiply:
                            Console.WriteLine(
                                $"{firstNumber} * {secondNumber} = {calc.Multiply(firstNumber, secondNumber)}");
                            break;
                        case ConsoleKey.Divide:
                            Console.WriteLine(
                                $"{firstNumber} / {secondNumber} = {calc.Divide(firstNumber, secondNumber)}");
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
            } while (response.Key == ConsoleKey.S);
        }
    }
}
