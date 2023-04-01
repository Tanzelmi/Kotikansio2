using System;

namespace _19_C_Valinta_Lämpötila_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // Tee ohjelma, joka kysyy käyttäjältä lämpötilan Fahrenheit-asteet ja muuntaa sen Celsius-asteiksi ja tulostaa näyttöön. Celcius -> Fahrenheit muunnoskaava on
            // C = (5 / 9) * (F - 32)
            // jossa C on Celsius-asteet ja F on Fahrenheit-asteet.
            // Muokkaa ohjelma siten, että ensin kysytään lämpötila ja seuraavaksi kysytään mihin muotoon lämpötila muunnetaan.
            // Lisäksi Fahrenheit -> Celcius muunnoskaava:
            // F = C * 9 / 5 + 32


            // Console.WriteLine("Anna lämpötila Fahrenhit asteina:: ");
            //  double fahrenheit = double.Parse(Console.ReadLine());
            //  double celsius;

            // celsius = ((fahrenheit - 32) / 1.8);

           
           // Console.WriteLine($" Antamasi lämpötila on celsius asteina {celsius}");
           
            Console.WriteLine("Anna lämpötila: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine(" Mihin muotoon haluat muuntaa lämpötilan: Celsius = C vai Fahrenheit = F");
            char targetTemperature = char.Parse(Console.ReadLine());

            char celsius = 'C';
            char fahrenheit = 'F';

            if (targetTemperature = ) ;



        }
    }
}
