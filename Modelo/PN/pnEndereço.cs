using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;


namespace Modelo.PN
{
    public static class pnEndereço
    {
        public static bool novoEndereco(int clientID, String rua, String cidade, String estado)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                Endereços endereco = new Endereços
                {
                    ClienteID = clientID,
                    Rua = rua,
                    Cidade = cidade,
                    Estado = estado
                }; 
                db.Endereços.Add(endereco);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool novoEndereco(Endereços endereco)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                db.Endereços.Add(endereco);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
