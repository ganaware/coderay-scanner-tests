// https://msdn.microsoft.com/en-us/library/vstudio/ch45axte.aspx

class ForLoopTest 
{
    static void Main() 
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
/*
Output:
1
2
3
4
5
*/

static void Main()
{
    int i;
    int j = 10;
    for (i = 0, Console.WriteLine("Start: {0}",i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
    {
        // Body of the loop.
    }
}
// Output: 
// Start: 0 
// i=1, j=9 
// i=2, j=8 
// i=3, j=7 
// i=4, j=6 
// i=5, j=5

for (; ; )
{
    // ...
}
