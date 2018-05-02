CREATE TABLE [dbo].[Endereços]
(
	[ClienteID] INT NOT NULL , 
    [EnderecoID] INT NOT NULL IDENTITY(1,1), 
    [Rua] NCHAR(100) NULL, 
    [Cidade] NCHAR(100) NULL, 
    [Estado] NCHAR(100) NULL, 
    PRIMARY KEY ([EnderecoID]), 
    CONSTRAINT [FK_Endereços_ToTable] FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
)
