using System;

namespace DestructorApp
{
    class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("In the constructor ...");
        }
        ~Destructor()
        {
            Console.WriteLine("In the destructor ...");
        }
    }

    class DestructorApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Destructor d = new Destructor();
            Console.WriteLine("End of Main");

        }
    }
}
