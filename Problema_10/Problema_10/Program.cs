using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina numarul maxim de numere consecutive egale dintr-o secventa de n numere.");
        int n;
        Console.WriteLine("Introduceti numarul de elemente n:");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Va rugam sa introduceti un numar intreg pozitiv pentru n:");
        }
        int maxlenght = 1;// lungimea maxima a unei secvente de numere egale
        int currentlenght = 1; // lungimea curenta a unei secvente de numere egale
        int ? previousNumber = null; // numarul anterior din secventa

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i=0;i<n;i++)
        {
            int numar;
            Console.Write($"Numarul {i + 1}: ");
            while(!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.WriteLine("Va rugam sa introduceti un numar intreg:");
            }
            if(previousNumber.HasValue)
            {
                if (numar == previousNumber.Value)
                {
                    currentlenght++;
                }
                else
                {
                    if (currentlenght > maxlenght)
                    {
                        maxlenght = currentlenght;
                    }
                    currentlenght = 1; // resetam lungimea curenta
                }
            }
            if(currentlenght > maxlenght)
            {
                maxlenght = currentlenght;
            }   
            previousNumber = numar;
        }
        Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {maxlenght}.");
    }
}