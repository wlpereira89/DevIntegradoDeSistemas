CREATE TABLE [dbo].[DetalhesPedido]
(
	[NroPedido] INT NOT NULL , 
    [ProdutoID] INT NOT NULL, 
    [Qtde] INT NULL, 
    [Preco] FLOAT NULL, 
    PRIMARY KEY ([ProdutoID], [NroPedido]), 
    CONSTRAINT [FK_DetalhesPedido_Produtos] FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID), 
    CONSTRAINT [FK_DetalhesPedido_Pedidos] FOREIGN KEY (NroPedido) REFERENCES Pedidos(NroPedido)
)
