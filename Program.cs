using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            string NumeroDigitado;

            Console.Write("Digite o 1 valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 2 valor: "); 
            NumeroDigitado = Console.ReadLine();
            n2 = Convert.ToDouble(NumeroDigitado);

            double resultado = n1 + n2;

            Console.WriteLine($"Soma: {resultado}");   
    }
    }
}   
