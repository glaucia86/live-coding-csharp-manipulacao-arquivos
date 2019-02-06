using System;
using ManipulacaoArquivos.Model; // importei aqui a classe Model - 'Produtos'
using ManipulacaoArquivos.Input; // importei a classe 'LeituraProduto'
using ManipulacaoArquivos.LocalData; // importando a classe 'Arquivo'

namespace ManipulacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            var leituraProduto = new LeituraProduto();

            produto.CodigoProduto = leituraProduto.LerCodigoProduto();
            produto.NomeProduto = leituraProduto.LerNomeProduto();
            produto.PrecoProduto = leituraProduto.LerPrecoProduto();
            produto.Email = leituraProduto.LerEmail();

            Console.WriteLine("\n Empresa XYZ");
            Console.WriteLine("Código do Produto...: " + produto.CodigoProduto);
            Console.WriteLine("Nome do Produto...: " + produto.NomeProduto);
            Console.WriteLine("Preço do Produto...: " + produto.PrecoProduto);
            Console.WriteLine("E-mail...: " + produto.Email);

            var arquivo = new Arquivo();
            
            arquivo.GravarProdutoExcel(produto);
            arquivo.GravarProdutoXml(produto);
            arquivo.GravarProdutoTxt(produto);

            Console.ReadKey();
        }
    }
}
