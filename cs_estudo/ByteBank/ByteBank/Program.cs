using ByteBank.Funcionarios;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
 class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }
        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario func1 = new Designer(3000,"475.113.368-34");
            Funcionario func2 = new GerenteDeContas (5000, "444.111.333-34");
            Funcionario func3 = new Diretor(5500,"422.122.322-34");

            func1.Nome = "Lucas Arrabal";
            //func1.CPF = "475.113.368-34";
            //func1.Salario = 3000;
            func1.AumentarSalario();
            gerenciador.Registrar(func1);

            func2.Nome = "Nathan Ferrari";
            //func2.CPF = "444.111.333-34";
            //func2.Salario = 5000;
            func2.AumentarSalario();
            gerenciador.Registrar(func2);

            func3.Nome = "Helo";
            //func3.CPF = "422.122.322-34";
            //func3.Salario = 5500;
            func3.AumentarSalario();
            gerenciador.Registrar(func3);

            

            Console.WriteLine("Nome do Funcionario : " + func1.Nome);
            Console.WriteLine("Sua bonificacao é de : " + func1.GetBonificacao() + "\n");
            Console.WriteLine("Nome do Funcionario : " + func2.Nome);
            Console.WriteLine("Sua bonificacao é de : " + func2.GetBonificacao() + "\n");
            Console.WriteLine("Nome do Funcionario : " + func3.Nome);
            Console.WriteLine("Sua bonificacao é de : " + func3.GetBonificacao() + "\n");

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.WriteLine("Total de funcionario : " + Funcionario.TotaldeFuncionarios);

            Console.WriteLine("O salario do Lucas foi para : " + func1.Salario);
            Console.WriteLine("O salario do Nathan foi para : " + func2.Salario);
            Console.WriteLine("O salario do Helo foi para : " + func3.Salario);
        }
        public  static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor func4 = new Diretor(5500, "433.133.333-55");
            func4.Nome = "Clovis";
            func4.Senha = "Clovis123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            sistemaInterno.Logar(func4, "Clovis123");
        }     
    }
}

