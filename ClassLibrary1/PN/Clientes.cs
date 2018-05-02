using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAO;

namespace ClassLibrary1.PN
{
    public static class Clientes
    {
        public static bool Inserir(Pessoa p)
        {
            try
            {
                ModeloProjeto1Entities db = new ModeloProjeto1Entities();
                if (pnAgenda.Pesquisar(p.Email) != null)
                {
                    return false;
                }
                db.Pessoas.Add(p);
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
