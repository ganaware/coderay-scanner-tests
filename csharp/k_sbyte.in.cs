// https://msdn.microsoft.com/en-us/library/vstudio/d86he86x.aspx

sbyte sByte1 = 127;

public static void SampleMethod(int i) {}
public static void SampleMethod(sbyte b) {}

// Calling the method with the int parameter:
SampleMethod(5);
// Calling the method with the sbyte parameter:
SampleMethod((sbyte)5);

sbyte x = 10, y = 20;

sbyte z = x + y;   // Error: conversion from int to sbyte

sbyte z = (sbyte)(x + y);   // OK: explicit conversion

sbyte x = 10, y = 20;
int m = x + y;
long n = x + y;

sbyte x = 3.0;         // Error: no implicit conversion from double
sbyte y = (sbyte)3.0;  // OK: explicit conversion
