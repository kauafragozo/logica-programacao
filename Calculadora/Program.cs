using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("Escolha o Primeiro Número");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Calculadora em C#");
                Console.WriteLine("Escolha uma Operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                int op = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha o Segundo Número");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int resultado = 0;

                switch (op)
                {
                    case 1:
                        resultado = n1 + n2;
                        break;
                    case 2:
                        resultado = n1 - n2;
                        break;
                    case 3:
                        resultado = n1 * n2;
                        break;
                    case 4:
                        resultado = n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Operação Inválida");
                        break;
                }
                Console.WriteLine("-------------------");
                Console.WriteLine(resultado);
                Console.WriteLine("-------------------");
                Console.WriteLine("Deseja Realizar outra operação?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2- Não");
                int resposta = Convert.ToInt32(Console.ReadLine());

                switch (resposta)
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