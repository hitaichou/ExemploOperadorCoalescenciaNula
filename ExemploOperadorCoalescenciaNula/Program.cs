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

            //Se variável x for nula, a recebe 5
            double a = x ?? 5;
            //Se variável y for nula, b recebe 5
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        
        }
    }
}
