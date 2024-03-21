using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2_Julia
{
    public class Produto
    {
        public string Nome {get; set;} = "";
        public string Codigo {get; set;}
        public decimal Preco {get; set;}

        public void ExibirDetalhes()
        {
            Console.WriteLine($"______PRODUTO: {Nome}, {Codigo}, {Preco}");
        }

        public void AtualizarPreco(decimal novoPreco)
        {   
            this.Preco = novoPreco;
        }
    }
}