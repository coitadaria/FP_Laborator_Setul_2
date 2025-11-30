using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina cea mai mica si cea mai mare valoare dintr-o secventa de n numere.");
        int n;
        Console.Write("Introduceti numarul de elemente n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Introduceti un numar intreg pozitiv (n > 0): ");
        }

        int minim = int.MaxValue; // Initializam minim cu cea mai mare valoare posibila pe int
        int maxim = int.MinValue;  // Initializam maxim cu cea mai mica valoare posibila pe int

        for (int i = 0; i < n; i++)
        {
            int numar;
            Console.Write($"Introduceti numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.Write("Introduceti un numar intreg: ");
            }

            if (numar < minim)
                minim = numar;

            if (numar > maxim)
                maxim = numar;
        }
        Console.WriteLine($"Cea mai mica valoare din secventa este: {minim}.");
        Console.WriteLine($"Cea mai mare valoare din secventa: {maxim}.");
    }
}