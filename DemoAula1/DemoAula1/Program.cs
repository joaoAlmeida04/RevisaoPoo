using System.Runtime.InteropServices;

namespace DemoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma altura:");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma largura:");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um deslocamento:");
            int deslocamento = int.Parse(Console.ReadLine());

            //linha de cima
            Console.Write(ImprimirLinhaVazia(deslocamento));
            Console.WriteLine(ImprimirLinhaCheia(largura)); 


            //linhas do meio
            for (int i = 0; i < altura-2; i++)
            {
                Console.Write(ImprimirLinhaVazia(deslocamento));
                Console.Write('X');
                Console.Write(ImprimirLinhaVazia(largura - 2));
                Console.WriteLine('X');
            }

            //linh de baixo
            Console.Write(ImprimirLinhaVazia(deslocamento));
            Console.Write(ImprimirLinhaCheia(largura));

        }

        static string ImprimirLinhaVazia(int deslocamento)
        {
            return new string(' ', deslocamento);
        }
            
        static string ImprimirLinhaCheia(int largura)
        {
            return new string ('X', largura);
        }
    }
}
