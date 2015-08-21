// https://msdn.microsoft.com/en-us/library/vstudio/2aeyhxcd.aspx

class WhileTest 
{
    static void Main() 
    {
        int n = 1;
        while (n < 6) 
        {
            Console.WriteLine("Current value of n is {0}", n);
            n++;
        }
    }
}
/*
    Output:
    Current value of n is 1
    Current value of n is 2
    Current value of n is 3
    Current value of n is 4
    Current value of n is 5
 */

class WhileTest2 
{
    static void Main() 
    {
        int n = 1;
        while (n++ < 6) 
        {
            Console.WriteLine("Current value of n is {0}", n);
        }
    }
}
/*
Output:
Current value of n is 2
Current value of n is 3
Current value of n is 4
Current value of n is 5
Current value of n is 6
*/

class WhileTest3
{
    static void Main() 
    {
        int n = 5;
        while (++n < 6) 
        {
            Console.WriteLine("Current value of n is {0}", n);
        }
    }
}
