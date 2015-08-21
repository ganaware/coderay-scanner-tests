// https://msdn.microsoft.com/en-us/library/vstudio/362314fe.aspx

string a = "hello";
string b = "h";
// Append to contents of 'b'
b += "ello";
Console.WriteLine(a == b);
Console.WriteLine((object)a == (object)b);

string a = "good " + "morning";

string b = "h";
b += "ello";

string str = "test";
char x = str[2];  // x = 's';

"good morning"  // a string literal

string a = "\\\u0066\n";
Console.WriteLine(a);

@"good morning"  // a string literal

@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"

@"""Ahoy!"" cried the captain." // "Ahoy!" cried the captain.

class SimpleStringTest 
{
   static void Main()
   {
      string a = "\u0068ello ";
      string b = "world";
      Console.WriteLine( a + b );
      Console.WriteLine( a + b == "Hello World" ); // == performs a case-sensitive comparison
   }
}
/* Output:
    hello world
    False
 */
