using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class produtosMes
    {
        public int id;
        public String desc;
        public int vendidos;
        public double valor;
        public produtosMes(Produtos prod)
        {
            this.id = prod.ProdutoID;
            desc = prod.Descricao;
            vendidos = 0;
            valor = 0;
        }
    }
}
