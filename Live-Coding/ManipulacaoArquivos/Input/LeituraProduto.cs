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
            try
            {
                Console.Write("Informe o Código do Produto...: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                return codigo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error...: " + e.Message);
                return LerCodigoProduto();
            }
        }
        #endregion

        #region Método LerNomeProduto
        public string LerNomeProduto()
        {
            try
            {
                Console.Write("Informe o Nome do Produto...: ");
                string nome = Console.ReadLine();

                return nome;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error...: " + e.Message);
                return LerNomeProduto();
            }
        }
        #endregion

        #region Método LerPrecoProduto
        public decimal LerPrecoProduto()
        {
            try
            {
                Console.Write("Informe o Preço do Produto...: ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                return preco;
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error...: " + e.Message);
                return LerPrecoProduto();
            }
        }
        #endregion
    }
}
