using System;

namespace soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("digite o primeiro 1valor:");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o 2valor:");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"seu resultado é: {valor1 + valor2}");

            Console.WriteLine("pressione enter para sair");
            Console.ReadLine();
        }
    }
}
