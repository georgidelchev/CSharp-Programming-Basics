using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string passwordInput = Console.ReadLine();
            while (passwordInput != pass)
            {
                passwordInput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}");
        }
    }
}
