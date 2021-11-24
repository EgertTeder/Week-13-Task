using System;

namespace Root_rakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kausta nimi:");
            string kasutajaKaust = "Samples";

            if (kasutajaKaust == "Samples")
            {
                Console.WriteLine($"{kasutajaKaust} already exists in Samples");
            }
        }
    }
}
