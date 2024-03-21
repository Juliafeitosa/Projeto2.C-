using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2_Julia
{
    public class Industria
    {
        public string Nome {get; set;} = "";
        public string Localizacao {get; set;} = "";
        public int AnoFundacao {get; set;}
        public List<LinhaProducao> LinhasProducao = new List<LinhaProducao>();

        public void ExibirInformacoes()
        {
            Console.WriteLine($"*******************************************");
            Console.WriteLine($"{Nome}, {Localizacao}, {AnoFundacao}");
            Console.WriteLine($"*******************************************");
            Console.WriteLine($"");
                foreach(var linha in LinhasProducao)
                {
                    linha.ExibirDetalhes();
                    Console.WriteLine($"===================================================");
                }
        }

        public void AdicionarLinhaProducao(LinhaProducao linhaProducao)
        {
            this.LinhasProducao.Add(linhaProducao);
        }
    }


}


