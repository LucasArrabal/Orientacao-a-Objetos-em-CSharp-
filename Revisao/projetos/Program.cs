using System;
using projetos.models;

namespace projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //TesteClass();
           //Tipos();
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