using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul calculeaza suma si produsul numerelor de la 1 la n.");
        Console.WriteLine("Introduceti numarul n: ");
        int n = Citire("n");
        
        long suma , produs = 1;

        suma = n * (n + 1) / 2;

        for (int i = 1; i <=n; i++)
        {
            produs *= i;
        }

        Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}.");
        Console.WriteLine($"Produsul (factorialul) numerelor de la 1 la {n} este: {produs}.");
    }

    static int Citire(string s)
    {
        while (true)
        {
            try
            {
                int a=int.Parse(Console.ReadLine());
                if(a<=0)
                {
                    Console.WriteLine($"Introduceti un numar pozitiv pentru {s}: ");
                    return Citire(s);
                }
                return a;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Introduceti un numar intreg valid pentru {s}: ");
                return Citire(s);
            }
        }
    }
}
