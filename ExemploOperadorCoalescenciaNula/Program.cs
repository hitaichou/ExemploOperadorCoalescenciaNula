using System;

namespace ExemploOperadorCoalescenciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis que podem ser nulas.
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        
        }
    }
}
