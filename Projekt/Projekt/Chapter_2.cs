using System; 
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Projekt

{ public class Chapter_2
    { public static void Osiedlowy() 
        {
            Console.Clear();
            Program.Print("W końcu dotarłeś do sklepu.");
            Console.WriteLine(@"
 #     #                                                    
 ##   ## # #####    ##   #####  ###### #      #    #   ##   
 # # # # # #    #  #  #  #    # #      #      #   #   #  #  
 #  #  # # #    # #    # #####  #####  #      ####   #    # 
 #     # # #####  ###### #    # #      #      #  #   ###### 
 #     # # #   #  #    # #    # #      #      #   #  #    # 
 #     # # #    # #    # #####  ###### ###### #    # #    # 
");
            Console.ReadKey();
            Console.Clear();
            Program.Print("*Wchodzisz do sklepu*");
            Program.Print("Dzień dobry Pani Aniu!");
            Program.Print("Pani Ania: Dzień dobry, co podać?");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lista Produktów");
            Console.WriteLine("1. Mleko");
            Console.WriteLine("2. Jajka");
            Console.WriteLine("3. Perła eksport"); 
            Console.WriteLine("Stać cię tylko na dwie rzeczy.");
            Console.WriteLine("");
            Program.Print("Jaki pierwszy produkt wybierasz?");
            Console.WriteLine("============================================================");
            Console.WriteLine(); 
            Console.WriteLine("| (1) Mleko     (2) Jajka    (3) Perła eksport |");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            string z1 = Console.ReadLine();
            Console.Clear();
            Program.Print("Jaki drugi produkt wybierasz?");
            Console.WriteLine("============================================================");
            Console.WriteLine(); 
            Console.WriteLine("| (1) Mleko     (2) Jajka    (3) Perła eksport |");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            string z2 = Console.ReadLine();
            
            if (z1.ToLower() == "1")
            {
                z1 = "Mleko";
            }
            else if (z1.ToLower() == "2")
            {
                z1 = "Jajka";
            }
            else if (z1.ToLower() == "3")
            {
                z1 = "Perła eksport";
            }
            
            if (z2.ToLower() == "1")
            {
                z2 = "Mleko";
            }
            else if (z2.ToLower() == "2")
            {
                z2 = "Jajka";
            }
            else if (z2.ToLower() == "3")
            {
                z2 = "Perła eksport";
            }
            
            Console.Clear();
            
            List<Sklep> Lista = new List<Sklep>();

            Lista.Add(new Sklep
            {
                Pierwszy_zakup = z1,
                Drugi_zakup = z2
            });
            
            
            foreach (Sklep zakup in Lista)
            {
                Console.WriteLine(zakup.lista_zakupow());
            }
            
            Console.ReadLine();
            Console.Clear();
            
            Program.Print("Mam co chciałem, czas na powrót do domu");
            Console.ReadKey();
            Console.Clear();

            Program.Print("*Wchodzisz do domu, a w progu już czekają na ciebie rodziciele.*");
            Console.ReadKey();
            
            Program.Print("Mama: Pokaż co kupiłeś");
            Program.Print("");
            Console.ReadKey();
            
            if ((z1 == "Mleko") & (z2 == "Mleko"))
            {
                Program.Print("Mama: Po co kupiłeś dwa razy to samo?");
                Program.Print("Tata: Nie możesz zapamiętać prostej listy?");
            }
            else if ((z1 == "Jajka") & (z2 == "Jajka"))
            {
                Program.Print("Mama: Po co kupiłeś dwa razy to samo?");
                Program.Print("Tata: Nie możesz zapamiętać prostej listy?");
            }
            else if ((z1 == "Perła eksport") & (z2 == "Perła eksport"))
            {
                Program.Print("Mama: Coś ty narobił!?");
                Program.Print("Tata: Kocham cię synek! Akurat Bayern z Robercikiem gra!");
            }
            else if ((z1 == "Mleko") & (z2 == "Jajka"))
            {
                Program.Print("Mama: Brawo synuś!");
                Program.Print("Tata: Przykro mi, że nie traktujesz mnie poważnie...");
            }
            else if ((z1 == "Mleko") & (z2 == "Perła eksport"))
            {
                Program.Print("Mama: Mogło być gorzej...");
                Program.Print("Tata: Kocham cię synek!");
                
            }
            else if ((z1 == "Jajka") & (z2 == "Mleko"))
            {
                Program.Print("Mama: Brawo synuś!");
                Program.Print("Tata: Przykro mi, że nie traktujesz mnie poważnie...");
            }
            else if ((z1 == "Jajka") & (z2 == "Perła eksport"))
            {
                Program.Print("Mama: Mogło być gorzej...");
                Program.Print("Tata: Kocham cię synek!");
            }
            else if ((z1 == "Perła eksport") & (z2 == "Mleko"))
            {
                Program.Print("Mama: Mogło być gorzej...");
                Program.Print("Tata: Kocham cię synek!");
            }
            else if ((z1 == "Perła eksport") & (z2 == "Jajka"))
            {
                Program.Print("Mama: Mogło być gorzej...");
                Program.Print("Tata: Kocham cię synek!");
            }

            Console.ReadKey();
            Console.WriteLine("");
            Program.Print("Mama: A teraz idź się uczyć, masz w końcu egzaminy.");
            Program.Print("Tata: Słuchaj się matki jak coś mówi!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}