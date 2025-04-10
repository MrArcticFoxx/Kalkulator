using System;

 
 public class Division : Icalculation
{
    public double Execute(double a, double b) {

        if (b == 0)
        {
            throw new DivideByZeroException("Nie można dzielić przez zero!");
     
        }

        return a / b;
    }
   
       
}