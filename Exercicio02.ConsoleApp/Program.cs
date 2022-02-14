using System;
//Desenhe um retângulo com A e B, onde as forem linhas pares escreva "A" e as linhas ímpares escreva "B";

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int larguraRetangulo = 50, alturaRetangulo = 10;
            string imprimirTela = "";
            for (int i = 0; i < alturaRetangulo; i++)
            {
                for (int z = 0; z < larguraRetangulo; z++)
                {
                    if(i %2 == 0)
                    {
                        imprimirTela +="A";
                    }
                    else
                    {
                        imprimirTela +="B";
                    }
                    
                }
                imprimirTela +="\n";
            }
            Console.WriteLine(imprimirTela);
            Console.ReadKey();
        }
    }
}
