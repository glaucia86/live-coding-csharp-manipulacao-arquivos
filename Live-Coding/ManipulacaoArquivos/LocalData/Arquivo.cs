using System;
using System.IO;
using ManipulacaoArquivos.Model; // importando as classes

namespace ManipulacaoArquivos.LocalData
{
    public class Arquivo
    {
        #region Método - GravarProdutoExcel
        public void GravarProdutoExcel(Produto produto)
        {
            try
            {
                // Info StreamWriter: https://docs.microsoft.com/pt-br/dotnet/api/system.io.streamwriter?view=netframework-4.7.2
                // Aqui devem alterar a path para sua máquina local
                var streamWriter = new StreamWriter("D:\\Live Coding\\live-coding-csharp-manipulacao-arquivos\\Live-Coding\\vendas.csv", true);

                // Escrita dos dados no arquivo
                streamWriter.WriteLine(produto.CodigoProduto + 
                                       ";" + 
                                       produto.NomeProduto + 
                                       ";" + 
                                       produto.PrecoProduto + 
                                       ";" + 
                                       produto.Email);
                streamWriter.Close(); // Fecharei o arquivo

                Console.WriteLine("\n\nProduto Gravado com Sucesso no arquivo 'vendas.csv'!");
            }
            catch (Exception e)
            {
                throw new Exception("Error...: " + e.Message);
            }
        }
        #endregion

        #region Método GravarProdutoXml
        public void GravarProdutoXml(Produto produto)
        {
            try
            {
                var xml = System.Xml.XmlWriter.Create("D:\\Live Coding\\live-coding-csharp-manipulacao-arquivos\\Live-Coding\\vendas.xml");

                xml.WriteStartDocument();
                    xml.WriteStartElement("produto"); // <produto>
                        xml.WriteElementString("codigo", produto.CodigoProduto.ToString()); //<codigo>
                        xml.WriteElementString("nome", produto.NomeProduto); //<nome>
                        xml.WriteElementString("preco", produto.PrecoProduto.ToString()); // <preco>
                        xml.WriteElementString("email", produto.Email); //<email>
                xml.WriteEndElement();
                xml.WriteEndDocument();

                xml.Close();

                Console.WriteLine("\n\nProduto Gravado com Sucesso no arquivo 'vendas.xml!'");

            }
            catch (Exception e)
            {
                throw new Exception("Error...: " + e.Message);
            }
        }
        #endregion Método 

        #region Método GravarProdutoTxt
        public void GravarProdutoTxt(Produto produto)
        {
            try
            {
                var streamWriter = new StreamWriter("D:\\Live Coding\\live-coding-csharp-manipulacao-arquivos\\Live-Coding\\vendas.txt", true);
                // Escrita dos dados no arquivo
                streamWriter.WriteLine(produto.CodigoProduto +
                                       ";" +
                                       produto.NomeProduto +
                                       ";" +
                                       produto.PrecoProduto +
                                       ";" +
                                       produto.Email);
                streamWriter.Close(); // Fecharei o arquivo

                Console.WriteLine("\n\nProduto Gravado com Sucesso no aequivo 'vendas.txt'!");
            }
            catch (Exception e)
            {
                throw new Exception("Error...: " + e.Message);
            }
        }
        #endregion
    }
}