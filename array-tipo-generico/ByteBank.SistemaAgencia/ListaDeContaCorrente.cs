using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximoPasso;
        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximoPasso = 0;
        }

        public int Tamanho { get { return _proximoPasso; } }

        public void Add(ContaCorrente item)
        {
            VereficarArray(_proximoPasso + 1);

            Console.WriteLine($"Adicionando item na proxima posiçao {_proximoPasso}");
            _itens[_proximoPasso] = item;
            _proximoPasso++;
        }

        public void AddVarios(params ContaCorrente[] itens)
        {
            for(int i = 0; i < itens.Length; i++)
            {
                Add(itens[i]);
            }
            foreach(ContaCorrente conta in itens)
            {
                Add(conta);
            }
        }

        public void remover(ContaCorrente item)
        {
            int indiceItem = -1;
            for(int i=0; i < _proximoPasso; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }


                for (int j = indiceItem; i < _proximoPasso - 1; i++)
                {
                    _itens[i] = _itens[i + 1];
                }
                _proximoPasso--;
                _itens[_proximoPasso] = null;
            }
        }
        public void Listar()
        {
            for(int i = 0; i < _proximoPasso; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta numero{conta.Agencia} {conta.Numero}");
            }
        }

        public ContaCorrente getContaCorrenteIndice(int indice)
        {
            if(indice < 0 || indice >= _proximoPasso)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];  
        }
        private void VereficarArray(int tamanho)
        {
            if(_itens.Length >= tamanho)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if(novoTamanho < tamanho)
            {
                novoTamanho = tamanho;
            }
            Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return getContaCorrenteIndice(indice);
            }
          
        }

    }
}
