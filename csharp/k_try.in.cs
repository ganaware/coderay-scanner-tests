// https://msdn.microsoft.com/en-us/library/vstudio/0yd65esw.aspx

object o2 = null;
try
{
    int i2 = (int)o2;   // Error
}

catch (InvalidCastException e) 
{
}

catch (ArgumentException e) if (e.ParamName == "...")
{
}

catch (FileNotFoundException e)
{
    // FileNotFoundExceptions are handled here.
}
catch (IOException e)
{
    // Extract some information from this exception, and then 
    // throw it to the parent method.
    if (e.Source != null)
        Console.WriteLine("IOException source: {0}", e.Source);
    throw;
}

catch (InvalidCastException e) 
{
    // Perform some action here, and then throw a new exception.
    throw new YourCustomException("Put your error message here.", e);
}

catch (InvalidCastException e)
{
    if (e.Data == null)
    {
        throw;
    }
    else
    {
        // Take some action.
    }
}

static void Main() 
{
    int n;
    try 
    {
        // Do not initialize this variable here.
        n = 123;
    }
    catch
    {
    }
    // Error: Use of unassigned local variable 'n'.
    Console.Write(n);
}

class TryFinallyTest
{
    static void ProcessString(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException();
        }
    }

    static void Main()
    {
        string s = null; // For demonstration purposes. 

        try
        {            
            ProcessString(s);
        }

        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
    }
}
    /*
    Output:
    System.ArgumentNullException: Value cannot be null.
       at TryFinallyTest.Main() Exception caught.
     * */

class ThrowTest3
{
    static void ProcessString(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException();
        }
    }

    static void Main()
    {
        try
        {
            string s = null;
            ProcessString(s);
        }
        // Most specific: 
        catch (ArgumentNullException e)
        {
            Console.WriteLine("{0} First exception caught.", e);
        }
        // Least specific: 
        catch (Exception e)
        {
            Console.WriteLine("{0} Second exception caught.", e);
        }
    }
}
/*
 Output:
 System.ArgumentNullException: Value cannot be null.
 at Test.ThrowTest3.ProcessString(String s) ... First exception caught.
*/

        public async Task DoSomethingAsync()
        {
            Task<string> theTask = DelayAsync();

            try
            {
                string result = await theTask;
                Debug.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Message: " + ex.Message);
            }
            Debug.WriteLine("Task IsCanceled: " + theTask.IsCanceled);
            Debug.WriteLine("Task IsFaulted:  " + theTask.IsFaulted);
            if (theTask.Exception != null)
            {
                Debug.WriteLine("Task Exception Message: "
                    + theTask.Exception.Message);
                Debug.WriteLine("Task Inner Exception Message: "
                    + theTask.Exception.InnerException.Message);
            }
        }

        private async Task<string> DelayAsync()
        {
            await Task.Delay(100);

            // Uncomment each of the following lines to 
            // demonstrate exception handling. 

            //throw new OperationCanceledException("canceled");
            //throw new Exception("Something happened.");
            return "Done";
        }

        // Output when no exception is thrown in the awaited method: 
        //   Result: Done 
        //   Task IsCanceled: False 
        //   Task IsFaulted:  False 

        // Output when an Exception is thrown in the awaited method: 
        //   Exception Message: Something happened. 
        //   Task IsCanceled: False 
        //   Task IsFaulted:  True 
        //   Task Exception Message: One or more errors occurred. 
        //   Task Inner Exception Message: Something happened. 

        // Output when a OperationCanceledException or TaskCanceledException 
        // is thrown in the awaited method: 
        //   Exception Message: canceled 
        //   Task IsCanceled: True 
        //   Task IsFaulted:  False

public async Task DoMultipleAsync()
{
    Task theTask1 = ExcAsync(info: "First Task");
    Task theTask2 = ExcAsync(info: "Second Task");
    Task theTask3 = ExcAsync(info: "Third Task");

    Task allTasks = Task.WhenAll(theTask1, theTask2, theTask3);

    try
    {
        await allTasks;
    }
    catch (Exception ex)
    {
        Debug.WriteLine("Exception: " + ex.Message);
        Debug.WriteLine("Task IsFaulted: " + allTasks.IsFaulted);
        foreach (var inEx in allTasks.Exception.InnerExceptions)
        {
            Debug.WriteLine("Task Inner Exception: " + inEx.Message);
        }
    }
}

private async Task ExcAsync(string info)
{
    await Task.Delay(100);

    throw new Exception("Error-" + info);
}

// Output: 
//   Exception: Error-First Task 
//   Task IsFaulted: True 
//   Task Inner Exception: Error-First Task 
//   Task Inner Exception: Error-Second Task 
//   Task Inner Exception: Error-Third Task

// https://msdn.microsoft.com/en-us/library/vstudio/dszsf989.aspx

public class EHClass
{
    void ReadFile(int index)
    {
        // To run this code, substitute a valid path from your local machine 
        string path = @"c:\users\public\test.txt";
        System.IO.StreamReader file = new System.IO.StreamReader(path);
        char[] buffer = new char[10];
        try
        {
            file.ReadBlock(buffer, index, buffer.Length);
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine("Error reading from {0}. Message = {1}", path, e.Message);
        }

        finally
        {
            if (file != null)
            {
                file.Close();
            }
        }
        // Do something with buffer...
    }

}
