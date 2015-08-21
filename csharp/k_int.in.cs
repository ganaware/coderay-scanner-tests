// https://msdn.microsoft.com/en-us/library/vstudio/5kzh1b5w.aspx

int i = 123;

long aLong = 22;
int i1 = aLong;       // Error: no implicit conversion from long.
int i2 = (int)aLong;  // OK: explicit conversion.

int x = 3.0;         // Error: no implicit conversion from double.
int y = (int)3.0;    // OK: explicit conversion.
