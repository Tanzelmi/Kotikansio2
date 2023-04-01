using System;

namespace _6_C_Perus_Kolmion_pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // Kolmion ala lasketaan kaavasta A=ah/2 missä a on kanta ja h on korkeus.
            // Laadi ohjelma, joka saa syöttötietoina kannan ja korkeuden la laskee kolmion pinta-alan.

            Console.Write(" Anna kolmion kanta: ");
            int strain = int.Parse(Console.ReadLine());

            Console.Write(" Anna kolmion korkeus: ");
            int height = int.Parse(Console.ReadLine());

            double result = (strain * height) / 2d;

            Console.WriteLine($" Kolmion korkeus on: {result} ");


        }
    }
}
