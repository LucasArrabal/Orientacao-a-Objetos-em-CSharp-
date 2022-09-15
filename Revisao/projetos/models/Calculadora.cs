using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos.models
{
    public class Calculadora
    {
        public void Somar(int x , int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtracao(int x , int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multplicacao(int x , int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }
        public void Divisao(int x , int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}