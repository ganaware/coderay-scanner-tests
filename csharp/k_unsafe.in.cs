// https://msdn.microsoft.com/en-us/library/vstudio/chfa2zb8.aspx

unsafe static void FastCopy(byte[] src, byte[] dst, int count)
{
    // Unsafe context: can use pointers here.
}

unsafe static void FastCopy ( byte* ps, byte* pd, int count ) {...}

unsafe
{
    // Unsafe context: can use pointers here.
}

// compile with: /unsafe 

class UnsafeTest
{
   // Unsafe method: takes pointer to int: 
   unsafe static void SquarePtrParam(int* p)
   {
      *p *= *p;
   }

   unsafe static void Main()
   {
      int i = 5;
      // Unsafe method: uses address-of operator (&):
      SquarePtrParam(&i);
      Console.WriteLine(i);
   }
}
// Output: 25
