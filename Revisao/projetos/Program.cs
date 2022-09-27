using System;
using projetos.models;

namespace projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista();
            //AumentandoArray();
            //ArrayForReach();
            //Array();
            //Menu();
            //TesteFor();
            //TesteCalculadora();
            //TesteContas();
            //TesteSwitchCase();
            //TesteCondicao();
            //Conversao();
           //TesteClass();
           //Tipos();
        }
        
        static void Lista()
        {
            List<string> letra = new List<string>();
            letra.Add("A");
            letra.Add("B");
            letra.Add("C");
            letra.Add("D");

            Console.WriteLine("usando o FOR");
            for (int i = 0; i < letra.Count; i++)
            {
                Console.WriteLine($"Posição N°{i} - {letra[i]}");
            }
            Console.WriteLine("usando o FOREACH");
            int contador = 0;
            foreach (var item in letra)
            {
                Console.WriteLine($"Posição N°{contador} - {letra[contador]}");
                contador++;
            }
          }   
        
         static void AumentandoArray()
        {
            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);    

            for(int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine($"Posiçao N° {i}  - {arrayInteiros[i]}");
            }
        }

        static void ArrayForReach()
        {
            int[] arrayInteros = new int[3];
            arrayInteros[0] = 10;
            arrayInteros[1] = 20;
            arrayInteros[2] = 30;

            for(int i = 0; i < arrayInteros.Length; i++)
            {
                Console.WriteLine($"Posiçao N° {i}  - {arrayInteros[i]}");
            }
            Console.WriteLine("Percorrendo o Array com o FOREACH");
           foreach (int valor in arrayInteros)
           {
                Console.WriteLine(valor);
           }
        }

        static void  Array()
        {
            int[] arrayInteros = new int[3];
            arrayInteros[0] = 10;
            arrayInteros[1] = 20;
            arrayInteros[2] = 30;

            for(int i = 0; i < arrayInteros.Length; i++)
            {
                Console.WriteLine($"Posiçao N° {i}  - {arrayInteros[i]}");
            }
        }

          static void Menu()
          {
              string opcao;
              bool exibirMenu = true;
              while(exibirMenu)
              {
                Console.Clear();
                Console.WriteLine("Digite sua opção : ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    Console.WriteLine("1 - Cadastrar Cliente");
                    break;
                     case "2":
                    Console.WriteLine("2 - Buscar Cliente");
                    break;
                     case "3":
                    Console.WriteLine("3 - Apagar Cliente");
                    break;
                     case "4":
                    Console.WriteLine("4 - Encerrar");
                    exibirMenu = false;
                    break;

                    default:
                    Console.WriteLine("Opção Invalida");
                    break;
                }

              }
              Console.WriteLine("");
          }
        static void TesteFor()
        {
            int num = 10;
            for(int i = 0; i <=10;i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i} "); 

            }
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
