// https://msdn.microsoft.com/en-us/library/vstudio/14akc2c7.aspx

class RefExample
{
    static void Method(ref int i)
    {
        // Rest the mouse pointer over i to verify that it is an int. 
        // The following statement would cause a compiler error if i 
        // were boxed as an object.
        i = i + 44;
    }

    static void Main()
    {
        int val = 1;
        Method(ref val);
        Console.WriteLine(val);

        // Output: 45
    }
}

class RefOverloadExample
{
    public void SampleMethod(int i) { }
    public void SampleMethod(ref int i) { }
}

class RefExample2
{
    static void ChangeByReference(ref Product itemRef)
    {
        // The following line changes the address that is stored in   
        // parameter itemRef. Because itemRef is a ref parameter, the 
        // address that is stored in variable item in Main also is changed.
        itemRef = new Product("Stapler", 99999);

        // You can change the value of one of the properties of 
        // itemRef. The change happens to item in Main as well.
        itemRef.ItemID = 12345;
    }

    static void Main()
    {
        // Declare an instance of Product and display its initial values.
        Product item = new Product("Fasteners", 54321);
        System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
            item.ItemName, item.ItemID);

        // Send item to ChangeByReference as a ref argument.
        ChangeByReference(ref item);
        System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
            item.ItemName, item.ItemID);
    }
}

class Product
{
    public Product(string name, int newID)
    {
        ItemName = name;
        ItemID = newID;
    }

    public string ItemName { get; set; }
    public int ItemID { get; set; }
}

// Output:  
//Original values in Main.  Name: Fasteners, ID: 54321 

//Back in Main.  Name: Stapler, ID: 12345
