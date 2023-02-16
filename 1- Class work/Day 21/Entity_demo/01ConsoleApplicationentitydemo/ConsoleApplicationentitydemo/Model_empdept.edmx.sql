
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/10/2020 19:19:19
-- Generated from EDMX file: C:\Users\Shiram Mantri\Desktop\PGDAC_20_net\ConsoleApplicationentitydemo\ConsoleApplicationentitydemo\Model_empdept.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sample];
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

-- Creating table 'EMPs'
CREATE TABLE [dbo].[EMPs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] real  NOT NULL,
    [DeptId] int  NOT NULL
);
GO

-- Creating table 'Depts'
CREATE TABLE [dbo].[Depts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EMPs'
ALTER TABLE [dbo].[EMPs]
ADD CONSTRAINT [PK_EMPs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Depts'
ALTER TABLE [dbo].[Depts]
ADD CONSTRAINT [PK_Depts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptId] in table 'EMPs'
ALTER TABLE [dbo].[EMPs]
ADD CONSTRAINT [FK_DeptEMP]
    FOREIGN KEY ([DeptId])
    REFERENCES [dbo].[Depts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptEMP'
CREATE INDEX [IX_FK_DeptEMP]
ON [dbo].[EMPs]
    ([DeptId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------