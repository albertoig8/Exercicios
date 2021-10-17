using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Pessoa
    {
        public string nome;
        public double imc;

        public Pessoa(string nome)
        {
            this.setNome(nome);
        }


        public string getNome()
        {
            return this.nome;
        }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public double CalcularIMC(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);

            if(imc < 20)
            {
                Console.WriteLine("Seu IMC é {0}. Você esta abaixo do peso.", imc);
            } else if(imc >= 20 && imc < 25)
            {
                Console.WriteLine("Seu IMC é {0}. Parabéns! Você esta no seu peso ideal!", imc);
            } else
            {
                Console.WriteLine("Seu IMC é {0}. Você esta acima do peso.", imc);
            }

            return this.imc;
        }
    }
}
