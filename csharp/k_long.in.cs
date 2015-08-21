// https://msdn.microsoft.com/en-us/library/vstudio/ctetwysk.aspx

long long1 = 4294967296;

long long2 = 4294967296L;

public static void SampleMethod(int i) {}
public static void SampleMethod(long l) {}

SampleMethod(5);    // Calling the method with the int parameter
SampleMethod(5L);   // Calling the method with the long parameter

int x = 8L;        // Error: no implicit conversion from long to int
int x = (int)8L;   // OK: explicit conversion to int

long x = 3.0;         // Error: no implicit conversion from double
long y = (long)3.0;   // OK: explicit conversion
