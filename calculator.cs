using System;

public class calculator
{
    public double Calculate(Icalculation operation, double a, double b)
         {
            return operation.Execute(a, b);
         }
     
}