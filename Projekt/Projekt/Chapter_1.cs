using System;

namespace Projekt
{
    public class Chapter_1
    {
        static Random rand = new Random();

        public static void PierwszaAkcja()
        {
            Program.Print("Okazuje się, że zbliża sie sesja, co robisz?", 60);
            Interakcja();
        }

        public static void Interakcja()
        {
            {
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.WriteLine("| (I)dź sie uczyc    (W)ywalone |");
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                string odp = Console.ReadLine();
                if (odp.ToLower() == "i" || odp.ToLower() == "idz sie uczyc")
                {
                    //nauka
                    int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                    Console.WriteLine("Swietnie, twoja szansa na zdanie wzrosla o " + szansa + "%");
                    Program.postac.szansa += szansa;
                    Console.WriteLine("Twoja szansa na zdanie to: " + Program.postac.szansa + "%");
                    Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                    Console.ReadKey();
                }
                else if (odp.ToLower() == "w" || odp.ToLower() == "wywalone")
                {
                    //wywalone
                    Console.WriteLine("Co w takim razie zamierzasz teraz zrobić");
                    string zamiar = Console.ReadLine();
                    Console.WriteLine("Dobrze, " + zamiar +
                                      " brzmi interesująco, ale czy napewno uwazasz ze nie jest lepiej sie pouczyc? Sesja lada chwila, a ty nic nie umiesz.");
                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    Console.WriteLine("| T(ak)    (N)ie");
                    Console.WriteLine("==============================");
                    Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                    string odp1 = Console.ReadLine();
                    if (odp1.ToLower() == "t" || odp1.ToLower() == "tak")
                    {
                        int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                        Program.postac.szansa -= szansa;
                        Console.WriteLine("Ok, niestety, ale twoja szansa na zdanie zmalała o " + szansa + "%");
                        Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                        Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        Console.ReadKey();
                    }
                    else if (odp1.ToLower() == "n" || odp1.ToLower() == "nie")
                    {
                        int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                        Console.WriteLine("Swietnie, twoja szansa na zdanie wzrosla o " + szansa + "%");
                        Program.postac.szansa += szansa;
                        Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                        Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        Console.ReadKey();
                    }
                }
            }
            Console.Clear();
        }
    }
}