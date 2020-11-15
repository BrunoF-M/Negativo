using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int numero;

            Console.Write("Digite um Número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("\nVocê digitou um Número negativo.");
                //Environment.Exit(-1);
            }
          //  else
          //  {
          //      Console.WriteLine("\nVocê digitou um Número Positivo.");
          //  }
            

            Console.WriteLine("\npress enter to finish...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
