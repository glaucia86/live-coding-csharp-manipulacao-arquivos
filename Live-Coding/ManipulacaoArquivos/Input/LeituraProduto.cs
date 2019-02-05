using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos.Input
{
    public class LeituraProduto
    {
        #region Método LerCodigoProduto

        public int LerCodigoProduto()
        {
            Console.Write("Informe o Código do Produto...: ");
            int codigo = Convert.ToInt32(Console.ReadLine()); 

            return codigo;
        }
        #endregion

        #region Método LerNomeProduto
        public string LerNomeProduto()
        {
            Console.Write("Informe o Nome do Produto...: ");
            string nome = Console.ReadLine();

            return nome;
        }
        #endregion

        #region Método LerPrecoProduto
        public string LerPrecoProduto()
        {
            Console.Write("Informe o Preço do Produto...: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            return preco;
        }
        #endregion
    }
}
