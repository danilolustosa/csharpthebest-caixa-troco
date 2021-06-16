using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto:");
            string input = Console.ReadLine();
            double valorProduto = Convert.ToDouble(input);

            string inputPagamento = "100";

            while (inputPagamento != "")
            {
                Console.WriteLine("Digite o valor pago pelo produto:");
                inputPagamento = Console.ReadLine();

                double valorPagamento = 0;

                if (inputPagamento != "")
                {
                    valorPagamento = Convert.ToDouble(inputPagamento);

                    if ((valorPagamento - valorProduto) > 0)
                    {
                        Console.WriteLine("O valor do troco é: " + (valorPagamento - valorProduto));
                    }
                }                     
            }

            
        }
    }
}
