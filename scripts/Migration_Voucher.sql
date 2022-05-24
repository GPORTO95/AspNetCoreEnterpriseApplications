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

CREATE TABLE [Vouchers] (
    [Id] uniqueidentifier NOT NULL,
    [Codigo] varchar(100) NOT NULL,
    [Percentual] decimal(18,2) NULL,
    [ValorDesconto] decimal(18,2) NULL,
    [Quantidade] int NOT NULL,
    [TipoDesconto] int NOT NULL,
    [DataCriacao] datetime2 NOT NULL,
    [DataUtilizacao] datetime2 NULL,
    [DataValidade] datetime2 NOT NULL,
    [Ativo] bit NOT NULL,
    [Utilizado] bit NOT NULL,
    CONSTRAINT [PK_Vouchers] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220524010327_Voucher', N'6.0.3');
GO

COMMIT;
GO

