using System;

namespace _12_C_Valinta_Iän_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // 12 C# Valinta: Iän tarkistus
            // tee ohjelma joka kysyy käyttäjältä ikää ja tarkistaa,
            // että se on järkevä(vähintään 0 ja korkeintaan 120).

            bool ageCorrect = false;

            while (ageCorrect == false)
            {
                Console.WriteLine("Syötä ikä: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0;
                int maxAge = 120;

                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Talllennus onnistui ");
                }
                else
                {
                    Console.WriteLine("Arvo ei ole " + "hyväksyttävällä välillä" + $"({ minAge}-{ maxAge})");
                }
            }

        }
    }
}
