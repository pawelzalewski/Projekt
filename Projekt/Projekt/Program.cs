using System;
using System.Net.Mime;

namespace Projekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Wstęp oraz imie naszej postaci
            Console.WriteLine("Witam gracza");
            Console.WriteLine("Podaj swoje imię:");
            string name = Console.ReadLine();
            Console.WriteLine("A więc twoje imie to " + name + ", grubo");
            Console.ReadKey();
            Console.Clear();
            
            
            //Rozdział 1
            Console.WriteLine("Rozdział 1");
            Console.WriteLine("Misja");
            Console.ReadKey();
            Console.Clear();
            
            
            //Wstęp
            Console.WriteLine(name + " Wspiera HAMAS");
            
        }
    }
}