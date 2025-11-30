using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina daca o secventa reprezinta o secventa de paranteze corecte si nivelul de incuibare.");
        Console.WriteLine("0 = paranteza deschisa, 1 = paranteza inchisa.");
        Console.Write("Introduceti numarul de elemente din secventa (n): ");

        int n, paranteza,varful=0,niveluldeincubare=0;
        bool esteIncubatCorect = true;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Va rugam sa introduceti un numar natural valid: ");
        }
    
        Console.WriteLine($"Introduceti cele {n} numere (0 sau 1):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out paranteza) || (paranteza != 0 && paranteza != 1))
            {
                Console.Write("Va rugam sa introduceti o valoare valida (0 sau 1): ");
            }
            if(paranteza == 0)
            {
                varful++;
                if(varful>niveluldeincubare)
                    niveluldeincubare = varful;
            }
            else
            {
                if(paranteza == 1 && varful==0)
                {
                    esteIncubatCorect = false;
                }
                else
                    varful--;
            }
        }
        if(esteIncubatCorect && varful == 0)
        {
            Console.WriteLine($"Secventa reprezinta o secventa de paranteze corecte. Nivelul maxim de incuibare este: {niveluldeincubare}.");
        }
        else
        {
            Console.WriteLine("Secventa NU reprezinta o secventa de paranteze corecte.");
        }
    }
}