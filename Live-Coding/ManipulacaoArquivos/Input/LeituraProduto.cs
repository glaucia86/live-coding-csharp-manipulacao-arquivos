﻿using System;
using System.Text.RegularExpressions; // Biblioteca do C# para Regex

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

                if(codigo > 0)
                {
                    return codigo;
                }
                else
                {
                    throw new Exception("Código do Produto é inválido!");
                }

                
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

                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{3,40}$");

                if(regex.IsMatch(nome))
                {
                    return nome;
                }
                else
                {
                    throw new Exception("Nome do Produto é inválido!");
                }
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

                if(preco > 0 && preco <= 10000)
                {
                    return preco;
                }
                else
                {
                    throw new Exception("Preço do Produto é inválido!");
                }           
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error...: " + e.Message);
                return LerPrecoProduto();
            }
        }
        #endregion

        #region Método LerEmail
        public string LerEmail()
        {
            try
            {
                Console.Write("Informe o E-mail...: ");
                string email = Console.ReadLine();

                var regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

                if (regex.IsMatch(email))
                {
                    return email;
                }
                else
                {
                    throw new Exception("E-mail inválido!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error...: " + e.Message);
                return LerEmail();
            }
        }
        #endregion
    }
}
