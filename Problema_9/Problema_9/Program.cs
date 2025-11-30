using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul verifica daca o secventa de n numere este monotona.");
        int n;
        Console.WriteLine("Introduceti numarul de elemente n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Introduceti un numar natural valid (n > 0): ");
        }

        bool esteCrescatoare = true;
        bool esteDescrescatoare = true;
        int ?previousNumber = null;

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            int numar;
            Console.Write($"Numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.Write("Introduceti un numar valid: ");
            }

            if(previousNumber.HasValue)
            {
                if (numar < previousNumber.Value)
                {
                    esteCrescatoare = false;
                }

                if (numar > previousNumber.Value)
                {
                    esteDescrescatoare = false;
                }
            }
            previousNumber = numar;
        }

        if (esteCrescatoare)
        {
            Console.WriteLine("Secventa este monoton crescatoare.");
        }
        else
        {
            if (esteDescrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }
        }

    }
}