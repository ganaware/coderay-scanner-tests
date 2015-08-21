// https://msdn.microsoft.com/en-us/library/vstudio/hh156528.aspx

private async Task SumPageSizesAsync()
{
    // To use the HttpClient type in desktop apps, you must include a using directive and add a 
    // reference for the System.Net.Http namespace.
    HttpClient client = new HttpClient();
    // . . .
    Task<byte[]> getContentsTask = client.GetByteArrayAsync(url);
    byte[] urlContents = await getContentsTask;

    // Equivalently, now that you see how it works, you can write the same thing in a single line.
    //byte[] urlContents = await client.GetByteArrayAsync(url);
    // . . .
}

// Keyword await used with a method that returns a Task<TResult>.
TResult result = await AsyncMethodThatReturnsTaskTResult();

// Keyword await used with a method that returns a Task.
await AsyncMethodThatReturnsTask();

private async void button1_Click(object sender, EventArgs e)
{
    // Call the method that runs asynchronously.
    string result = await WaitAsynchronouslyAsync();

    // Call the method that runs synchronously.
    //string result = await WaitSynchronously ();

    // Display the result.
    textBox1.Text += result;
}

// The following method runs asynchronously. The UI thread is not
// blocked during the delay. You can move or resize the Form1 window 
// while Task.Delay is running.
public async Task<string> WaitAsynchronouslyAsync()
{
    await Task.Delay(10000);
    return "Finished";
}

// The following method runs synchronously, despite the use of async.
// You cannot move or resize the Form1 window while Thread.Sleep
// is running because the UI thread is blocked.
public async Task<string> WaitSynchronously()
{
    // Add a using directive for System.Threading.
    Thread.Sleep(10000);
    return "Finished";
}
