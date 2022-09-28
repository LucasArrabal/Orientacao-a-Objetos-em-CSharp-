using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_02.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get => _nome.ToUpper();
            set
            {
               if(value == " ")
               {
                   throw new ArgumentException("Nome está vazio");
               }     
               _nome = value;
            } 
        }   
        
        private int _idade;
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("idade com o numero negativo");
                }
                _idade = value;
            }
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}