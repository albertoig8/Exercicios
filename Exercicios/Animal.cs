using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Animal
    {
        private string nome;
        private string tipo;


        public Animal(string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setTipo(string tipo)
        {
            if (tipo.ToUpper() == "CACHORRO" || tipo.ToUpper() == "GATO" || tipo.ToUpper() == "PEIXE")
            {
                this.tipo = tipo;
            } else{
                this.tipo = "Peixa";
            }
            
        }
    }
}
