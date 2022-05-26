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

CREATE TABLE [CarrinhoCliente] (
    [Id] uniqueidentifier NOT NULL,
    [ClienteId] uniqueidentifier NOT NULL,
    [ValorTotal] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_CarrinhoCliente] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CarrinhoItens] (
    [Id] uniqueidentifier NOT NULL,
    [ProdutoId] uniqueidentifier NOT NULL,
    [Nome] varchar(100) NULL,
    [Quantidade] int NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [Imagem] varchar(100) NULL,
    [CarrinhoId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_CarrinhoItens] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CarrinhoItens_CarrinhoCliente_CarrinhoId] FOREIGN KEY ([CarrinhoId]) REFERENCES [CarrinhoCliente] ([Id])
);
GO

CREATE INDEX [IDX_Cliente] ON [CarrinhoCliente] ([ClienteId]);
GO

CREATE INDEX [IX_CarrinhoItens_CarrinhoId] ON [CarrinhoItens] ([CarrinhoId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220426014418_Carrinho', N'6.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [CarrinhoCliente] ADD [Desconto] decimal(18,2) NOT NULL DEFAULT 0.0;
GO

ALTER TABLE [CarrinhoCliente] ADD [Percentual] decimal(18,2) NULL;
GO

ALTER TABLE [CarrinhoCliente] ADD [TipoDesconto] int NULL;
GO

ALTER TABLE [CarrinhoCliente] ADD [ValorDesconto] decimal(18,2) NULL;
GO

ALTER TABLE [CarrinhoCliente] ADD [VoucherCodigo] varchar(50) NULL;
GO

ALTER TABLE [CarrinhoCliente] ADD [VoucherUtilizado] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220526020654_Voucher', N'6.0.3');
GO

COMMIT;
GO

