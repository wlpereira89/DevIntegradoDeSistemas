using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
namespace Modelo.PN
{
    public static class pnClientes
    {
        public static bool novoCliente(String nome, String rua, String cidade, String estado)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                Clientes c = new Clientes
                {
                    Nome = nome
                };

                db.Clientes.Add(c);
                Endereços endereco = new Endereços
                {
                    ClienteID = c.ClienteID,
                    Rua = rua,
                    Cidade = cidade,
                    Estado = estado
                };
                pnEndereço.novoEndereco(endereco);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Clientes pesquisar(String nome)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                return db.Clientes.Find(nome);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
