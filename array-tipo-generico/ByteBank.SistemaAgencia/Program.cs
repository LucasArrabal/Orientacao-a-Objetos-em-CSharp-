using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeObj listaDeIdades = new ListaDeObj();

            listaDeIdades.Add(10);
            listaDeIdades.Add(5);
            listaDeIdades.Add(4);
            listaDeIdades.Add("um texto qualquer");
            listaDeIdades.AddVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TesteLista()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Add(new ContaCorrente(123, 111111));
            lista.Add(new ContaCorrente(123, 222222));
            lista.Add(new ContaCorrente(123, 333333));
            lista.Add(new ContaCorrente(123, 111211));
            lista.Add(new ContaCorrente(123, 222322));
            lista.Add(new ContaCorrente(123, 333233));
            lista.Add(new ContaCorrente(123, 111111));
            lista.Add(new ContaCorrente(123, 222222));
            lista.Add(new ContaCorrente(123, 333333));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.getContaCorrenteIndice(i);
                Console.WriteLine($"Item na posiçao {i} = conta{itemAtual.Numero}/{itemAtual.Agencia}");
            }


            Console.ReadLine();
        }
        static void TesteContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(123, 111111),
                new ContaCorrente(123, 222222),
                new ContaCorrente(123, 333333)

            };
            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
        static void TesteArray()
        {
            // Array com numeros inteiros
            int[] idades = new int[5];
            idades[0] = 2;
            idades[1] = 4;
            idades[2] = 6;
            idades[3] = 8;
            idades[4] = 10;

            int aux = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idice da Idade é {i}");
                Console.WriteLine($"Valor idade [{i}] = {idade}");

                aux += idade;
            }
            int media = aux / idades.Length;
            Console.WriteLine($"Media de idade {media}");


            Console.ReadLine();

        }
    }
}
