using System;
using projetos.models;

namespace projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteCalculadora();
            //TesteContas();
            //TesteSwitchCase();
            //TesteCondicao();
            //Conversao();
           //TesteClass();
           //Tipos();
        }
        static void TesteCalculadora()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Somar(2,2);
            calculadora.Subtracao(10,5);
            calculadora.Multplicacao(12,12);
            calculadora.Divisao(4,2);
        }
        static void TesteContas()
        {
            int x = 4;
            int y = 8;
            int soma = x + y;
            int subtracao = y - x;
            int multplicacao = soma * subtracao;
            int divisao = multplicacao / 2;
            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(multplicacao);
            Console.WriteLine(divisao);

        }
        static void TesteSwitchCase()
        {
            Console.WriteLine("Digite uma letra ");
            string letra = Console.ReadLine();
            switch(letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;
                default:
                Console.WriteLine("Nao é uma vogal");
                break;   

            }

        }
        

        static void TesteCondicao()
        {
            int idade = 17;

            if ( idade >= 18)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Nao é permitido menores de 18 anos");
            }
        }

        static void Conversao()
        {
             //cast-casting
            int x = Convert.ToInt32("5");
            Console.WriteLine(x);
            int y = int.Parse("10");
            Console.WriteLine(y);
            string a = 7.ToString();
            Console.WriteLine(a);

        }
        static void TesteClass()
        {
             Pessoa p1 = new Pessoa("Lucas", 19);
            p1.Apresentar();
            //Console.WriteLine("Teste");
        }

        static void Tipos()
        {
            Console.WriteLine("Estudo de tipos");
           int x = 2;
           int y = x + 2;
           int soma = x + y;
           Console.WriteLine("Soma entre X e Y = " + soma);
           double a = 2.5;
           double b = a + 1.5;
           double somaDouble = a + b;
           Console.WriteLine("Soma de decimais entre A e B =" + somaDouble);
           bool tORf = true;
           Console.WriteLine(tORf);

        }
    }
}