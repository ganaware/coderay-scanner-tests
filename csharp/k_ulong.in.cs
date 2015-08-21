// https://msdn.microsoft.com/en-us/library/vstudio/t98873t4.aspx

ulong uLong = 9223372036854775808;

Console.WriteLine(9223372036854775808L.GetType());
Console.WriteLine(123UL.GetType());
Console.WriteLine((123UL + 456).GetType());

public static void SampleMethod(int i) {}
public static void SampleMethod(ulong l) {}

SampleMethod(5);    // Calling the method with the int parameter
SampleMethod(5UL);  // Calling the method with the ulong parameter

long long1 = 8UL;   // Error: no implicit conversion from ulong

// Error -- no implicit conversion from double:
ulong x = 3.0;
// OK -- explicit conversion:
ulong y = (ulong)3.0;  
