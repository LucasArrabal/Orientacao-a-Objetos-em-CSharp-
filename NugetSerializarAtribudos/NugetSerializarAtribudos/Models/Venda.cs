using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetSerializarAtribudos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DateVenda { get; set; }


        public Venda(int id, string produto, decimal preco, DateTime dateVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DateVenda = dateVenda;
        }
    }
}
