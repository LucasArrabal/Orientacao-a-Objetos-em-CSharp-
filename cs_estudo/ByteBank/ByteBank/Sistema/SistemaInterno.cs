using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel func, string senha)
        {
            bool usuarioAutenticado = func.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("SENHA INCORRETA");
                return false;
            }
        }
    }
}
