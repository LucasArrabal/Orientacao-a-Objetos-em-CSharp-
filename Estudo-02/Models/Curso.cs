using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_02.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
        public int ObterNumAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
    }
}