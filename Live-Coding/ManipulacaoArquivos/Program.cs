using System;
using ManipulacaoArquivos.Model; // importei aqui a classe Model - 'Produtos'
using ManipulacaoArquivos.Input; // importei a classe 'LeituraProduto'

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

            Console.WriteLine("\n Empresa XYZ");
            Console.WriteLine("Código do Produto...: " + produto.CodigoProduto);
            Console.WriteLine("Nome do Produto...: " + produto.NomeProduto);
            Console.WriteLine("Preço do Produto...: " + produto.PrecoProduto);

            Console.ReadKey();
        }
    }
}
