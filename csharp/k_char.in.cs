// https://msdn.microsoft.com/en-us/library/vstudio/x9h8tsay.aspx

char[] chars = new char[4];

chars[0] = 'X';        // Character literal
chars[1] = '\x0058';   // Hexadecimal
chars[2] = (char)88;   // Cast from integral type
chars[3] = '\u0058';   // Unicode 

foreach (char c in chars)
{
    Console.Write(c + " ");
}
// Output: X X X X
