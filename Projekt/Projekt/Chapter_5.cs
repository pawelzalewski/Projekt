using System;
using System.ComponentModel.Design;

namespace Projekt
{
    public class Chapter_5
    {
        public static void Sesja()
        {
            Program.Print("Budzisz się następnego dnia rano.");
            Program.Print("To jest ten dzień którego tak sie obawiasz.");
            Program.Print("Budzisz sie rano ");
            Wyniki();
            
            
            
            
            
            Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
            Console.ReadKey();
            Wyniki();
            
        }
        static private Random rand = new Random();
        public static void Wyniki()
        {
            Random rand = new Random();
            int r = rand.Next(0, 101);
            if (Program.postac.szansa<=r)
            {
                Program.Print("No i git, udało sie");
            }
            else
            {
                Program.Print("Niestety nie udało się. Trzeba będzie dociskać na drugi termin");
            }
        }
    }
}