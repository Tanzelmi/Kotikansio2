using System;

namespace _14_C_Valinta_Parillinen_vai_pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // Tee ohjelma, joka ilmoittaa onko käyttäjän antama luku parillinen vai pariton
            // Tässä tarvitsette % -operaattoria ja hieman selvittää, kuinka parillisuus saadaan selvillä ohjelmoinnissa.

            Console.Write("Anna luku: ");
            int number = int.Parse(Console.ReadLine());

            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(" Luku on parillinen");
                }
                else
                {
                    Console.WriteLine(" Luku on pariton");
                }
            }

        }
    }
}