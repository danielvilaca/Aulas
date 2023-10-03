using System;
using System.Collections.Generic;

namespace Aula2909
{
    class Exercicio1
    {
        public static void LerEImprimirVetor()
        {
            Console.Write("Quantos elementos tem o vetor? ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1} = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nImprime:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }


    class Exercicio2
    {
        public static void LerEVetorComSentinela()
        {
            List<int> vetor = new List<int>();

            Console.WriteLine("Digite os elementos do vetor (use 999 para encerrar):");

            while (true)
            {
                Console.Write("Elemento: ");
                int elemento = int.Parse(Console.ReadLine());

                if (elemento == 999)
                {
                    break; // Encerra a leitura quando 999 for inserido
                }

                vetor.Add(elemento);
            }

            Console.WriteLine("\nImprime:");

            foreach (int elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
        }
    }

    class Exercicio3
    {
        public static void FormarVetorLetras()
        {
            char[] vetorLetras = new char[16];

            char letra = 'A';

            for (int i = 0; i < 16; i++)
            {
                vetorLetras[i] = letra;
                letra++;
            }

            Console.WriteLine("Vetor de letras:");

            foreach (char c in vetorLetras)
            {
                Console.WriteLine(c);
            }
        }
    }

    class Exercicio4
    {
        public static void ContagemElementos(int[] vetor)
        {
            Dictionary<int, int> contagem = new Dictionary<int, int>();

            foreach (int elemento in vetor)
            {
                if (contagem.ContainsKey(elemento))
                {
                    contagem[elemento]++;
                }
                else
                {
                    contagem[elemento] = 1;
                }
            }

            Console.WriteLine("Contagem de elementos:");

            foreach (var kvp in contagem)
            {
                Console.WriteLine($"{kvp.Key} ocorre {kvp.Value} vezes;");
            }
        }
    }

    class Exercicio5
    {
        public static void AdicaoEMultiplicacaoDeVetores()
        {
            Console.Write("Quantos elementos têm cada vetor? ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorA = new int[n];
            int[] vetorB = new int[n];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento A[{i}] = ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento B[{i}] = ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Adição e produto dos elementos dos dois vetores:");

            for (int i = 0; i < vetorA.Length; i++)
            {
                int soma = vetorA[i] + vetorB[i];
                int produto = vetorA[i] * vetorB[i];

                Console.WriteLine($"{vetorA[i]} + {vetorB[i]} = {soma}");
                Console.WriteLine($"{vetorA[i]} * {vetorB[i]} = {produto}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercício 1:");
            Exercicio1.LerEImprimirVetor();

            Console.WriteLine("\nExercício 2:");
            Exercicio2.LerEVetorComSentinela();

            Console.WriteLine("\nExercício 2:");
            Exercicio3.FormarVetorLetras();

            Console.WriteLine("\nExercício 4:");
            int[] vetor = { 4, 2, 5, 4, 3, 5, 2, 2, 4 };
            Exercicio4.ContagemElementos(vetor);

            Console.WriteLine("\nExercício 5:");
            Exercicio5.AdicaoEMultiplicacaoDeVetores();
        }
      
    }
}