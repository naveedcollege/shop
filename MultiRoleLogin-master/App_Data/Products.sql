CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(50) NULL, 
    [description] VARCHAR(50) NULL, 
    [price] SMALLMONEY NULL, 
    [stock] INT NULL,
)
