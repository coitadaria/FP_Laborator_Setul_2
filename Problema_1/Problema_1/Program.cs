using System;
internal class Program
{
    static void Main()
    {
        //varianta cu parcurgere directa (cea mai rapida)
        Console.WriteLine("Programul determina cate din elementele unei secvente sunt pare.");
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        int n = Citire("n");
        if(n <= 0)
        {
            Console.WriteLine("Numarul de elemente trebuie sa fie un numar pozitiv.Introduceti un numar pozitiv:");
            n = Citire("n");
        }
        int countPare = 0;
       
        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int numar = Citire("numar");
            if (numar % 2 == 0)
            {
                countPare++;
            }
        }

        Console.WriteLine($"In secventa sunt {countPare} numere pare.");

        //sau varianta cu string si split

        //Console.WriteLine("Introduceti secventa de numere (separate prin spatiu): ");
        //string input = Console.ReadLine();
        //string[] numereString = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        //int Numere_Pare = 0; //contorul pentru numerele pare
        //foreach (string numarString in numereString)
        //{
        //    if (int.TryParse(numarString, out int numar))
        //    {
        //        if (numar % 2 == 0) Numere_Pare++;
        //    }
        //    else
        //        Console.WriteLine($"Valoarea {numarString} nu este un numar intreg valid.");
        //}
        //Console.WriteLine($"Numarul total de numere pare este: {Numere_Pare}");
    }
    static int Citire(string a)
    {
        while (true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid. Va rugam sa introduceti un numar intreg.");
                return Citire(a);
            }
        }
    }
}