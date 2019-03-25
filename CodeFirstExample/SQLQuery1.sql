﻿CREATE TABLE [dbo].[Produtos] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nome] NVARCHAR(MAX),
    [Categoria] NVARCHAR(MAX),
    [Preco] FLOAT (53),
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);

select * from produtos

sp_help produtos