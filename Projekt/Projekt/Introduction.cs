using System;

namespace Projekt
{
    public class Introduction
    {
        public static void Intro()
        {
            //Rozdział 1
            Program.Print("Rozdział 1");
            Program.Print("Misja");
            Console.ReadKey();
            Console.Clear();
            Program.Print(
                "Kurczę, nienawidzę moich studiów. Zaraz mam sesję, nic nie umiem, w pracy szef krzyczy, a najgorsze, że mamie będzie smutno jak nie zdam");

            Console.ReadKey();
            Program.Print("Co mógłbym zrobić, żeby zdać? Ciekawe co teraz wpadnie mi do głowy");
            
            Program.Print("(teraz trzeba napisać myśl, która przyjdzie do głowy)");
            string input = Console.ReadLine();

            Program.Print(input + "" + " Faktycznie fajna myśl.");
            Console.ReadKey();
            Program.Print(
                "Szkoda że przez zniewolenie technologiczne spowodowane rewolucją przemysłową, jestem uzależniony od mediów społecznościowych co spowodowało, że mój mózg nie jest w stanie zapamiętać tej informacji, ponieważ jest przyzwyczajony do ciągłego czytania kompletnie nowych postów");

            Console.ReadKey();
            Program.Print("Hmm, najlepszą opcją będzie teraz zobaczenie czy nie ma czegoś nowego na facebooku");
            Console.ReadKey();
            Console.Clear();
            Program.Print("(konsumuje informacje przez następne 16 minut");
            Console.ReadKey();
            Console.Clear();
            Program.Print(
                "(krzyczy na głos) COOOOOO???? TO IZRAEL JEST ODPOWIEDZIALNY ZA ZNISZCZENIE USS LIBERTY??");

            Console.ReadKey();

            //Roboczo to co mówi tata będzie się zaczynać od ">"
            Program.Print(">" + Program.postac.name +
                          " cholerny kryjanie i mnie obudziłeś tym krzykiem, a taki mecz oglądałem");
            Console.ReadKey();
            Program.Print(">Jak już tu jestem to opowiedz mi o tej izraelskiej zbrodnii, bo mnie zaciekawiłeś.");
            Console.ReadKey();

            //
            //tutaj będzie wybór 
            //

            Program.Print(">Cholerni żydzi. Niestety mój kochany " + Program.postac.name +
                          ", nie masz wpływu na to, czy izrael kiedyś odpowie za swoje zbrodnie.");
            Console.ReadKey();
            Program.Print("Na szczęście masz wypływ na to czy będę pod wpływem.");
            Console.ReadKey();
            Program.Print("Skocz tacie po piwko");
            Console.Clear();
        }
    }
}