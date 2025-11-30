using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul verifica daca o secventa de n numere este crescatoare.");
        int n;
        Console.WriteLine("Introduceti numarul de elemente n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Introduceti un numar valid (n > 0): ");
        }

        bool esteCrescatoare = true; // presupunem ca secventa este crescatoare si demonstam contrariul
        int previousNumber = int.MinValue; // initializam cu cea mai mica valoare posibila pe int

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            int numar;
            Console.Write($"Numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.Write("Introduceti un numar valid: ");
            }

            if (numar < previousNumber)
            {
                esteCrescatoare = false;
            }

            previousNumber = numar;
        }

        if (esteCrescatoare)
        {
            Console.WriteLine("Secventa este crescatoare.");
        }
        else
        {
            Console.WriteLine("Secventa NU este crescatoare.");
        }
    }
}