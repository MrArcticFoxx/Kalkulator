using System;

 
 public class division : Icalculation
{
    public double Execute(double a, double b)
   
    if (b == 0)
       {
        Console.WriteLine("NIe można dzielić przez zero! Spróbuj jeszcze raz...");
        return double.NaN                                    /*Notka dla siebie 'not a number == NaN'*/
       }
       return a / b;
       
}