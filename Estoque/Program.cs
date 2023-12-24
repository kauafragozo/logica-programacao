using System;
using System.Threading.Channels;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldoinicial = 0;
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("Insira o Saldo Incicial");
                saldoinicial = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------");
                Console.WriteLine("Selecione uma Opção");
                Console.WriteLine("1 - Entrada");
                Console.WriteLine("2 - Saida");
                int tipo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira a Quantidade");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        saldoinicial += quantidade;
                        Console.WriteLine("O saldo é igual a:" + saldoinicial);
                        break;
                    case 2:
                        if (saldoinicial >= quantidade)
                        {
                            saldoinicial -= quantidade;
                            Console.WriteLine("O saldo é igual a:" + saldoinicial);
                        }
                        else
                        {
                            Console.WriteLine("Quantidade Insuficiente");
                        }
                        break;
                    default:
                        Console.WriteLine("Operação Inválida");
                        break;
                }
                Console.WriteLine("Deseja Realizar outra Operação?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int op2 = Convert.ToInt32(Console.ReadLine());

                switch (op2)
                {
                    case 1:
                        executando = true;
                        break;
                    case 2:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}
