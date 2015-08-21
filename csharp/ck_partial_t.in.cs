// https://msdn.microsoft.com/en-us/library/vstudio/wbx7zzdd.aspx

namespace PC
{
    partial class A
    {
        int num = 0;
        void MethodA() { }
        partial void MethodC();
    }
}

namespace PC
{
    partial class A
    {
        void MethodB() { }
        partial void MethodC() { }
    }
}
