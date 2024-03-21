using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2_Julia
{
    public class Maquina
    {
        public int Id {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public Produto Produto = new Produto();

        public void ExibirInformacoes()
        {
            Console.WriteLine($"____MAQUINA: {Id}, {Marca}, {Modelo}");
            Produto.ExibirDetalhes();
        }

        public void InciarProducao()
        {
            Console.WriteLine($"Iniciando producao");
            Thread.Sleep(500);
            Console.WriteLine($"3");
            Thread.Sleep(500);
            Console.WriteLine($"2");
            Thread.Sleep(500);
            Console.WriteLine($"1");
        }
    }
}