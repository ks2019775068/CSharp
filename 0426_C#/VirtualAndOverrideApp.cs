using System;
namespace VirtualAndOverrideApp
{
    class CLanguage
    {
        virtual public void Print()
        {
            Console.WriteLine("In the Clanguage class ...");
        }
    }
    class Java : CLanguage
    {
        override public void Print()
        {
            Console.WriteLine("In the Java class ...");
        }
    }
    class VirtualAndOverrideApp
    {
        static void Main(string[] args)
        {
            CLanguage c = new Java();
            c.Print();
        }
    }
}