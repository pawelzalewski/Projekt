using System;
using System.Net.Mime;

namespace Projekt
{
    public class Program
    {
        public static Postac postac = new Postac();

        static void Main(string[] args)
        {
            Start();
            Akcje.PierwszaAkcja();
            Rozdzial_2.Rozdzial2();

        }

        static void Start()
        {
            poczatek:
            Console.WriteLine("=======================================");
            Console.WriteLine("Aby wejść do świata gry, nacisnij G");
            Console.WriteLine("=======================================");
            string g = Console.ReadLine();
            Console.Clear();
            if (g.ToLower() == "g")
                Print("Witam gracza", 60);
            else
                goto poczatek;
            //Wstęp oraz imie naszej postaci
            Print("Podaj swoje imię:", 60);
            imie:
            postac.name = Console.ReadLine();
            Console.Clear();
            if (postac.name == "")
            {
                Print("Musisz podac swoje imie");
                goto imie;
            }
                Console.WriteLine("A więc twoje imie to {0}, grubo",postac.name);

            Console.ReadKey();
            Console.Clear();


            //Rozdział 1
            Console.WriteLine("Rozdział 1");
            Console.WriteLine("Misja");
            Console.ReadKey();
            Console.Clear();


            //Wstęp
            Console.WriteLine(
                "Kurczę, nienawidzę moich studiów. Zaraz mam sesję, nic nie umiem, w pracy szef krzyczy, a najgorsze, że mamie będzie smutno jak nie zdam");
            Console.ReadKey();
            Console.WriteLine("Co mógłbym zrobić, żeby zdać? Ciekawe co teraz wpadnie mi do głowy");
            Console.ReadKey();
            Console.WriteLine("(teraz trzeba napisać myśl, która przyjdzie do głowy)");
            string input = Console.ReadLine();

            Console.WriteLine(input + "" + " Faktycznie fajna myśl.");
            Console.ReadKey();
            Console.WriteLine(
                "Szkoda że przez zniewolenie technologiczne spowodowane rewolucją przemysłową, jestem uzależniony od mediów społecznościowych co spowodowało, że mój mózg nie jest w stanie zapamiętać tej informacji, ponieważ jest przyzwyczajony do ciągłego czytania kompletnie nowych postów");
            Console.ReadKey();
            Console.Write("Hmm, najlepszą opcją będzie teraz zobaczenie czy nie ma czegoś nowego na facebooku");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("(konsumuje informacje przez następne 16 minut");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                "(krzyczy na głos) COOOOOO???? TO IZRAEL JEST ODPOWIEDZIALNY ZA ZNISZCZENIE USS LIBERTY??");
            Console.ReadKey();
            //Roboczo to co mówi tata będzie się zaczynać od ">"
            Console.WriteLine(">" + postac.name +
                              " cholerny kryjanie i mnie obudziłeś tym krzykiem, a taki mecz oglądałem");
            Console.ReadKey();
            Console.WriteLine(">Jak już tu jestem to opowiedz mi o tej izraelskiej zbrodnii, bo mnie zaciekawiłeś.");
            Console.ReadKey();

            //
            //tutaj będzie wybór 
            //

            Console.WriteLine(">Cholerni żydzi. Niestety mój kochany " + postac.name +
                              ", nie masz wpływu na to, czy izrael kiedyś odpowie za swoje zbrodnie.");
            Console.ReadKey();
            Console.WriteLine("Na szczęście masz wypływ na to czy będę pod wpływem.");
            Console.ReadKey();
            Console.WriteLine("Skocz tacie po piwko");
            Console.Clear();
        }

        public static void Print(string text, int speed = 40)
        {
          foreach (char c in text)
          {
            System.Console.Write(c);
            System.Threading.Thread.Sleep(speed);
          }
          System.Console.WriteLine();

        }
    }
  
}
