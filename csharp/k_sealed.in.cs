// https://msdn.microsoft.com/en-us/library/vstudio/88c54tsw.aspx

class A {}    
sealed class B : A {}

class X
{
    protected virtual void F() { Console.WriteLine("X.F"); }
    protected virtual void F2() { Console.WriteLine("X.F2"); }
}
class Y : X
{
    sealed protected override void F() { Console.WriteLine("Y.F"); }
    protected override void F2() { Console.WriteLine("Y.F2"); }
}
class Z : Y
{
    // Attempting to override F causes compiler error CS0239. 
    // protected override void F() { Console.WriteLine("C.F"); }

    // Overriding F2 is allowed. 
    protected override void F2() { Console.WriteLine("Z.F2"); }
}

sealed class SealedClass
{
    public int x;
    public int y;
}

class SealedTest2
{
    static void Main()
    {
        SealedClass sc = new SealedClass();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
    }
}
// Output: x = 110, y = 150
