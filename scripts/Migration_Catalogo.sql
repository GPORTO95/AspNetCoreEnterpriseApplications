IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Produtos] (
    [Id] uniqueidentifier NOT NULL,
    [QuantidadeEstoque] int NOT NULL,
    [Ativo] bit NOT NULL,
    [Nome] varchar(250) NOT NULL,
    [Descricao] varchar(500) NOT NULL,
    [Imagem] varchar(250) NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [DataCadastro] datetime2 NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220401001533_Initial', N'6.0.3');
GO

COMMIT;
GO

