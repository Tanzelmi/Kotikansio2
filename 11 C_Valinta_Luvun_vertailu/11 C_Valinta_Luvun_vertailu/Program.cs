using System;

namespace _11_C_Valinta_Luvun_vertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Anna luku ");
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                Console.WriteLine("Arvo on 0 ");
            }
            else if (value > 0)
            {
                Console.WriteLine("Arvo on suurenpi kuin 0 ");
            }
            else
            {
                Console.WriteLine("Arvon on pienenpi kuin 0");
            }
        }
    }
}
