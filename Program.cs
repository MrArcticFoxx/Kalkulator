using System;

namespace KalkulatorApp 
{
    class Program
    {
        static void Main()
        {
        
            Console.WriteLine("Podaj pierwszą liczbę:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę:");
            double b = double.Parse(Console.ReadLine());

            Icalculation calculation = null;

            switch (op)
            {
                case "+":
                    calculation = new Addition();
                    break;
                case "-":
                    calculation = new Substraction();
                    break;
                case "*":
                    calculation = new Multiplication();
                    break;
                case "/":
                    calculation = new Division();
                    break;
                default:
                    Console.WriteLine("Nieobsługiwany operator.");
                    return;
            }

            try
            {
                double result = calculation.Execute(a, b);
                Console.WriteLine($"Wynik: {result}");


                string message;
                bool isEasterEgg = EasterEggHandler.CheckForEasterEgg(a, b, op, result, out message);

              
                if (isEasterEgg)
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}
