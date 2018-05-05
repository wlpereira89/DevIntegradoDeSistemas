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

                //List<Clientes> lista = db.Clientes.ToList();
                Clientes c;
                c = new Clientes
                {
                    Nome = nome
                };

                db.Clientes.Add(c);
                int id = c.ClienteID;
                Endereços endereco = new Endereços
                {
                    ClienteID = c.ClienteID,
                    Rua = rua,
                    Cidade = cidade,
                    Estado = estado,
                    Clientes = c                    
                };
                pnEndereço.novoEndereco(endereco);


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
        public static List<Clientes>listar()
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                return db.Clientes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<String> listarNomes()
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                List<Clientes> clientes = db.Clientes.ToList();
                List<String> nomes = new List<String>();
                foreach (Clientes cliente in clientes)
                    nomes.Add(cliente.Nome);
                return nomes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
