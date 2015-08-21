// https://msdn.microsoft.com/en-us/library/vstudio/x0sksh43.aspx

uint myUint = 4294967290;

uint uInt1 = 123;

uint uInt2 = 123U;

Console.WriteLine(44U.GetType());
Console.WriteLine(323442434344U.GetType());

float myFloat = 4294967290;   // OK: implicit conversion to float

long aLong = 22;
// Error -- no implicit conversion from long:
uint uInt1 = aLong; 
// OK -- explicit conversion:
uint uInt2 = (uint)aLong;

// Error -- no implicit conversion from double:
uint x = 3.0;
// OK -- explicit conversion:
uint y = (uint)3.0; 
