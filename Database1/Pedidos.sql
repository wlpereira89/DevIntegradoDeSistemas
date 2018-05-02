CREATE TABLE [dbo].[Pedidos]
(
	[ClienteID] INT NOT NULL , 
    [NroPedido] INT IDENTITY(1,1) NOT NULL, 
    [Data] DATE NULL, 
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([NroPedido]), 
    CONSTRAINT [FK_Pedidos_Clientes] FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID) 
)
