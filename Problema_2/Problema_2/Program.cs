using System;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina cate elemente sunt negative, pozitive si nule dintr-o secventa de n numere.");
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        int n = Citire("n");
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente trebuie sa fie un numar pozitiv.Introduceti un numar pozitiv:");
            n = Citire("n");
        }
        int nrnegative = 0, nrpositive = 0, nrzero = 0;

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int numar = Citire("numar");
            if (numar > 0)
                nrpositive++;
            else
            {
                if(numar < 0)
                    nrnegative++;
                else
                    nrzero++;
            }
        }

        Console.WriteLine($"In secventa sunt {nrpositive} numere pozitive.");
        Console.WriteLine($"In secventa sunt {nrnegative} numere negative.");
        Console.WriteLine($"In secventa sunt {nrzero} numere nule.");
    }

    static int Citire(string s)
    {
        while (true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"Introduceti un numar intreg valid pentru {s}: ");
                return Citire(s);
            }
        }
    }
}
