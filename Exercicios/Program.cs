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

            double salario;
            double salarioMinimo;

            double raio;

            double n1;
            double n2;
            double n3;
            double notaExame;
            double media;

            double resultado;

            Pessoa pessoa = new Pessoa("Alberto");


            Console.WriteLine("Seja bem vindo ao Programa do Exercicio!");

            do
            {
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("(1) - Calcular IMC");
                Console.WriteLine("(2) - Calcular Salário");
                Console.WriteLine("(3) - Calcular Volume de uma esfera");

                Console.WriteLine("(6) - Sair");

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


                    case 2:
                        Console.WriteLine("Informe o valor do seu salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor do salário mínimo: ");
                        salarioMinimo = Convert.ToDouble(Console.ReadLine());

                        resultado = salario / salarioMinimo;
                        Console.WriteLine("Você recebe {0} Salario(s) mínimo. ", Math.Round(resultado, 1));

                        break;


                    case 3:
                        Console.WriteLine("Informe o valor do raio: ");
                        raio = Convert.ToDouble(Console.ReadLine());
                        resultado = (4  * Math.PI * Math.Pow(raio, 3)) / 3;
                        Console.WriteLine("O volume dessa esfera é {0}.", Math.Round(resultado, 2));

                        break;

                    case 4:
                        Console.WriteLine("Digite a primeira nota: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a segunda nota: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a terceira nota: ");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        media = (n1 + n2 + n3) / 3;

                        if(media >= 7)
                        {
                            Console.WriteLine("Media obtida: {0}. Aprovado!", Math.Round(media, 2));
                        } else
                        {
                            Console.WriteLine("Digite a nota do exame: ");
                            notaExame = Convert.ToDouble(Console.ReadLine());

                            media = (media + notaExame) / 2;

                            if(media >= 5)
                            {
                                Console.WriteLine("Média obtida: {0}. Aprovado em exame!", Math.Round(media, 2));
                            } else
                            {
                                Console.WriteLine("Média obtida: {0}. Reprovado.", Math.Round(media, 2));
                            }
                        }

                        break;

                    case 6:
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
