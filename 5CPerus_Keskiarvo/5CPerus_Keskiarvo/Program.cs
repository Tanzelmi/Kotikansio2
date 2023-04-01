using System;

namespace _5CPerus_Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.Write("Anna luku 1 ");
            int value1 = int.Parse(Console.ReadLine());
            
            Console.Write("Anna luku 2 ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku 3 ");
            int value3 = int.Parse(Console.ReadLine());

            double resultError = (value1 + value2 + value3) / 3; // laskeminnen kokonais luvulla, ei desimaaleja (integer)
            double result = (value1 + value2 + value3) / 3d; // d lisäys laskuun tällöin arvo on doublemuotoa, lasku voidaan tehdä molemmilla (välillä) muodoilla

            Console.WriteLine($"Keski arvo on {resultError} - Virhe!");
            Console.WriteLine($"Keskiarvo on {result} ");
        }
    }
}
