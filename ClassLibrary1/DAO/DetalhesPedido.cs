//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalhesPedido
    {
        public int NroPedido { get; set; }
        public int ProdutoID { get; set; }
        public Nullable<int> Qtde { get; set; }
        public Nullable<double> Preco { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
