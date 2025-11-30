using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.");
        Console.WriteLine("Introduceti numarul de elemente (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Introduceti un numar valid (n > 0): ");
        }

        int count = 0;

        Console.WriteLine($"Introduceti cele {n} numere:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Numarul {i + 1}: ");
            int numar;

            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.Write("Introduceti un numar valid: ");
            }

            if (numar == i)
            {
                count++;
            }
        }

        if (count == 0)
            Console.WriteLine($"Nu exista niciun element egal cu pozitia sa in secventa.");
        else
        {
            if (count == 1)
                Console.WriteLine($"Exista un element egal cu pozitia sa in secventa.");
            else
                Console.WriteLine($"Exista {count} elemente egale cu pozitia lor in secventa.");
        }
    }
   
}