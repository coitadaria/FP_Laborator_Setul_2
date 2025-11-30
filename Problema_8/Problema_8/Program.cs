using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina al n-lea numar din sirul lui Fibonacci. Numarul n este citit de la tastatura.");
        Console.Write("Introduceti un numar intreg pozitiv n: ");
        int n = Citire("n");
        long rezultat= Fibonacci(n);
        Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {rezultat}.");
    }
    static int Citire(string stringNumar)
    {
        int numar;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out numar) && numar > 0)
            {
                return numar;
            }
            else
            {
                Console.Write($"Sirul nu poate avea termeni mai mici sau egali cu 0. Introduceti un numar intreg pozitiv pentru {stringNumar}: ");
            }
        }
    }
    static long Fibonacci(int n)
    {
        if (n == 1)
            return 0;
        if (n == 2)
            return 1;

        long a = 0;
        long b = 1;
        long c = 0;

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}