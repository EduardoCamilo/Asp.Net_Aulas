
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 22:11:35
-- Generated from EDMX file: C:\Users\1530405\Source\Repos\Asp.Net_Aulas\DoaRoupa\DoaRoupa\Models\RoupaDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DoaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RoupaDoador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roupas] DROP CONSTRAINT [FK_RoupaDoador];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Roupas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roupas];
GO
IF OBJECT_ID(N'[dbo].[Doadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doadores];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Roupas'
CREATE TABLE [dbo].[Roupas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DescricaoRoupa] nvarchar(max)  NOT NULL,
    [TipoRoupa] nvarchar(max)  NOT NULL,
    [Doador_Id] int  NOT NULL
);
GO

-- Creating table 'Doadores'
CREATE TABLE [dbo].[Doadores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telefone] int  NOT NULL,
    [CPF] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Roupas'
ALTER TABLE [dbo].[Roupas]
ADD CONSTRAINT [PK_Roupas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Doadores'
ALTER TABLE [dbo].[Doadores]
ADD CONSTRAINT [PK_Doadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Doador_Id] in table 'Roupas'
ALTER TABLE [dbo].[Roupas]
ADD CONSTRAINT [FK_RoupaDoador]
    FOREIGN KEY ([Doador_Id])
    REFERENCES [dbo].[Doadores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoupaDoador'
CREATE INDEX [IX_FK_RoupaDoador]
ON [dbo].[Roupas]
    ([Doador_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------