using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

namespace Projekt
{
    public class Chapter_5
    {
        public static void Sesja()
        {
            Program.Print("Budzisz się następnego dnia rano.");
            Program.Print("To jest ten dzień którego tak sie obawiasz:");
            Console.ReadKey();
            Console.Clear();
            string title = @"   _____          _       _ _ _ 
  / ____|        (_)     | | | |
 | (___   ___ ___ _  __ _| | | |
  \___ \ / _ | __| |/ _` | | | |
  ____) |  __|__ \ | (_| |_|_|_|
 |_____/ \___|___/ |\__,_(_|_|_)
                _/ |            
               |__/          ";
            Console.WriteLine(title);
            Console.ReadKey();
            Console.Clear();
            Program.Print("No nic, trzeba być dobrej myśli");
            Program.Print("Nie ma co tracić czasu. Stajesz szybko na nogi i przygotowujesz się na dzień próby.");
            Program.Print("Wychodzisz z domu i wyruszasz zmierzyć się ze swoim przeznaczeniem.");
            Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
            Console.ReadKey();
            Wyniki();
            
            
            
            
            
            
            
            
        }
        static private Random rand = new Random();
        public static void Wyniki()
        {
            Random rand = new Random();
            int r = rand.Next(0, 101);
            if (Program.postac.szansa>=r)
            {
                
                Program.Print("Gratulacje! Udało ci się zdać semestr (Dobre zakończenie)");
            }
            else
            {
                Program.Print("Niestety nie udało ci się. Trzeba będzie dociskać na drugi termin. (Złe zakończenie)");
            }
            Console.WriteLine(Program.postac.szansa);
            Console.WriteLine(r);
        }
    }
}