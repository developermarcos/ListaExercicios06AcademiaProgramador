using System;
//Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a média aritmética dos valores lidos, a quantidade de valores positivos e a
//quantidade de valores negativos.
namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            int soma = 0, contaValoresNegativor = 0, contaValoresPositivos = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o {0}º valor: ", (i+1).ToString());
                valores[i] = Convert.ToInt32(Console.ReadLine());
                soma += valores[i];
                if (valores[i] >= 0)
                    contaValoresPositivos++;
                else
                    contaValoresNegativor++;
            }
            Console.WriteLine("A media aritmética é: {0}", (soma / valores.Length).ToString());
            Console.WriteLine("Quantidade de valores positivos: {0}", contaValoresPositivos.ToString());
            Console.WriteLine("Quantidade de valores negativos: {0}", contaValoresNegativor.ToString());
            Console.ReadKey();
        }
    }
}
