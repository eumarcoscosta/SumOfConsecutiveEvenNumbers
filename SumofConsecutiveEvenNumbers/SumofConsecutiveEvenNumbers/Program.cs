using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, a = 0, b = 0, c = 0, d = 0, total;

            Console.WriteLine("Insira o valor abaixo: ");
            x = int.Parse(Console.ReadLine());

            while (x > 0)
            {
                if (x % 2 == 0)
                {
                    a = x + 2;
                    b = a + 2;
                    c = b + 2;
                    d = c + 2;
                    
                    total = x + a + b + c + d;
                    
                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());
                } else
                {
                    x = x + 1;
                    a = x + 2;
                    b = a + 2;
                    c = b + 2;
                    d = c + 2;

                    total = x + a + b + c + d;

                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());

                }
            }

        }
    }
}