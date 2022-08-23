using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Soma();
            Subtracao();
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------");
            float resultado = a + b;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        static void Subtracao()
        {
            Console.Write("Primeiro valor: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------");
            float resultado = a - b;
            Console.WriteLine("O resultado da subtração é: " + resultado);
        }
    }
}
