// https://msdn.microsoft.com/en-us/library/vstudio/e59b22c5.aspx

[DllImport("avifil32.dll")]
private static extern void AVIFileInit();

//using System.Runtime.InteropServices; 
class ExternTest
{
    [DllImport("User32.dll", CharSet=CharSet.Unicode)] 
    public static extern int MessageBox(IntPtr h, string m, string c, int type);

    static int Main()
    {
        string myString;
        Console.Write("Enter your message: ");
        myString = Console.ReadLine();
        return MessageBox((IntPtr)0, myString, "My Message Box", 0);
    }

}

// cm.cs
using System;
using System.Runtime.InteropServices;
public class MainClass 
{
   [DllImport("Cmdll.dll")]
   public static extern int SampleMethod(int x);

   static void Main() 
   {
      Console.WriteLine("SampleMethod() returns {0}.", SampleMethod(5));
   }
}
