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

CREATE TABLE [Clientes] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Email] varchar(254) NULL,
    [Cpf] varchar(11) NULL,
    [Excluido] bit NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [Logradouro] varchar(200) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(250) NULL,
    [Bairro] varchar(100) NOT NULL,
    [Cep] varchar(20) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(50) NOT NULL,
    [ClienteId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id])
);
GO

CREATE UNIQUE INDEX [IX_Enderecos_ClienteId] ON [Enderecos] ([ClienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220408004012_Clientes', N'6.0.3');
GO

COMMIT;
GO

