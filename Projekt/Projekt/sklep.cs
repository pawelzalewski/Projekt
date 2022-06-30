namespace Projekt
{
    public class Sklep
    {
        public string Pierwszy_zakup;
        public string Drugi_zakup;

        public string lista_zakupow()
        {
            return Pierwszy_zakup + " oraz " + Drugi_zakup;
        }
    }
}