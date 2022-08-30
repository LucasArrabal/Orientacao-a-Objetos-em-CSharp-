using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObj
    {
        private object[] _itens;
        private int _proximoPasso;
        public ListaDeObj(int capacidadeInicial = 5)
        {
            _itens = new object[capacidadeInicial];
            _proximoPasso = 0;
        }

        public int Tamanho { get { return _proximoPasso; } }

        public void Add(object item)
        {
            VereficarArray(_proximoPasso + 1);

            Console.WriteLine($"Adicionando item na proxima posiçao {_proximoPasso}");
            _itens[_proximoPasso] = item;
            _proximoPasso++;
        }

        public void AddVarios(params object[] itens)
        {
            for (int i = 0; i < itens.Length; i++)
            {
                Add(itens[i]);
            }
            foreach (object item in itens)
            {
                Add(item);
            }
        }

        public void remover(object item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximoPasso; i++)
            {
                object itemAtual = _itens[i];

                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
                for (int j = indiceItem; i < _proximoPasso; i++)
                {
                    _itens[i] = _itens[i + 1];
                }
                _proximoPasso--;
                _itens[_proximoPasso] = null;
            }
        }

    

        public object getItemIndice(int indice)
        {
            if (indice < 0 || indice >= _proximoPasso)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        private void VereficarArray(int tamanho)
        {
            if (_itens.Length >= tamanho)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanho)
            {
                novoTamanho = tamanho;
            }
            Console.WriteLine("Aumentando capacidade da lista!");

            object[] novoArray = new object[novoTamanho];
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

        public object this[int indice]
        {
            get
            {
                return getItemIndice(indice);
            }

        }

    }
}

