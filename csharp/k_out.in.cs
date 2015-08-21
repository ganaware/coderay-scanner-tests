// https://msdn.microsoft.com/en-us/library/vstudio/t3c3bfhx.aspx

class OutExample
{
    static void Method(out int i)
    {
        i = 44;
    }
    static void Main()
    {
        int value;
        Method(out value);
        // value is now 44
    }
}

class OutOverloadExample
{
    public void SampleMethod(int i) { }
    public void SampleMethod(out int i) { i = 5; }
}

class OutReturnExample
{
    static void Method(out int i, out string s1, out string s2)
    {
        i = 44;
        s1 = "I've been returned";
        s2 = null;
    }
    static void Main()
    {
        int value;
        string str1, str2;
        Method(out value, out str1, out str2);
        // value is now 44 
        // str1 is now "I've been returned" 
        // str2 is (still) null;
    }
}
