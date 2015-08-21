// https://msdn.microsoft.com/en-us/library/vstudio/dd469484.aspx

// Contravariant interface. 
interface IContravariant<in A> { }

// Extending contravariant interface. 
interface IExtContravariant<in A> : IContravariant<A> { }

// Implementing contravariant interface. 
class Sample<A> : IContravariant<A> { }

class Program
{
    static void Test()
    {
        IContravariant<Object> iobj = new Sample<Object>();
        IContravariant<String> istr = new Sample<String>();

        // You can assign iobj to istr because 
        // the IContravariant interface is contravariant.
        istr = iobj;
    }
}

// Contravariant delegate. 
public delegate void DContravariant<in A>(A argument);

// Methods that match the delegate signature. 
public static void SampleControl(Control control)
{ }
public static void SampleButton(Button button)
{ }

public void Test()
{

    // Instantiating the delegates with the methods.
    DContravariant<Control> dControl = SampleControl;
    DContravariant<Button> dButton = SampleButton;

    // You can assign dControl to dButton 
    // because the DContravariant delegate is contravariant.
    dButton = dControl;

    // Invoke the delegate.
    dButton(new Button()); 
}
