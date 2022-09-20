using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCsharp
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;  
            _saldo = saldoInicial; 
        }
        public int NumeroConta { get; set; }
        private decimal _saldo;
        public void Sacar(decimal valor)
        {
            if(_saldo >= valor)
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponivel");
            }
           
        }
        public void ExebirSaldo()
        {
            Console.WriteLine("Seu saldo diposnivel é de : " + _saldo);
        }
    }
}
