// https://msdn.microsoft.com/en-us/library/vstudio/6b0scde8.aspx

namespace PM
{
    partial class A
    {
        partial void OnSomethingHappened(string s);
    }

    // This part can be in a separate file. 
    partial class A
    {
        // Comment out this method and the program 
        // will still compile. 
        partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
