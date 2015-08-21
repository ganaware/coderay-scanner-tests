// https://msdn.microsoft.com/en-us/library/vstudio/xhbhezf4.aspx

// Must be defined inside a class called Fahrenheit: 
public static explicit operator Celsius(Fahrenheit fahr)
{
    return new Celsius((5.0f / 9.0f) * (fahr.degrees - 32));
}

class Celsius
{
    public Celsius(float temp)
    {
        degrees = temp;
    }
    public static explicit operator Fahrenheit(Celsius c)
    {
        return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
    }
    public float Degrees
    {
        get { return degrees; }
    }
    private float degrees;
}

class Fahrenheit
{
    public Fahrenheit(float temp)
    {
        degrees = temp;
    }
    // Must be defined inside a class called Fahrenheit: 
    public static explicit operator Celsius(Fahrenheit fahr)
    {
        return new Celsius((5.0f / 9.0f) * (fahr.degrees - 32));
    }
    public float Degrees
    {
        get { return degrees; }
    }
    private float degrees;
}

class MainClass
{
    static void Main()
    {
        Fahrenheit fahr = new Fahrenheit(100.0f);
        Console.Write("{0} Fahrenheit", fahr.Degrees);
        Celsius c = (Celsius)fahr;

        Console.Write(" = {0} Celsius", c.Degrees);
        Fahrenheit fahr2 = (Fahrenheit)c;
        Console.WriteLine(" = {0} Fahrenheit", fahr2.Degrees);
    }
}
// Output: 
// 100 Fahrenheit = 37.77778 Celsius = 100 Fahrenheit

struct Digit
{
    byte value;
    public Digit(byte value)
    {
        if (value > 9)
        {
            throw new ArgumentException();
        }
        this.value = value;
    }

    // Define explicit byte-to-Digit conversion operator: 
    public static explicit operator Digit(byte b)
    {
        Digit d = new Digit(b);
        Console.WriteLine("conversion occurred");
        return d;
    }
}

class ExplicitTest
{
    static void Main()
    {
        try
        {
            byte b = 3;
            Digit d = (Digit)b; // explicit conversion
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
    }
}
/*
Output:
conversion occurred
*/
