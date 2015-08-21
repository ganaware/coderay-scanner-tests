// https://msdn.microsoft.com/en-us/library/vstudio/bcd5672a.aspx

class A
{
    protected int x = 123;
}

class B : A
{
    static void Main()
    {
        A a = new A();
        B b = new B();

        // Error CS1540, because x can only be accessed by 
        // classes derived from A. 
        // a.x = 10;  

        // OK, because this class derives from A.
        b.x = 10;
    }
}

class Point 
{
    protected int x; 
    protected int y;
}

class DerivedPoint: Point 
{
    static void Main() 
    {
        DerivedPoint dpoint = new DerivedPoint();

        // Direct access to protected members:
        dpoint.x = 10;
        dpoint.y = 15;
        Console.WriteLine("x = {0}, y = {1}", dpoint.x, dpoint.y); 
    }
}
// Output: x = 10, y = 15

