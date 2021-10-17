using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool validacao = true;
            double peso;
            double altura;

            Pessoa pessoa = new Pessoa("Alberto");


            Console.WriteLine("Seja bem vindo ao Programa do Exercicio!");

            do
            {
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("(1) - Calcular IMC");

                Console.WriteLine("(5) - Sair");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o seu Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        pessoa.CalcularIMC(peso, altura);
                        break;


                    case 5:
                        validacao = false;
                        break;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Aperte Enter para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);
        }
    }
}
