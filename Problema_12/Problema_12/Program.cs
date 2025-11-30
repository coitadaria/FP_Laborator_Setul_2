using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.");
        int n;
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        while (!int.TryParse(Console.ReadLine(),out n ) || n < 0)
        {
            Console.WriteLine("Va rugam sa introduceti un numar intreg pozitiv pentru n:");
        }
        int numar;
        int NumarGrupuri = 0;
        bool avemGrup = false;
        Console.WriteLine($"Introduceti cele {n} numere: ");

        for(int i=0;i<n;i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.WriteLine("Va rugam sa introduceti un numar intreg: ");
            }

            if (numar != 0)
            {
                if (!avemGrup)
                {
                    NumarGrupuri++;
                    avemGrup = true;
                }
            }
            else
                avemGrup = false;
        }
        Console.WriteLine($"In secventa avem {NumarGrupuri} grupuri de numere consecutive diferite de zero.");
    }
}