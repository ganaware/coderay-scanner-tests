// https://msdn.microsoft.com/en-us/library/vstudio/bb384067.aspx

public class MyGenericClass<T> where T:IComparable { }

class MyClass<T, U>
    where T : class 
    where U : struct
{ }

public class MyGenericClass<T> where T : IComparable, new()
{
    // The following line is not possible without new() constraint:
    T item = new T();
}

interface IMyInterface
{
}

class Dictionary<TKey, TVal>
    where TKey : IComparable, IEnumerable
    where TVal : IMyInterface
{
    public void Add(TKey key, TVal val)
    {
    }
}

public bool MyMethod<T>(T t) where T : IMyInterface { }

delegate T MyDelegate<T>() where T : new()
