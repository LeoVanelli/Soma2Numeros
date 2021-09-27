using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo: Leia 2 números inteiros e exiba o resultado da soma

            Console.WriteLine("Bem vindo a Calculadora de Soma\n");

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSoma: {num1} + {num2} = {num1+num2}");
        }
    }
}
