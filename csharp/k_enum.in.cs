// https://msdn.microsoft.com/en-us/library/vstudio/sbbt4032.aspx

enum Days {Sat, Sun, Mon, Tue, Wed, Thu, Fri};

enum Days {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};

enum Days : byte {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};

public class EnumTest
{
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        int x = (int)Days.Sun;
        int y = (int)Days.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
/* Output:
   Sun = 0
   Fri = 5
*/

public class EnumTest2
{
    enum Range : long { Max = 2147483648L, Min = 255L };
    static void Main()
    {
        long x = (long)Range.Max;
        long y = (long)Range.Min;
        Console.WriteLine("Max = {0}", x);
        Console.WriteLine("Min = {0}", y);
    }
}
/* Output:
   Max = 2147483648
   Min = 255
*/

// Add the attribute Flags or FlagsAttribute.
[Flags]
public enum CarOptions
{
    // The flag for SunRoof is 0001.
    SunRoof = 0x01,
    // The flag for Spoiler is 0010.
    Spoiler = 0x02,
    // The flag for FogLights is 0100.
    FogLights = 0x04,
    // The flag for TintedWindows is 1000.
    TintedWindows = 0x08,
}

class FlagTest
{
    static void Main()
    {
        // The bitwise OR of 0001 and 0100 is 0101.
        CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;

        // Because the Flags attribute is specified, Console.WriteLine displays 
        // the name of each enum element that corresponds to a flag that has 
        // the value 1 in variable options.
        Console.WriteLine(options);
        // The integer value of 0101 is 5.
        Console.WriteLine((int)options);
    }
}
/* Output:
   SunRoof, FogLights
   5
*/
