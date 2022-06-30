using System;
using System.Net.Mime;
using System.Threading.Channels;

namespace Projekt
{
    public class Program
    {
        public static Postac postac = new Postac();

        static void Main(string[] args)
        {
            Start();
            Introduction.Intro();
            Chapter_1.Wyprawa();
            Chapter_2.Osiedlowy();
            Chapter_3.Deszcz();
            Chapter_4.PonownaNauka();
            Chapter_5.Sesja();
        }

        static void Start()
        {
            string title = @" $$$$$$\    $$\                     $$\                      $$\  $$\               $$\       $$\  $$$$$$\           
$$  __$$\   $$ |                    $$ |                     $$ | $  |              $$ |      \__|$$  __$$\          
$$ /  \__|$$$$$$\   $$\   $$\  $$$$$$$ | $$$$$$\  $$$$$$$\ $$$$$$\\_/$$$$$$$\       $$ |      $$\ $$ /  \__|$$$$$$\  
\$$$$$$\  \_$$  _|  $$ |  $$ |$$  __$$ |$$  __$$\ $$  __$$\\_$$  _| $$  _____|      $$ |      $$ |$$$$\    $$  __$$\ 
 \____$$\   $$ |    $$ |  $$ |$$ /  $$ |$$$$$$$$ |$$ |  $$ | $$ |   \$$$$$$\        $$ |      $$ |$$  _|   $$$$$$$$ |
$$\   $$ |  $$ |$$\ $$ |  $$ |$$ |  $$ |$$   ____|$$ |  $$ | $$ |$$\ \____$$\       $$ |      $$ |$$ |     $$   ____|
\$$$$$$  |  \$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$\ $$ |  $$ | \$$$$  |$$$$$$  |      $$$$$$$$\ $$ |$$ |     \$$$$$$$\ 
 \______/    \____/  \______/  \_______| \_______|\__|  \__|  \____/\_______/       \________|\__|\__|      \_______|";
            poczatek:
            Console.WriteLine(title);
            Console.WriteLine("=======================================");
            Console.WriteLine("Aby wejść do świata gry, nacisnij G");
            Console.WriteLine("=======================================");
            string g = Console.ReadLine();
            Console.Clear();
            if (g.ToLower() == "g")
                Print("Witaj!", 60);
            else
                goto poczatek;
            //Wstęp oraz imie naszej postaci
            Print("Podaj swoje imię:", 60);
            imie:
            postac.name = Console.ReadLine();
            Console.Clear();
            if (postac.name == "")
            {
                Print("Musisz podać swoje imie");
                goto imie;
            }

            Print("A więc twoje imie to ");
            Console.Write(Program.postac.name);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }

            Console.WriteLine();
        }
    }
}