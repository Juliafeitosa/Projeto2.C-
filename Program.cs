using System;
using Projeto2_Julia;

class Program
{
    static void Main(string[] args)
    {
        Industria minhaIndustria = new Industria();
        minhaIndustria.Nome = "Feitosa Industries";
        minhaIndustria.Localizacao = "Curitiba";
        minhaIndustria.AnoFundacao = 1999;

        LinhaProducao linha1 = new LinhaProducao();
        linha1.Numero = 1;
        linha1.Tipo = "Eletrônicos";
        linha1.Capacidade = 100;

        LinhaProducao linha2 = new LinhaProducao();
        linha2.Numero = 2;
        linha2.Tipo = "Alimentos";
        linha2.Capacidade = 200;

        
        Produto produto1 = new Produto();
        produto1.Nome = "Celular";
        produto1.Codigo = "CEL001";
        produto1.Preco = 999.99m;

        Produto produto2 = new Produto();
        produto2.Nome = "Chocolate";
        produto2.Codigo = "CHOC001";
        produto2.Preco = 5.99m;


        Maquina maquina1 = new Maquina();
        maquina1.Id = 1;
        maquina1.Marca = "Marca A";
        maquina1.Modelo = "Modelo 1";
        maquina1.Produto = produto1;

        Maquina maquina2 = new Maquina();
        maquina2.Id = 2;
        maquina2.Marca = "Marca B";
        maquina2.Modelo = "Modelo 2";
        maquina2.Produto = produto2;

        Maquina maquina3 = new Maquina();
        maquina3.Id = 3;
        maquina3.Marca = "Marca C";
        maquina3.Modelo = "Modelo 3";
        maquina3.Produto = produto1;

        Maquina maquina4 = new Maquina();
        maquina4.Id = 4;
        maquina4.Marca = "Marca D";
        maquina4.Modelo = "Modelo 4";
        maquina4.Produto = produto2;

        linha1.AdicionarMaquina(maquina1);
        linha1.AdicionarMaquina(maquina2);

        linha2.AdicionarMaquina(maquina3);
        linha2.AdicionarMaquina(maquina4);

        minhaIndustria.AdicionarLinhaProducao(linha1);
        minhaIndustria.AdicionarLinhaProducao(linha2);

        minhaIndustria.ExibirInformacoes();

        Console.WriteLine("Detalhes do Produto:");
        produto1.ExibirDetalhes();

        Console.WriteLine("Atualizando o preço do produto...");
        produto1.AtualizarPreco(899.99m);

        Console.WriteLine("Novos detalhes do Produto:");
        produto1.ExibirDetalhes();
    }
}
