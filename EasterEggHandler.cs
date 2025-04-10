using System;

public static class EasterEggHandler
{
  
    public static bool CheckForEasterEgg(double a, double b, string op, double result, out string message)
    {
        message = "";


        if (a == 69 && b == 420)
        {
            message = "Nice ;)";
            return true;
        }

       
        if (a == 3.14 || b == 3.14)
        {
            message = "Czy toPI smutki w kieliszku wódki?";
            return true;
        }

       
        if (result == 2137)
        {
            Console.WriteLine("PAN JEZUS JUŻ SIĘ ZBLIŻA...");
            LinkHelper.OpenURL("https://www.youtube.com/watch?v=fimrULqiExA");
            return true;
        }

        return false;  
    }
}