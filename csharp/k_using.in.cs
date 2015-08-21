// https://msdn.microsoft.com/en-us/library/vstudio/zhdeatwt.aspx

// https://msdn.microsoft.com/en-us/library/vstudio/sf0df423.aspx

using System.Text;
using static System.Math;
using Project = PC.MyCompany.Project;

using static System.Console; 
using static System.Math;
class Program 
{ 
    static void Main() 
    { 
        WriteLine(Sqrt(3*3 + 4*4)); 
    } 
}

namespace PC
{
    // Define an alias for the nested namespace. 
    using Project = PC.MyCompany.Project;
    class A
    {
        void M()
        {
            // Use the alias
            Project.MyClass mc = new Project.MyClass();
        }
    }
    namespace MyCompany
    {
        namespace Project
        {
            public class MyClass { }
        }
    }
}

using System;

// Using alias directive for a class. 
using AliasToMyClass = NameSpace1.MyClass;

// Using alias directive for a generic class. 
using UsingAlias = NameSpace2.MyClass<int>;

namespace NameSpace1
{
    public class MyClass
    {
        public override string ToString()
        {
            return "You are in NameSpace1.MyClass.";
        }
    }

}

namespace NameSpace2
{
    class MyClass<T>
    {
        public override string ToString()
        {
            return "You are in NameSpace2.MyClass.";
        }
    }
}

namespace NameSpace3
{
    // Using directive: 
    using NameSpace1;
    // Using directive: 
    using NameSpace2;

    class MainClass
    {
        static void Main()
        {
            AliasToMyClass instance1 = new AliasToMyClass();
            Console.WriteLine(instance1);

            UsingAlias instance2 = new UsingAlias();
            Console.WriteLine(instance2);

        }
    }
}
// Output:  
//    You are in NameSpace1.MyClass. 
//    You are in NameSpace2.MyClass.

// https://msdn.microsoft.com/en-us/library/vstudio/yh598w02.aspx

using (Font font1 = new Font("Arial", 10.0f)) 
{
    byte charset = font1.GdiCharSet;
}

{
  Font font1 = new Font("Arial", 10.0f);
  try
  {
    byte charset = font1.GdiCharSet;
  }
  finally
  {
    if (font1 != null)
      ((IDisposable)font1).Dispose();
  }
}

using (Font font3 = new Font("Arial", 10.0f),
            font4 = new Font("Arial", 10.0f))
{
    // Use font3 and font4.
}

            Font font2 = new Font("Arial", 10.0f);
            using (font2) // not recommended
            {
                // use font2
            }
            // font2 is still in scope 
            // but the method call throws an exception 
            float f = font2.GetHeight();

