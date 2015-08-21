// https://msdn.microsoft.com/en-us/library/vstudio/dd469487.aspx

// Covariant interface. 
interface ICovariant<out R> { }

// Extending covariant interface. 
interface IExtCovariant<out R> : ICovariant<R> { }

// Implementing covariant interface. 
class Sample<R> : ICovariant<R> { }

class Program
{
    static void Test()
    {
        ICovariant<Object> iobj = new Sample<Object>();
        ICovariant<String> istr = new Sample<String>();

        // You can assign istr to iobj because 
        // the ICovariant interface is covariant.
        iobj = istr;
    }
}

// Covariant delegate. 
public delegate R DCovariant<out R>();

// Methods that match the delegate signature. 
public static Control SampleControl()
{ return new Control(); }

public static Button SampleButton()
{ return new Button(); }

public void Test()
{            
    // Instantiate the delegates with the methods.
    DCovariant<Control> dControl = SampleControl;
    DCovariant<Button> dButton = SampleButton;

    // You can assign dButton to dControl 
    // because the DCovariant delegate is covariant.
    dControl = dButton;

    // Invoke the delegate.
    dControl(); 
}
