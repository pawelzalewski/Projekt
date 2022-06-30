using System; 
namespace Projekt
{ public class Chapter_3
    { public static void Sklep() 
        {
            Console.WriteLine("Lista Produktów");
            Console.WriteLine("1. Mleko");
            Console.WriteLine("2. Masło ");
            Console.WriteLine("3. Jajka");
            Console.WriteLine("4. Polędwica z kurczaka 10 deko ");
            Console.WriteLine("5. Perła eksport"); 
            Program.Print("Co wybierasz? Stać cię tylko na dwie rzeczy, więc albo zrobisz przykrość mamie, albo tacie");
            Console.WriteLine("=================================");
            Console.WriteLine(); 
            Program.Print("| (1)Mleko    (2) Masło    (3) Jajka   (4) Polędwica z kurczaka 10 deko   (5) Perła eksport |");
            Console.WriteLine();
            Console.WriteLine("=================================");
            string z1 = Console.ReadLine();

            if (z1.ToLower() == "1")
            {
                Program.Sklep.Lista_zakupow += z1; 
            }
           else if (z1.ToLower() == "2")
            {
                
            } 
            else if (z1.ToLower() == "3")
            {
                
            }
            else if (z1.ToLower() == "4")
            {
                
            }
            else if (z1.ToLower() == "5")
            {
                
            }
        }
    }
}