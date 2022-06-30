using System;
using System.Runtime.InteropServices;

namespace Projekt
{
    public class Chapter_1
    {
        public static void Wyprawa()
        {
            string title = @" __    __ __ __ ____  ____   ____ __    __  ____ 
|  |__|  |  |  |    \|    \ /    |  |__|  |/    |
|  |  |  |  |  |  o  )  D  )  o  |  |  |  |  o  |
|  |  |  |  ~  |   _/|    /|     |  |  |  |     |
|  `  '  |___, |  |  |    \|  _  |  `  '  |  _  |
 \      /|     |  |  |  .  \  |  |\      /|  |  |
  \_/\_/ |____/|__|  |__|\_|__|__| \_/\_/ |__|__|
                                                 
";
                                                                                       
            Console.WriteLine(title);
            Program.Print(
                "Wyszedłeś do sklepu. W drodze zauważasz z daleka, że w twoją stronę kieruje się dziwnie zachowujący się bezdomny mężczyzna.");
            Program.Print("Co robisz w tej sytuacji?");
            a:
            Console.WriteLine(
                "==================================================================");
            Console.WriteLine(
                "| (Z)mieniasz kierunek     (I)dziesz w kierunku osoby bezdomnej  |");
            Console.WriteLine(
                "==================================================================");
            string odp = Console.ReadLine();
            if (odp.ToLower() == "z" || odp.ToLower() == "zmieniam kierunek")
            {
                Program.Print("Skręcasz w ciemną uliczkę, nic nie widzisz.", 40);
                Program.Print(
                    "Idziesz przed siebie potykając się o leżących na ziemii bezdomnych i porozrzucane śmieci i nagle wpadasz na jednego z osiedlowych gitowców.");
                Console.ReadLine();
                Console.Clear();
                Program.Print("\"Co jest? Masz jakiś problem?\"", 40);
                c:
                Console.WriteLine("=====================================================================");
                Console.WriteLine("| (N)ie, przepraszam, ale jest       (T)ak, mam problem, stoisz mi");
                Console.WriteLine("|  ciemno i nic nie widziałem         na drodze                     |");
                Console.WriteLine("=====================================================================");
                string odp1 = Console.ReadLine();
                if (odp1.ToLower() == "n" || odp.ToLower() == "nie")
                {
                    Program.Print("W takim razie JA mam problem, wynoś się z mojego terenu!");
                    Console.ReadKey();
                    Bitka("Dresiarz", 8, 10);
                }
                else if (odp1.ToLower() == "t" || odp1.ToLower() == "tak")
                {
                    Program.postac.psychika++;
                    Console.WriteLine("\"Tak, stoje na MOJEJ drodze. Wynocha!\"");
                    Console.ReadKey();
                    Bitka("Dresiarz", 5, 10);
                }
                else
                    goto c;
            }
            else if (odp.ToLower() == "i" || odp.ToLower() == "idę prosto")
            {
                Bezdomny();
            }
            else
            {
                Console.Clear();
                goto a;
            }
        }

        static private Random rand = new Random();

        public static void Bitka(string nazwa, int moc, int zycie)
        {
            string n = nazwa;
            int p = moc;
            int h = zycie;

            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine("Wściekły " + n + " " + p + "/" + h);
                Console.WriteLine("==========================");
                Console.WriteLine("| (A)tak   (B)roń się    |");
                Console.WriteLine("  (U)ciekaj              |");
                Console.WriteLine("==========================");
                Console.WriteLine(" Psychika: " + Program.postac.psychika);
                string odp = Console.ReadLine();

                if (odp.ToLower() == "a" || odp.ToLower() == "atak")
                {
                    Console.WriteLine("Uderzasz " + n + ". Po chwili dostajesz cios od niego");
                    int d = p / 2 - Program.postac.psychika / 4;
                    if (d < 0)
                        d = 0;
                    int a = rand.Next(0, Program.postac.moc) + rand.Next(1, 5);
                    Console.WriteLine("Tracisz " + d + " punktów psychiki, i zadajesz mu " + a + " obrażeń");
                    Program.postac.psychika -= d;
                    if (Program.postac.psychika < 0)
                        Program.postac.psychika = 0;
                    h -= a;
                    Console.ReadKey();
                }

                else if (odp.ToLower() == "b" || odp.ToLower() == "obrona")
                {
                    Console.WriteLine("W chwili, gdy " + n +
                                      " przygotowuje się do ciosu, podnosisz pokrywę od śmietnika i bronisz się.");
                    int d = p / 2 - (Program.postac.psychika - 8);
                    if (d < 0)
                        d = 0;
                    int a = rand.Next(0, Program.postac.moc) / 4;
                    Console.WriteLine("Tracisz " + d + " punktów psychiki, i zadajesz mu " + a + " obrażeń");
                    Program.postac.psychika -= d;
                    if (Program.postac.psychika < 0)
                        Program.postac.psychika = 0;
                    h -= a;
                    Console.ReadKey();
                }

                int randomUcieczka = rand.Next(0, 2);
                if (odp.ToLower() == "u" || odp.ToLower() == "ucieczka")
                {
                    if (randomUcieczka == 0)
                    {
                        Console.WriteLine("Podczas gdy próbujesz uciec, " + n + " podcina ci nogę.");
                        int d = p - Program.postac.psychika;
                        if (d < 0)
                            d = 0;
                        Console.WriteLine("Tracisz " + d + " punktów psychiki");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Z niewyobrażalnie wysoką prędkością uciekasz, a " + n +
                                          " poślizguje się na kałuży.");
                        h = 0;
                        Console.ReadKey();
                        // nastepny rozdział
                    }
                }
            }

            Program.Print(n + " zostaje powalony w kałuży, możesz iść dalej...");
            Program.Print("Twoja psychika: ");
            Console.Write(Program.postac.psychika);
            if (Program.postac.psychika == 0)
                Console.WriteLine(
                    "Twoja psychika spadła do 0, jeśli nie kupisz w sklepie czegoś na odnowienie jej, możesz przegrać.");
            Console.ReadKey();
        }

        public static void Bezdomny()
        {
            Program.Print("Napotykasz na swojej drodzę bezdomnego.");
            Program.Print(
                "\"Dzień dobry  księciuniu, *podaje dłoń*, czy nie miałbyś może użyczyć złoty osiemdziesiąt?\"");
            b:
            Console.WriteLine(
                "========================================================================================");
            Console.WriteLine(
                "| (W) jakim celu Pan potrzebuje?     (D)obrze, *wyjmujesz portfel i wręczasz 2 złote*. |");
            Console.WriteLine(
                "|       (I)dź Pan do roboty, a nie o pieniądze Pan żebrzesz!                           |");
            Console.WriteLine(
                "=======================================================================================");
            string odp2 = Console.ReadLine();
            if (odp2.ToLower() == "w")
            {
                string odpowiedz;
                int losowaOdpowiedz = rand.Next(0, 2);
                if (losowaOdpowiedz == 0)
                {
                    odpowiedz = "\"Na chleb\"";
                    Program.Print(odpowiedz);
                    Console.ReadLine();
                    e:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("| (W)łaśnie idę do sklepu,       (N)ie mam pięniędzy    |");
                    Console.WriteLine("|   może Pan isć ze mną,                                |");
                    Console.WriteLine("|    to Panu coś kupię                                  |");
                    Console.WriteLine("=========================================================");
                    string odp3 = Console.ReadLine();
                    if (odp3.ToLower() == "w")
                    {
                        Program.Print("\"W porządku\"");
                        Program.postac.bezdomny = true;
                        Program.Print("Idziesz teraz do sklepu razem z nowym znajomym.");
                        Console.ReadKey();
                    }

                    else if (odp3.ToLower() == "n")
                    {
                        Program.Print("\"Trudno, dziękuję.\"");
                        Console.ReadKey();
                        Program.Print("Mijasz bezdomnego i dziesz dalej do sklepu...");
                    }
                    else
                    {
                        Console.Clear();
                        goto e;
                    }
                }

                else
                {
                    odpowiedz = "\"Na piwo\"";
                    Program.Print(odpowiedz);
                    d:
                    Console.WriteLine("===============================");
                    Console.WriteLine("  (W) takim razie nie.        |");
                    Console.WriteLine("              (D)aj 2 zł      |");
                    Console.WriteLine("===============================");
                    string odp4 = Console.ReadLine();
                    if (odp4.ToLower() == "w")
                    {
                        Program.Print("\"Trudno, miłego dnia\"");
                        Console.ReadKey();
                        Program.Print("Mijasz bezdomnego i idziesz dalej do sklepu...");
                    }

                    else if (odp4.ToLower() == "d")
                    {
                        Program.Print("Bardzo dziękuję, życzę Panu z całego serca miłego dnia!");
                        Console.ReadKey();
                        Program.postac.szansa++;
                        Program.Print("Mijasz bezdomnego i idziesz dalej do sklepu...");
                        Program.Print("Twoja szansa na zdanie wzrostała o 1. Szansa na zdanie: ");
                        Console.Write(Program.postac.szansa);
                    }
                    else
                    {
                        Console.Clear();
                        goto d;
                    }
                }
            }

            else if (odp2.ToLower() == "d")
            {
                Program.Print("Bardzo dziękuję, życzę Panu z całego serca miłego dnia!");
                Console.ReadKey();
                Program.postac.szansa++;
                Program.Print("Mijasz bezdomnego i idziesz dalej do sklepu...");
                Program.Print("Twoja szansa na zdanie wzrostała o 1. Szansa na zdanie: ");
                Console.Write(Program.postac.szansa);
            }

            else if (odp2.ToLower() == "i")
            {
                Program.Print("\"Coś ty powiedział?!\"");
                Program.Print("Bezdomny rzuca się na ciebie.");
                Console.ReadKey();
                Bitka("Bezdomny", 6, 6);
            }
            else
            {
                Console.Clear();
                goto b;
            }
        }
    }
}