using System;

namespace PropertyWithoutFieldApp
{
    class PropertyWithoutField
    {
        public string Message
        {
            get { return Console.ReadLine(); }
            set { Console.WriteLine(value); }
        }
    }

    class PropertyWithoutFieldApp
    {
        public static void Main(string[] args)
        {
            PropertyWithoutField obj = new PropertyWithoutField();
            obj.Message = obj.Message;
        }
    }
}
