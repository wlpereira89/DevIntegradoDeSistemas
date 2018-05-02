CREATE TABLE [dbo].[Produtos]
(
	[ProdutoID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Descricao] NCHAR(100) NULL, 
    [Preco] FLOAT NULL
)
