using System;
namespace SystemExThrowApp
{
    class SystemExThrow
    {
        public static void Exp(int ptr)
        {
            if (ptr == 0)
                throw new NullReferenceException();
        }
    }
    class SystemExThrowApp
    {
        public static void Main()
        {
            int i = 0;
            SystemExThrow.Exp(i);
        }
    }
}