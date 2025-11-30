using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina daca o secventade n numere este crescatoare rotita.");
        Console.Write("Introduceti numarul de elemente (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Va rugam sa introduceti un numar intreg pozitiv pentru n:");
        }
       
        Console.WriteLine($"Introduceti cele {n} numere: ");
        Console.Write("Numarul 1: ");
        int primul;
        bool esteCrescatoare = true;
        while (!int.TryParse(Console.ReadLine(), out primul))
        {
            Console.WriteLine("Va rugam sa introduceti un numar intreg:");
        }
        if (n == 1)
        {
            Console.WriteLine("Secventa este crescatoare. Nu are nevoie de rotiri succesive. ");
            return;
        }
        int ?precedent = null;

        for (int i = 1; i < n; i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int curent;
            while (!int.TryParse(Console.ReadLine(), out curent))
            {
                Console.WriteLine("Va rugam sa introduceti un numar intreg:");
            }
           if(precedent.HasValue)
            {
                if(curent < precedent.Value)
                    esteCrescatoare = false;
            }
            precedent = curent;
        }
        // in final, precedent este ultimul element din secventa cu care se compara primul 
        if (esteCrescatoare && primul<precedent)
            Console.WriteLine("Secventa este crescatoare. Nu are nevoie de rotiri succesive. ");
        else
        {
            if(esteCrescatoare && primul>precedent)
                Console.WriteLine("Secventa este crescatoare rotita.");
            else
                Console.WriteLine("Secventa NU este crescatoare rotita.");
        }
    }
}