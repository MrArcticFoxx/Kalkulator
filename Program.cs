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
   }
}