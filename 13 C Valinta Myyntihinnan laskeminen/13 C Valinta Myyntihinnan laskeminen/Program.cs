using System;

namespace _13_C_Valinta_Myyntihinnan_laskeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tuotteen myyntihinnasta annetaan alennusta 10% ja,
            // jos hinta on yli 100 euroa alennus on 25%. Tee ohjelma joka laskee annetusta hinnasta tuotteen
            // lopullisen myyntihinnan

            Console.WriteLine();

            Console.Write("Syötä hinta: ");
            double price = double.Parse(Console.ReadLine());
            double discountedPrice;

            if (price > 100)
            {
                discountedPrice = price * 0.75;
            }
            else
            {
                discountedPrice = price * 0.90;
            }

            Console.WriteLine($" Alennettu hinta on {discountedPrice} euroa");
        }

    }
}
