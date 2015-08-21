// https://msdn.microsoft.com/en-us/library/vstudio/06tc147t.aspx

int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}

switch (caseSwitch)
{
    // The following switch section causes an error.
    case 1:
        Console.WriteLine("Case 1...");
        // Add a break or other jump statement here.
    case 2:
        Console.WriteLine("... and/or Case 2");
        break;
}

case 4:
    while (true)
        Console.WriteLine("Endless looping. . . .");

class Program
{
    static void Main(string[] args)
    {
        int switchExpression = 3;
        switch (switchExpression)
        {
            // A switch section can have more than one case label. 
            case 0:
            case 1:
                Console.WriteLine("Case 0 or 1");
                // Most switch sections contain a jump statement, such as 
                // a break, goto, or return. The end of the statement list 
                // must be unreachable. 
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
                // The following line causes a warning.
                Console.WriteLine("Unreachable code");
            // 7 - 4 in the following line evaluates to 3. 
            case 7 - 4:
                Console.WriteLine("Case 3");
                break;
            // If the value of switchExpression is not 0, 1, 2, or 3, the 
            // default case is executed. 
            default:
                Console.WriteLine("Default case (optional)");
                // You cannot "fall through" any switch section, including
                // the last one. 
                break;
        }
    }
}

class SwitchTest
{
    static void Main()
    {
        Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
        Console.Write("Please enter your selection: ");
        string str = Console.ReadLine();
        int cost = 0;

        // Notice the goto statements in cases 2 and 3. The base cost of 25 
        // cents is added to the additional cost for the medium and large sizes. 
        switch (str)
        {
            case "1":
            case "small":
                cost += 25;
                break;
            case "2":
            case "medium":
                cost += 25;
                goto case "1";
            case "3":
            case "large":
                cost += 50;
                goto case "1";
            default:
                Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                break;
        }
        if (cost != 0)
        {
            Console.WriteLine("Please insert {0} cents.", cost);
        }
        Console.WriteLine("Thank you for your business.");
    }
}
/*
    Sample Input: 2

    Sample Output:
    Coffee sizes: 1=small 2=medium 3=large
    Please enter your selection: 2
    Please insert 50 cents.
    Thank you for your business.
*/
