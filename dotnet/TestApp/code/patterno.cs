using System;

class patterno
{
    static void Main()
    {
        int n = 5;
        for (int i = n; i >= 1; i--)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}