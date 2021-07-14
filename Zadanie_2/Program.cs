using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlugoscPobytu, wiek;

            while (true)
            {
                Console.WriteLine("Ile masz lat?");
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek > 0) break;
                else Console.WriteLine("Nieprawidlowy wiek!");
            }
            while (true)
            {
                Console.WriteLine("Na ile nocy chcesz zostać?");
                dlugoscPobytu = Convert.ToInt32(Console.ReadLine());
                if (dlugoscPobytu > 0) break;
                else Console.WriteLine("Nieprawidlowy ilość nocy!");
            }

            WyliczCene(wiek, dlugoscPobytu);

            Console.WriteLine("Cena za {0} nocy wyniesie {1}", dlugoscPobytu, WyliczCene(wiek, dlugoscPobytu));

            Console.ReadKey();
        }

        private static double WyliczCene(int wiekOsoby, int dlugoscPobytu)
        {
            double cena;

            if (wiekOsoby > 18)
            {
                if (dlugoscPobytu >= 2 && dlugoscPobytu < 5) cena = dlugoscPobytu * 180;
                else if (dlugoscPobytu >= 5) cena = dlugoscPobytu * 150;
                else cena = 200;

                if (wiekOsoby >= 65) cena = cena * 0.9;
            }
            else cena = dlugoscPobytu * 100;

            return cena;
        }
    }
}
