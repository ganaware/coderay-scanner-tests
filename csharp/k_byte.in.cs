// https://msdn.microsoft.com/en-us/library/vstudio/5bdb6693.aspx

byte myByte = 255;

byte x = 10, y = 20;

// Error: conversion from int to byte:
byte z = x + y;

// OK: explicit conversion:
byte z = (byte)(x + y);

// Error: no implicit conversion from double:
byte x = 3.0; 
// OK: explicit conversion:
byte y = (byte)3.0;

public static void SampleMethod(int i) {}
public static void SampleMethod(byte b) {}

// Calling the method with the int parameter:
SampleMethod(5);
// Calling the method with the byte parameter:
SampleMethod((byte)5);
