// https://msdn.microsoft.com/en-us/library/vstudio/f58wzh21.aspx

unsafe static void TestMethod()
{

    // Assume that the following class exists. 
    //class Point  
    //{  
    //    public int x; 
    //    public int y;  
    //} 

    // Variable pt is a managed variable, subject to garbage collection.
    Point pt = new Point();

    // Using fixed allows the address of pt members to be taken, 
    // and "pins" pt so that it is not relocated.

    fixed (int* p = &pt.x)
    {
        *p = 1;
    }        

}

static unsafe void Test2()
{
    Point point = new Point();
    double[] arr = { 0, 1.5, 2.3, 3.4, 4.0, 5.9 };
    string str = "Hello World";

    // The following two assignments are equivalent. Each assigns the address 
    // of the first element in array arr to pointer p. 

    // You can initialize a pointer by using an array. 
    fixed (double* p = arr) { /*...*/ }

    // You can initialize a pointer by using the address of a variable.  
    fixed (double* p = &arr[0]) { /*...*/ }

    // The following assignment initializes p by using a string. 
    fixed (char* p = str) { /*...*/ }

    // The following assignment is not valid, because str[0] is a char,  
    // which is a value, not a variable. 
    //fixed (char* p = &str[0]) { /*...*/ } 


    // You can initialize a pointer by using the address of a variable, such 
    // as point.x or arr[5]. 
    fixed (int* p1 = &point.x)
    {
        fixed (double* p2 = &arr[5])
        {
            // Do something with p1 and p2.
        }
    }
}

fixed (byte* ps = srcarray, pd = dstarray) {...}

fixed (int* p1 = &point.x)
{
    fixed (double* p2 = &arr[5])
    {
        // Do something with p1 and p2.
    }
}

class Point
{ 
    public int x, y; 
}

class FixedTest2 
{
    // Unsafe method: takes a pointer to an int. 
    unsafe static void SquarePtrParam (int* p) 
    {
        *p *= *p;
    }

    unsafe static void Main() 
    {
        Point pt = new Point();
        pt.x = 5;
        pt.y = 6;
        // Pin pt in place: 
        fixed (int* p = &pt.x) 
        {
            SquarePtrParam (p);
        }
        // pt now unpinned.
        Console.WriteLine ("{0} {1}", pt.x, pt.y);
    }
}
/*
Output:
25 6
 */
