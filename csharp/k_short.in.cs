// https://msdn.microsoft.com/en-us/library/vstudio/ybs77ex4.aspx

short x = 32767;

public static void SampleMethod(int i) {}
public static void SampleMethod(short s) {}

SampleMethod(5);         // Calling the method with the int parameter
SampleMethod((short)5);  // Calling the method with the short parameter

short x = 5, y = 12;

short z = x + y; // Error: no conversion from int to short

short z = (short)(x + y); // OK: explicit conversion

int m = x + y;
long n = x + y;

short x = 3.0;          // Error: no implicit conversion from double
short y = (short)3.0;   // OK: explicit conversion
