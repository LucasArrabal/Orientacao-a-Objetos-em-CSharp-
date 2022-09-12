using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}