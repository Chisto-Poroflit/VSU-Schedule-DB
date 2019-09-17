using System;

namespace SichCreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
