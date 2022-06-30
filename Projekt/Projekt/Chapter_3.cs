using System;

namespace Projekt
{
    public class Chapter_3
    {
        public static void Deszcz()
        {
            string title = @" ______  _______ _______ _______ _______ _______ 
(  __  \(  ____ \  ____ Y ___   )  ____ Y ___   )
| (  \  ) (    \/ (    \|/   )  | (    \|/   )  |
| |   ) | (__   | (_____    /   ) |         /   )
| |   | |  __)  (_____  )  /   /| |        /   / 
| |   ) | (           ) | /   / | |       /   /  
| (__/  ) (____/Y\____) |/   (_/\ (____/\/   (_/\
(______/(_______|_______)_______/_______/_______/
                                                 
";
            Console.WriteLine(title);
            Program.Print("Wracasz do pokoju, widzisz, że za oknem zaczyna padać deszcz " +
                          "i zastanawiasz się czy pora na naukę " +
                          "czy na coś innego...", 40);
            b:
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("| (P)ora na nauke    (Z)agraj w grę |");
            Console.WriteLine();
            Console.WriteLine("=====================================");
            string odp = Console.ReadLine();
            if (odp.ToLower() == "p" || odp.ToLower() == "nauka")
            {
                //tu bedzie nauka
                Program.postac.szansa += 20;
                Program.Print("Świetnie! Twoja szansa na zdanie wzrosła o 20%!", 40);
                Program.Print("Szansa na zdanie: ", 40);
                Console.Write(Program.postac.szansa + "%");
                Console.WriteLine();
                Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                Console.ReadKey();
            }
            else if (odp.ToLower() == "z" || odp.ToLower() == "gra")
            {
                Gra();
                Console.Clear();
                Program.postac.szansa -= 5;
                Program.Print("Niestety, ale twoja szansa na zdanie spadła o 5%.");
                Program.Print("Szansa na zdanie: ", 40);
                Console.Write(Program.postac.szansa + "%");
                Console.WriteLine();
                Program.Print("Wciśnij dowolny przycisk, aby kontynuować...", 40);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                goto b;
            }

            
        }

        static void Gra()
        {
            Console.WriteLine("Naciśnij dowolny przycisk aby zagrać w grę...");
            Console.ReadKey();

            // "wąż"
            char ch = '*';
            bool gameLive = true;
            ConsoleKeyInfo consoleKey;


            int x = 0, y = 2;
            int dx = 1, dy = 0;
            int szerokoscKonsoli = 80;
            int wysokoscKonsoli = 25;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            int opoznienie = 50;

            do // do czasu kliknięcia 'q'
            {
                ConsoleColor cc = Console.ForegroundColor;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Poruszaj się strzałkami lub 'h', 'j', 'k', 'l' w lewo, do dołu, do góry i w prawo.");
                Console.WriteLine("Naciśnić 'c' aby wyczyścić pole gry, 'q' aby zakończyć grę.");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = cc;

                if (Console.KeyAvailable)
                {
                    consoleKey = Console.ReadKey(true);
                    switch (consoleKey.Key)
                    {
                        case ConsoleKey.C:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            break;
                        case ConsoleKey.UpArrow: //Góra
                            dx = 0;
                            dy = -1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case ConsoleKey.K: //Góra
                            dx = 0;
                            dy = -1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case ConsoleKey.DownArrow: //Dół
                            dx = 0;
                            dy = 1;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case ConsoleKey.J: //Dół
                            dx = 0;
                            dy = 1;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case ConsoleKey.LeftArrow: //Lewo
                            dx = -1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case ConsoleKey.H: //Lewo
                            dx = -1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case ConsoleKey.RightArrow: //Prawo
                            dx = 1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case ConsoleKey.L: //Prawo
                            dx = 1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case ConsoleKey.Q: //Koniec
                            gameLive = false;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }

                Console.SetCursorPosition(x, y);

                x += dx;
                if (x > szerokoscKonsoli)
                    x = 0;
                if (x < 0)
                    x = szerokoscKonsoli;

                y += dy;
                if (y > wysokoscKonsoli)
                    y = 2;
                if (y < 2)
                    y = wysokoscKonsoli;

                Console.SetCursorPosition(x, y);
                Console.Write(ch);

                System.Threading.Thread.Sleep(opoznienie);
            } while (gameLive);
        }

        static Random rand = new Random();

        static void Nauka()
        {
            Console.WriteLine("Siadasz do nauki. Wybierz, którego przedmiotu zamierzasz się uczyć.");
            Console.WriteLine("================================================================");
            Console.WriteLine("(A)naliza matematyczna          (M)atematyka dyskretna         |");
            Console.WriteLine("================================================================");
            string odp = Console.ReadLine();
            if (odp.ToLower() == "a")
            {
                int random = rand.Next(14, 30);
                Console.WriteLine("*Uczysz się analizy matematycznej.*");
                Program.postac.szansa += random;
                Console.ReadKey();
            }
            else if (odp.ToLower() == "m")
            {
                int random = rand.Next(14, 30);
                Console.WriteLine("*Uczysz się matematyki dyskretnej*");
                Program.postac.szansa += random;
                Console.ReadKey();
            }
        }
    }
}