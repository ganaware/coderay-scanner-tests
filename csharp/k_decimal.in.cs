// https://msdn.microsoft.com/en-us/library/vstudio/364x0z75.aspx

decimal myMoney = 300.5m;

decimal myMoney = 300;

decimal myMoney = 99.9m;
double x = (double)myMoney;
myMoney = (decimal)x;

double dub = 9;
// The following line causes an error that reads "Operator '+' cannot be applied to 
// operands of type 'double' and 'decimal'"
Console.WriteLine(dec + dub); 

// You can fix the error by using explicit casting of either operand.
Console.WriteLine(dec + (decimal)dub);
Console.WriteLine((double)dec + dub);

public class TestDecimal
{
    static void Main()
    {
        decimal d = 9.1m;
        int y = 3;
        Console.WriteLine(d + y);   // Result converted to decimal
    }
}
// Output: 12.1

public class TestDecimalFormat
{
    static void Main()
    {
        decimal x = 0.999m;
        decimal y = 9999999999999999999999999999m;
        Console.WriteLine("My amount = {0:C}", x);
        Console.WriteLine("Your amount = {0:C}", y);
    }
}
/* Output:
    My amount = $1.00
    Your amount = $9,999,999,999,999,999,999,999,999,999.00
*/
