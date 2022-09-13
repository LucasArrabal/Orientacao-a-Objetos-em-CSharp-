using System;
using projetos.models;

namespace projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesteCondicao();
            //Conversao();
           //TesteClass();
           //Tipos();
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