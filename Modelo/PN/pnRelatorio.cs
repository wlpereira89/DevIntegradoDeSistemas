using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnRelatorio
    {
        private pnPedidos pedidos;
        public pnPedidos Pedidos { get => pedidos; set => pedidos = value; }
        private List<String> dados;
        public List<String> UltimoRelatorio { get => dados; }
        public List<String> Relatorio { get => dados; set => dados = value; }

        public pnRelatorio (int ano, int mes, char mod)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();
                dados = new List<String>();

                List<produtosMes> vendas = new List<produtosMes>();
                DateTime ini = new DateTime(ano, mes, 01);
                DateTime fim = new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes));
                List<DetalhesPedido> detalhesPedidos = db.Pedidos.Where(pedido => pedido.Data >= ini).Where(pedido => pedido.Data <= fim).Join(db.DetalhesPedido, t => t.NroPedido, g => g.NroPedido, (t, g) => g).ToList();

                foreach (DetalhesPedido detalhesPedido in detalhesPedidos)
                {
                    var produto = vendas.Find(p => p.id == detalhesPedido.ProdutoID);
                    if (produto == null)
                    {
                        produtosMes novo = new produtosMes(db.Produtos.Find(detalhesPedido.ProdutoID));
                        novo.vendidos += (int)detalhesPedido.Qtde;
                        novo.valor += (double)detalhesPedido.Preco * (int)detalhesPedido.Qtde;
                        vendas.Add(novo);
                    }
                    else
                    {
                        produto.vendidos += (int)detalhesPedido.Qtde;
                        produto.valor += (double)detalhesPedido.Preco * (int)detalhesPedido.Qtde;
                    }
                }
                foreach (produtosMes v in vendas)
                {
                    String a = "Produto: " + v.desc.Trim() + " id: " + v.id + " vendidos: " + v.vendidos + " valor total das vendas " + String.Format("{0:C2}",v.valor);
                    dados.Add(a);
                }

            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public pnRelatorio(int ano)
        {
            pedidos = new pnPedidos(new DateTime(ano, 01, 01), new DateTime(ano, 12, 31));

        }
        public pnRelatorio(int ano, int mes)
        {
            pedidos = new pnPedidos(new DateTime(ano, mes, 01), new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes)));            
        }
        public List<String> gerarRelatorio()
        {
            dados = new List<String>();
            String a = "Total Faturado no periodo: " + pedidos.ValorTotalPedidos;
            dados.Add(a);
            String b = "Total de pedidos do periodo: " + pedidos.Pedidos.Count;
            dados.Add(b);
            String c = "Numero Médio de pedidos por dia: " + Convert.ToInt32(pedidos.Pedidos.Count/pedidos.DiasPeriodo);
            dados.Add(c);
            String d = "Numero de clientes que realizaram pedidos no periodo: " + pedidos.ClienteComPedidos;
            dados.Add(d);
            String e = "Numero Médio de pedidos por cliente no periodo? " + pedidos.Pedidos.Count / pedidos.ClienteComPedidos;
            dados.Add(e);
            String f = ("Tiquet Médio das vendas: " + String.Format("{0:C2}", pedidos.ValorPedidos / pedidos.Pedidos.Count));
            dados.Add(f);

            return dados;
        }
    }
}
