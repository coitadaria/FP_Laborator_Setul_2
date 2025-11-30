using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina daca o secventa de n numere este o secventa monotona rotita.");
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Va rugam introduceti un numar intreg pozitiv pentru n: ");
        }
        Console.WriteLine($"Introduceti cele {n} numere: ");
        Console.Write("Numarul 1: ");
        int primul;
        while(!int.TryParse(Console.ReadLine(),out primul))
        {
            Console.WriteLine("Va rugam sa intoduceti un numar intreg: ");
        }
        if(n==1)
        {
            Console.WriteLine("Secventa este momotona. Nu are nevoie de rotiri.");
            return;
        }
        bool esteCrescatoare = true;
        bool esteDescrescatoare = true;
        int? precedent = null;
        for(int i=1;i<n;i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int curent;
            while (!int.TryParse(Console.ReadLine(), out curent))
            {
                Console.WriteLine("Va rugam sa intoduceti un numar intreg: ");
            }
            if(precedent.HasValue)
            {
                if (curent < precedent.Value)
                    esteCrescatoare = false;
                if (curent > precedent.Value)
                    esteDescrescatoare = false;
            }
            precedent = curent;
        }
        if (esteCrescatoare && esteDescrescatoare)
            Console.WriteLine("Secventa este monotona (toate numerele sunt egale).");
        else
        {
            if (esteCrescatoare)
            {
                if (primul < precedent)
                    Console.WriteLine("Secventa este monotona crescatoare. Nu are nevoie de rotiri.");
                else
                    Console.WriteLine("Secventa este monotona crescatoare rotita.");
            }
            else
            {
                if (esteDescrescatoare)
                {
                    if (primul > precedent)
                        Console.WriteLine("Secventa este monotona descrescatoare. Nu are nevoie de rotiri.");
                    else
                        Console.WriteLine("Secventa este monotona descrescatoare rotita.");
                }
            }
        }
        if (!esteDescrescatoare && !esteCrescatoare)
            Console.WriteLine("Secventa nu este monotona.");
    }
}   