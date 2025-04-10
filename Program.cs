using System;

class Program
{
    Console.WriteLine("Podaj pierwszą liczbę: ");
    double a = double.Prase(Console.ReadLine());

    Console.WriteLine("Podaj operator (+, -, *, /): ");
    string op = (Console.ReadLine());

    Console.WriteLine("Podaj drugą liczbę: ");
    double b = double.Prase(Console.ReadLine());
 
   Icalculation calculation = null;   

   switch (op)
   {
    case "+":
           calculation = new addition();
           break;
    case "-":
           calculation = new substraction();
           break;
    case "*":
           calculation = new multiplication();
           break;
    case "/":
            calculation = new division();
            break;
    default:
            Console.WriteLine("Nieobsługiwany operator.");
            return;
   }

   try
  {

    double result = calculation.Execute(a, b);
    Console.WriteLine($"Wynik: {result}");
      

    if(EasterEggHandler.check(a, b, op, result, out string eggMessage)) 
    {
        Console.WriteLine(eggMessage);
        if(string.IsNullOrEmpty(url))
        {
            LinkHelper.OpenURL(url)
        }
    }  
 }
    catch (DivideByZeroExeption ex)
    {
      Console.WriteLine($"Błąd: {ex.Message}");

    }
    catch (Execption ex)
    {
        Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
    }
}