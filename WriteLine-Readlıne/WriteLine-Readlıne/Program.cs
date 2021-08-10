using System;

namespace WriteLine_Readlıne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name :"); //ekrana yazdırma
            string name = Console.ReadLine();    // Kullanıcıdan bilgi isteme

            Console.Write("What is your surname :");
            string surname = Console.ReadLine();

            Console.Write("What is your age :");
            string age = Console.ReadLine();
            Console.WriteLine("Welcome to " + name + " " + surname + " your age is "+ age);

            /*
            Console.Write("Enter your age :");
            int age = Console.Read();    // Kullanıcıdan bilgi isteme ascii kodunu bize verir
            Console.WriteLine("Your Age " + age);
            Console.ReadKey();
            */
        }
    }
}
