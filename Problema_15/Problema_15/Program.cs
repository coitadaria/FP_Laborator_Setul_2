using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina daca o secventa de n numere este bitonica.");
        Console.Write("Introduceti numarul de elemente din secventa (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Va rugam sa introduceti un numar natural valid pentru n: ");
        }
        if (n <= 2)
        {
            Console.WriteLine("O secventa cu mai putin de 3 elemente nu poate fi bitonica.");
            return;
        }
        Console.WriteLine($"Introduceti cele {n} numere:");
        bool esteCrescatoare = false;
        bool esteDescrescatoare = false;
        bool esteBitonica = true;
        bool aInceputCrescator = false;

        Console.Write("Numarul 1: ");
        int primul;
        while (!int.TryParse(Console.ReadLine(), out primul))
        {
            Console.Write("Va rugam sa introduceti un numar natural valid pentru n: ");
        }
        int precedent = primul;
        for (int i = 1; i < n; i++)
        {
            int curent;
            Console.Write($"Numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out curent))
            {
                Console.Write("Va rugam sa introduceti un numar intreg valid: ");
            }
            if (curent > precedent)
            {
                if (esteDescrescatoare)
                {
                    esteBitonica = false;
                }
                esteCrescatoare = true; 
                aInceputCrescator = true;
            }
            else
            {
                if (esteCrescatoare)
                {
                    if (curent < precedent)
                    {
                        esteCrescatoare = false;
                        esteDescrescatoare = true;
                    }
                }
            }
            precedent = curent;
        }
            
        if(esteBitonica && esteDescrescatoare && aInceputCrescator)
        {
            Console.WriteLine("Secventa este bitonica.");
        }
        else
        {
            Console.WriteLine("Secventa NU este bitonica.");
        }
    }
}
