using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul calculeaza suma inverselor numerelor dintr-o secventa de n numere.");
        Console.Write("Introduceti numarul de elemente din secventa (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Va rog introduceti un numar intreg pozitiv pentru n: ");
        }
        long sumaInverselor = 0;
      
        Console.WriteLine($"Introduceti cele {n} numere: ");
        for (int i = 0; i < n; i++)
        {
            int numar,copienumar,invers=0;
            Console.Write($"Numarul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numar))
            {
                Console.Write("Va rog introduceti un numar intreg valid: ");
            }
            copienumar=Math.Abs(numar);
            while (copienumar!=0)
            {
                invers=invers*10 + copienumar % 10;
                copienumar /= 10;
            }
            if(numar<0)
            {
                invers = -invers;
            }
            sumaInverselor += invers;
        }
        Console.WriteLine($"Suma inverselor numerelor din secventa este: {sumaInverselor}.");
    }
}