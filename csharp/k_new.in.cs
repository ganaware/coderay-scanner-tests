// https://msdn.microsoft.com/en-us/library/vstudio/51y09td4.aspx

// https://msdn.microsoft.com/en-us/library/vstudio/fa0ab757.aspx

Class1 obj  = new Class1();

var query = from cust in customers
            select new {Name = cust.Name, Address = cust.PrimaryAddress};

int i = new int();

struct SampleStruct
{
   public int x;
   public int y;

   public SampleStruct(int x, int y)
   {
      this.x = x;
      this.y = y;
   }
}

class SampleClass
{
   public string name;
   public int id;

   public SampleClass() {}

   public SampleClass(int id, string name)
   {
      this.id = id;
      this.name = name;
   }
}

class ProgramClass
{
   static void Main()
   {
      // Create objects using default constructors:
      SampleStruct Location1 = new SampleStruct();
      SampleClass Employee1 = new SampleClass();

      // Display values:
      Console.WriteLine("Default values:");
      Console.WriteLine("   Struct members: {0}, {1}",
             Location1.x, Location1.y);
      Console.WriteLine("   Class members: {0}, {1}",
             Employee1.name, Employee1.id);

      // Create objects using parameterized constructors:
      SampleStruct Location2 = new SampleStruct(10, 20);
      SampleClass Employee2 = new SampleClass(1234, "Cristina Potra");

      // Display values:
      Console.WriteLine("Assigned values:");
      Console.WriteLine("   Struct members: {0}, {1}",
             Location2.x, Location2.y);
      Console.WriteLine("   Class members: {0}, {1}",
             Employee2.name, Employee2.id);
   }
}
/*
Output:
Default values:
   Struct members: 0, 0
   Class members: , 0
Assigned values:
   Struct members: 10, 20
   Class members: Cristina Potra, 1234
*/

// https://msdn.microsoft.com/en-us/library/vstudio/435f1dw2.aspx

public class BaseC
{
    public int x;
    public void Invoke() { }
}
public class DerivedC : BaseC
{
    new public void Invoke() { }
}

public class BaseC
{
    public static int x = 55;
    public static int y = 22;
}

public class DerivedC : BaseC
{
    // Hide field 'x'. 
    new public static int x = 100;

    static void Main()
    {
        // Display the new value of x:
        Console.WriteLine(x);

        // Display the hidden value of x:
        Console.WriteLine(BaseC.x);

        // Display the unhidden member y:
        Console.WriteLine(y);
    }
}
/*
Output:
100
55
22
*/

public class BaseC 
{
    public class NestedC 
    {
        public int x = 200;
        public int y;
    }
}

public class DerivedC : BaseC 
{
    // Nested type hiding the base type members. 
    new public class NestedC   
    {
        public int x = 100;
        public int y; 
        public int z;
    }

    static void Main() 
    {
        // Creating an object from the overlapping class:
        NestedC c1  = new NestedC();

        // Creating an object from the hidden class:
        BaseC.NestedC c2 = new BaseC.NestedC();

        Console.WriteLine(c1.x);
        Console.WriteLine(c2.x);   
    }
}
/*
Output:
100
200
*/

// https://msdn.microsoft.com/en-us/library/vstudio/sd2w2ew5.aspx

class ItemFactory<T> where T : new()
{
    public T GetNewItem()
    {
        return new T();
    }
}

public class ItemFactory2<T>
    where T : IComparable, new()
{
}
