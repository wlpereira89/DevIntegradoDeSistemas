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

        public pnRelatorio (int ano, int mes)
        {            
            pedidos = new pnPedidos(new DateTime(ano, mes, 01), new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes)));
            
        }
        public pnRelatorio(int ano)
        {
            pedidos = new pnPedidos(new DateTime(ano, 01, 01), new DateTime(ano, 12, 31));

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
