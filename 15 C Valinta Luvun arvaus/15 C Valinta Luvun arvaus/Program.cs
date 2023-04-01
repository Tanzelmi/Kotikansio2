using System;

namespace _15_C_Valinta_Luvun_arvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
           

            int target = 15;
            bool corretGuess = false;
            {
                Console.WriteLine(" Arvaa luku (0-20): ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == target)
                {
                    Console.WriteLine("Oikea arvaus!");
                }
                
                else if (guess < target) // arvaus liian pieni
                {
                    Console.WriteLine("Liian pieni");
                }
                else // Arvaus liian suuri
                {
                    Console.WriteLine("Liian suuri");
                }
            }

        }

    }
}
