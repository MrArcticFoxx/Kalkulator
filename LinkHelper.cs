using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

public static class LinkHelper
{
    public static void OpenURL(string url)
     {
         try
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-Open", url);
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url)
            }
            
        }
        catch (Execption ex)
        {
            Console.WriteLine($"Nie udało się otworzyć linku: {ex.MEssage}");
        }
    }

}
