using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Write("Primeiro valor: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------");
            float resultado = a - b;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Write("Primeiro valor: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------");
            float resultado = a - b;
            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.ReadKey();
            Menu();
        }
    }
}
