namespace exercicoRevisao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 6;
            int[] vetor = null;
            do
            {
                Console.WriteLine("1 - Dividir dois números");
                Console.WriteLine("2 – Ler 3 números e mostrar qual é o maior deles");
                Console.WriteLine("3 – Ler e armazenar N números");
                Console.WriteLine("4 – Mostrar a soma dos números armazenados");
                Console.WriteLine("5 - Contar quantos dos números armazenados são pares e quantos são ímpares");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção:");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um número:");
                        int numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        int numero2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado é igual a: {DividirDoisNumeros(numero1, numero2)}");
                        break;

                    case 2:
                        Console.WriteLine("Digite um número:");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        int num3 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O maior número é: {InformaMaiorNumero(num1, num2, num3)}");

                        break;

                    case 3:
                        vetor = ArmazenarNumeros();
                        break;

                    case 4:

                        if(vetor != null)
                        {
                            Console.WriteLine($"A soma dos número é: {SomarNumerosArmazenados(vetor)}");
                        }
                        else
                        {
                            vetor = ArmazenarNumeros();
                            Console.WriteLine($"A soma dos número é: {SomarNumerosArmazenados(vetor)}");
                        }
                            break;

                    case 5:

                        if (vetor != null)
                        {
                            int pares = 0;
                            int impares = 0;

                            for (int i = 0; i < vetor.Length; i++)
                            {
                                if (vetor[i] % 2 == 0) 
                                    pares++;
                                else 
                                    impares++;
                            }

                            Console.WriteLine($"Quantidade de pares: {pares}");
                            Console.WriteLine($"Quantidade de ímpares: {impares}");
                        }
                        else
                        {
                            vetor = ArmazenarNumeros();
                            int pares = 0;
                            int impares = 0;

                            for (int i = 0; i < vetor.Length; i++)
                            {
                                if (vetor[i] % 2 == 0)
                                    pares++;
                                else
                                    impares++;
                            }

                            Console.WriteLine($"Quantidade de pares: {pares}");
                            Console.WriteLine($"Quantidade de ímpares: {impares}");
                        }

                        break;
                    default:
                        Console.WriteLine("Por favor escolha outra opção");
                        break;
                }
            }
            while (opcao != 0);


            static int DividirDoisNumeros(int numero1, int numero2)
            {
                return numero1 / numero2;
            }

            static int InformaMaiorNumero(int num1, int num2, int num3)
            {
                int maior = 0;

                if (num1 > num2 & num1 > num3)
                {
                    maior = num1;
                }else if (num2 > num1 & num2 > num3)
                {
                    maior = num2;
                }
                else if (num3 > num1 & num3 > num2)
                {
                    maior = num3;
                }

                return maior;
            }


            static int[] ArmazenarNumeros()
            {
                Console.WriteLine("Quantos números você deseja armazernar?");
                int quantidadeParaArmazenar = int.Parse(Console.ReadLine());

                int[] vetor = new int[quantidadeParaArmazenar];
                for (int i = 0; i < quantidadeParaArmazenar; i++)
                {
                    Console.WriteLine($"Digite o {i+1}° número");
                    vetor[i] = int.Parse(Console.ReadLine());
                }
                return vetor;
            }

            static int SomarNumerosArmazenados(int[] vetor)
            {
                int soma = 0;

                for (int i = 0; i < vetor.Length; i++)
                {
                    soma += vetor[i];
                }

                return soma;
            }
        }
    }
}
