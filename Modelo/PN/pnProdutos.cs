using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public static class pnProdutos
    {
        public static bool novoProduto(Produtos prod)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                db.Produtos.Add(prod);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool novosProdutosCsv(string arquivo, char separador) //adiciona produtos de um arquivo csv
        {
            StreamReader listar = new StreamReader(arquivo);
            string linha = null;
            string[] linhaseparada = null;
            while ((linha = listar.ReadLine()) != null)
            {
                linhaseparada = linha.Split(separador);
                Produtos novo = new Produtos
                {
                    Descricao = linhaseparada[0],
                    Preco = Convert.ToDouble(linhaseparada[1])
                };
                if (!novoProduto(novo)) // se o produto não for adicionado retorna erro
                    return false;
            }
            return true;
        }
        
    }

}
