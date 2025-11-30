using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina pe ce pozitie se afla numarul a dintr-o secventa de n numere.");
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        int n = Citire("n");
        if(n<=0)
        {
            Console.WriteLine("n trebuie sa fie un numar pozitiv.");
            n=Citire("n");
        }

        Console.Write("Introduceti numarul cautat (a): ");
        int a = Citire("a");

        int pozitie = -1;

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int numar = Citire("numar");

            if (numar == a)
            {
                pozitie = i;
                break;
            }
        }

        Console.WriteLine($"Numarul {a} se afla pe pozitia: {pozitie}.");
    }
    static int Citire(string n)
    {
        while(true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduceti un numar valid intreg : ");
                Citire(n);
            }
        }
    }
}