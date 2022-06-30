using System;

namespace Projekt
{
    public class Introduction
    {
        public static void Intro()
        {
            //Rozdział 1
            Program.Print("Rozdział 1");
            string title = @"___  ____     _       
|  \/  (_)   (_)      
| .  . |_ ___ _  __ _ 
| |\/| | / __| |/ _` |
| |  | | \__ \ | (_| |
\_|  |_/_|___/ |\__,_|
            _/ |      
           |__/       
";
            Console.WriteLine(title);
            Console.ReadKey();
            Console.Clear();
            Program.Print(
                "Przyszedł ten czas w życiu studenta. Sesja zbliża sie nieubłaganie a ty, nie ma w tym zaskoczenia, nic nie umiesz. Wiadomo, nie miałeś czasu sie uczyć bo ciężko pracujesz.\n Jednak wypadałoby się wziąć za nauke. W przeciwnym razie mógłbyś nie zdać, a mamie byłoby bardzo smutno.");

            Console.ReadKey();
            Program.Print("Co mógłbym zrobić, żeby zdać? - myślisz sobie licząc że coś mądrego wpadnie ci do głowy?");
            
            Program.Print("(teraz trzeba napisać myśl, która przyjdzie ci do głowy)");
            string input = Console.ReadLine();

            Program.Print(input + "" + ". Faktycznie fajna myśl, ale czy aby na pewno ci to w czymś pomoże?");
            Console.ReadKey();
            Program.Print(
                "Gdybyś tylko mógł zapamiętać tą myśl. Szkoda że jesteś uzależniony od mediów społecznościowych i ich ciągłego zalewu informacjami. Gdyby nie one może nie miałbyś takich problemów z pamięcią.");

            Console.ReadKey();
            Program.Print("Decydujesz że w zaistniałej sytuacji najlepszą opcją jest przegląd facebooka. Może tam znajdziesz jakąś inspiracje do nauki?");
            Console.ReadKey();
            Console.Clear();
            Program.Print("(16 minut później)");
            Console.ReadKey();
            Console.Clear();
            Program.Print(
                "Ty:CO? ZNISZCZENIE USS LIBERTY?! KTO ZA TYM WSZYSTKIM STOI?");

            Console.ReadKey();

            
            Program.Print("Tata:" + Program.postac.name +
                          ", obudziłeś mnie tym krzykiem, a taki mecz oglądałem");
            Console.ReadKey();
            Program.Print("Tata:Co takiego wyczytałeś w tym internecie, że aż tak tobą wstrząsneło?");
            Console.ReadKey();

            //
            //tutaj będzie wybór 
            //

            Program.Print("Tata:Zaś ten statek. Niestety mój kochany " + Program.postac.name +
                          ", nie masz wpływu na takie rzeczy.");
            Console.ReadKey();
            Program.Print("Na szczęście masz wypływ na to czy będę pod wpływem.");
            Console.ReadKey();
            Program.Print("Tata:Skocz tacie po piwko");
            Console.Clear();
            Console.ReadKey();
        }
    }
}