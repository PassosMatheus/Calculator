using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine(a);
        }
    }
}
