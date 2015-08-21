// https://msdn.microsoft.com/en-us/library/vstudio/hh156513.aspx

public async Task<int> ExampleMethodAsync()
{
    // . . . .
}

// You can run this code in Visual Studio 2013 as a WPF app or a Windows Store app.
// You need a button (StartButton) and a textbox (ResultsTextBox).
// Remember to set the names and handler so that you have something like this:
// <Button Content="Button" HorizontalAlignment="Left" Margin="88,77,0,0" VerticalAlignment="Top" Width="75"
//         Click="StartButton_Click" Name="StartButton"/>
// <TextBox HorizontalAlignment="Left" Height="137" Margin="88,140,0,0" TextWrapping="Wrap" 
//          Text="TextBox" VerticalAlignment="Top" Width="310" Name="ResultsTextBox"/>
        
// To run the code as a WPF app:
//    paste this code into the MainWindow class in MainWindow.xaml.cs,
//    add a reference to System.Net.Http, and
//    add a using directive for System.Net.Http.

// To run the code as a Windows Store app:
//    paste this code into the MainPage class in MainPage.xaml.cs, and
//    add using directives for System.Net.Http and System.Threading.Tasks.

private async void StartButton_Click(object sender, RoutedEventArgs e)
{
    // ExampleMethodAsync returns a Task<int>, which means that the method
    // eventually produces an int result. However, ExampleMethodAsync returns
    // the Task<int> value as soon as it reaches an await.
    ResultsTextBox.Text += "\n";
    try
    {
        int length = await ExampleMethodAsync();
        // Note that you could put "await ExampleMethodAsync()" in the next line where
        // "length" is, but due to when '+=' fetches the value of ResultsTextBox, you
        // would not see the global side effect of ExampleMethodAsync setting the text.
        ResultsTextBox.Text += String.Format("Length: {0}\n", length);
    }
    catch (Exception)
    {
        // Process the exception if one occurs.
    }
}

public async Task<int> ExampleMethodAsync()
{
    var httpClient = new HttpClient();
    int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;
    ResultsTextBox.Text += "Preparing to finish ExampleMethodAsync.\n";
    // After the following return statement, any method that's awaiting
    // ExampleMethodAsync (in this case, StartButton_Click) can get the 
    // integer result.
    return exampleInt;
}
// Output:
// Preparing to finish ExampleMethodAsync.
// Length: 53292
