using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] valor = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] valor1 = new int[] { 3, 8, 9, 6, 8, 5 };
            int[] terceiraArray = new int[] { 4, 8, 6, 1, 3, 7 };
      
            
            var valores = new EncontrarValor(valor, 10);
            var segundoValor = new EncontrarValor(valor1, 10);
            var terceiraValor = new EncontrarValor(terceiraArray, 7);

            Console.WriteLine("------------------ Primeiro Array ---------------------------");
            valores.valorAlvo(valor, 10);
            Console.WriteLine(" ");

            Console.WriteLine("------------------ Segundo Array ---------------------------");
            segundoValor.valorAlvo(valor1, 10);
            Console.WriteLine(" ");

            Console.WriteLine("------------------ Terceiro Array ---------------------------");
            terceiraValor.valorAlvo(terceiraArray, 7);
            Console.WriteLine(" ");

        }
    }
}
