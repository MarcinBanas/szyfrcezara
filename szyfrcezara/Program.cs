using System;
using System.Linq;

namespace szyfrcezara
{
    class Program
    {
        public const int Alphabet = 'z' - 'a' + 1;
        public static string Szyfruj(string wyraz, int przesuniecie)
        {
            return string.Concat(wyraz.Select(x => (char)('a' + (x - 'a' + przesuniecie) % Alphabet)));
        }
        public static string Rozszyfruj(string Wyraz, int przesuniecie)
        {
            return Szyfruj(Wyraz, Alphabet - przesuniecie);
        }
        static void Main(string[] args)
        {
            string wyraz;
            int przesuniecie;
            Console.WriteLine("Podaj slowo:");
            wyraz = Console.ReadLine();
            Console.WriteLine("Podaj klucz:");
            przesuniecie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nCo chcesz zrobić");
            Console.WriteLine("\n1 - Szyfrować");
            Console.WriteLine("2 - Deszyfrować\n");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Console.WriteLine(Szyfruj(wyraz, przesuniecie));
                    break;
                case 2:
                    Console.WriteLine(Rozszyfruj(wyraz,przesuniecie));
                    break;
            }
        }
    }
}
