using System;

namespace NOME_E_IDADE_MAIS_VELHO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string[] nome = new string[x];
            int[] idade = new int[x];


            for (int i = 0; i < x; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int maior = idade[0];
            string nvelho = nome[0];


            for (int i = 0;i < x; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i];
                    nvelho = nome[i];
                }
            }
            Console.WriteLine($"A pessoa mais velha tem a idade de {maior} anos e se chama {nvelho} ");

        }
    }
}
