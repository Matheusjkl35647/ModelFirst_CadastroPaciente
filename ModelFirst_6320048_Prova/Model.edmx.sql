
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2021 22:42:07
-- Generated from EDMX file: C:\Users\Mathe\Desktop\FACULDADE\3 SEMESTRE\PROGRAMAÇÃO ORIENTADA A OBJETO II\AVALIAÇÃO FINAL (SEMESTRAL)\ModelFirst_6320048_Prova\ModelFirst_6320048_Prova\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFAvaliacao];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Paciente'
CREATE TABLE [dbo].[Paciente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Exame'
CREATE TABLE [dbo].[Exame] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Medico] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [PacienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [PK_Paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Exame'
ALTER TABLE [dbo].[Exame]
ADD CONSTRAINT [PK_Exame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PacienteId] in table 'Exame'
ALTER TABLE [dbo].[Exame]
ADD CONSTRAINT [FK_PacienteExame]
    FOREIGN KEY ([PacienteId])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteExame'
CREATE INDEX [IX_FK_PacienteExame]
ON [dbo].[Exame]
    ([PacienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------