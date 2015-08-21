// https://msdn.microsoft.com/en-us/library/vstudio/7c5ka91b.aspx

public class BaseClass 
{
    // Only accessible within the same assembly
    internal static int x = 0;
}

// Assembly1.cs
// Compile with: /target:library
internal class BaseClass 
{
   public static int intM = 0;
}

// Assembly2.cs
// Compile with: /target:library
public class BaseClass 
{
   internal static int intM = 0;
}
