using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto2_Julia
{
    public class LinhaProducao
    {
        public int Numero {get; set;}
        public string Tipo {get; set;} = "";
        public int Capacidade {get; set;}
        public List<Maquina> Maquinas = new List<Maquina>();

        public void ExibirDetalhes()
        {  
            Console.WriteLine($"LINHA: {Numero}, {Tipo}, {Capacidade}");
            foreach(var maquina in Maquinas)
            {
                maquina.ExibirInformacoes();
                Console.WriteLine("");
            }
        }

        public void AdicionarMaquina(Maquina maquina)
        {
            this.Maquinas.Add(maquina);
        }
    }



}