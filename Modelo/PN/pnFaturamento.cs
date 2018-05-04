using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public class pnFaturamento
    {
        private List<Pedidos> pedidos;
        private List<Clientes> clientes;
        public pnFaturamento(DateTime inicio, DateTime fim)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                this.pedidos = db.Pedidos.Where(pedido => pedido.Data >= inicio).Where(pedido => pedido.Data <= fim).ToList();
                pnCoreData.faturar(inicio, fim);
            }            
            catch (Exception)
            {
                throw;
            }

        }
       
    }
}
