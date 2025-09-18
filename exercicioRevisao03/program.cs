using System;

namespace ExercicioRevisao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exercicios = new int[4];
            int[] provas = new int[2];
            const double pesoExec = 0.2;
            const double pesoProva = 0.6;
            int trabalho;

            Console.WriteLine("Digite as notas do aluno para os 4 exercícios (0 a 10):");
            PreencherVetor(exercicios);

            Console.WriteLine("Digite as notas do aluno para as 2 provas (0 a 100):");
            PreencherVetor(provas);

            Console.WriteLine(" Digite a nota do trabalho prático ( 0  a 20):");
            trabalho = int.Parse(Console.ReadLine());

            CalcularNotaFinal(exercicios, pesoExec);
            CalcularNotaFinal(provas, pesoProva);
        }

        static void PreencherVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a {i}° nota");
            }
        }

        static int CalcularNotaFinal(int[] vetor, double peso)
        {
            int notafinal = 0;
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return notafinal = soma/vetor.Lenght*peso;
        }
	}
}