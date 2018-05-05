using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnPedidos
    {
        private String valorTotalPedidos;
        public String ValorTotalPedidos { get => valorTotalPedidos; }
        private double? valorPedidos;
        public double? ValorPedidos { get => valorPedidos; }

        private List<String> listagemPedidos;
        public List<String> ListagemPedidos { get => listagemPedidos; }
        private List<Pedidos> pedidos;
        public List<Pedidos> Pedidos { get => pedidos; }
        private int diasPeriodo;
        public int DiasPeriodo { get => diasPeriodo; }
        private int clientesComPedidos;
        public int ClienteComPedidos { get => clientesComPedidos; }
        public pnPedidos(int clienteID)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                pedidos = db.Pedidos.Where(c => c.ClienteID == clienteID).ToList();
                listagemPedidos = new List<String>();
                double? total = 0;
                foreach(Pedidos p in pedidos)
                {
                    double? valor = 0;
                    foreach (DetalhesPedido produto in p.DetalhesPedido)
                    {
                        if ((produto.Preco!=null)&&(produto.Qtde!=null))
                            valor += produto.Preco * produto.Qtde;
                    }

                    listagemPedidos.Add("Pedido número: "+p.NroPedido + "       \trealizado na data " + p.Data.Value.ToShortDateString() +"     "+String.Format("no valor total de {0:C2}", valor));
                    if (valor!=null)
                        total += valor;
                }
                valorPedidos = total;
                valorTotalPedidos = String.Format("{0:C2}", total);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public pnPedidos(DateTime inicio, DateTime fim)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                pedidos = db.Pedidos.Where(c => c.Data >= inicio).Where(c => c.Data <= fim).ToList();
                listagemPedidos = new List<String>();
                double? total = 0;
                foreach (Pedidos p in pedidos)
                {
                    double? valor = 0;
                    foreach (DetalhesPedido produto in p.DetalhesPedido)
                    {
                        if ((produto.Preco != null) && (produto.Qtde != null))
                            valor += produto.Preco * produto.Qtde;
                    }

                    listagemPedidos.Add("Pedido número: " + p.NroPedido + "       \trealizado na data " + p.Data.Value.ToShortDateString() + "     " + String.Format("no valor total de {0:C2}", valor));
                    if (valor != null)
                        total += valor;
                }
                valorPedidos = total;
                valorTotalPedidos = String.Format("{0:C2}", total);
                List<Clientes> clientesTemp = db.Pedidos.Where(pedido => pedido.Data >= inicio).Where(pedido => pedido.Data <= fim).Join(db.Clientes, t => t.ClienteID, g => g.ClienteID, (t, g) => g).ToList();
                List<int> ids = new List<int>();
                clientesComPedidos = 0;
                foreach (Clientes cliente in clientesTemp)
                {
                    if (!ids.Contains(cliente.ClienteID))
                    {
                        ids.Add(cliente.ClienteID);
                        clientesComPedidos++;
                    }
                }
                diasPeriodo = fim.Subtract(inicio).Days;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
