// https://msdn.microsoft.com/en-us/library/vstudio/cbf1574z.aspx

ushort myShort = 65535;

public static void SampleMethod(int i) {}
public static void SampleMethod(ushort s) {}

// Calls the method with the int parameter:
SampleMethod(5);
// Calls the method with the ushort parameter:
SampleMethod((ushort)5);

ushort x = 5, y = 12;

ushort z = x + y;   // Error: conversion from int to ushort

ushort z = (ushort)(x + y);   // OK: explicit conversion

// Error -- no implicit conversion from double:
ushort x = 3.0; 
// OK -- explicit conversion:
ushort y = (ushort)3.0;
