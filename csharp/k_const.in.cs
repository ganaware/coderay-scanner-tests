// https://msdn.microsoft.com/en-us/library/vstudio/e6w8fe1b.aspx

const int x = 0;
public const double gravitationalConstant = 6.673e-11;
private const string productName = "Visual C#";

public const double x = 1.0, y = 2.0, z = 3.0;

public const int c1 = 5;
public const int c2 = c1 + 100;

public class ConstTest 
{
    class SampleClass 
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2) 
        {
            x = p1; 
            y = p2;
        }
    }

    static void Main() 
    {
        SampleClass mC = new SampleClass(11, 22);   
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.WriteLine("c1 = {0}, c2 = {1}", 
                          SampleClass.c1, SampleClass.c2 );
    }
}
/* Output
    x = 11, y = 22
    c1 = 5, c2 = 10
 */

public class SealedTest
{
    static void Main()
    {
        const int c = 707;
        Console.WriteLine("My local constant = {0}", c);
    }
}
// Output: My local constant = 707
