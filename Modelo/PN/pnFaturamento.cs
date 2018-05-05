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
                clientes = new List<Clientes>();
                this.pedidos = db.Pedidos.Where(pedido => pedido.Data >= inicio).Where(pedido => pedido.Data <= fim).ToList();
                List<Clientes> clientesTemp = db.Pedidos.Where(pedido => pedido.Data >= inicio).Where(pedido => pedido.Data <= fim).Join(db.Clientes, t => t.ClienteID, g => g.ClienteID, (t, g) => g).ToList();
                List<int> ids = new List<int>();
                foreach (Clientes cliente in clientesTemp)
                {
                    if (!ids.Contains(cliente.ClienteID))
                    {
                        ids.Add(cliente.ClienteID);
                        clientes.Add(cliente);
                    }
                        
                }
                pnCoreData.faturar(inicio, fim);
            }            
            catch (Exception)
            {
                throw;
            }
        }
        public List<String> listarClientesComPedido()
        {
            List<String> nomes = new List<String>();
            foreach (Clientes cliente in clientes)
                nomes.Add(cliente.ClienteID+" "+cliente.Nome.Trim());
            return nomes;
        }
       
       
    }
}
