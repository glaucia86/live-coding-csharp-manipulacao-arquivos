using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ManipulacaoArquivos.Model; // importando as classes

namespace ManipulacaoArquivos.LocalData
{
    public class Arquivo
    {
        public void GravarProdutoExcel(Produto produto)
        {
            try
            {
                // Info StreamWriter: https://docs.microsoft.com/pt-br/dotnet/api/system.io.streamwriter?view=netframework-4.7.2
                // Aqui devem alterar a path para sua máquina local
                var streamWriter = new StreamWriter("D:\\Live Coding\\live-coding-csharp-manipulacao-arquivos\\Live-Coding\\vendas.csv", true);
                var streamWriter = new StreamWriter("D:\\Live Coding\\live-coding-csharp-manipulacao-arquivos\\Live-Coding\\vendas.xml", true);

                // Escrita dos dados no arquivo
                streamWriter.WriteLine(produto.CodigoProduto + ";" + produto.NomeProduto + ";" + produto.PrecoProduto);
                streamWriter.Close(); // Fecharei o arquivo

                Console.WriteLine("\n\nProduto Gravado com Sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception("Error...: " + e.Message);
            }
        }
    }
}
