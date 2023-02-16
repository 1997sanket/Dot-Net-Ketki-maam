
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2020 13:04:54
-- Generated from EDMX file: C:\Users\Shiram Mantri\Desktop\PGDAC_20_net\MvcApplicationModel_first\MvcApplicationModel_first\Models\Modelempdept.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Demodata];
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

-- Creating table 'Empdacs'
CREATE TABLE [dbo].[Empdacs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] real  NOT NULL,
    [DeptdacId] int  NOT NULL
);
GO

-- Creating table 'Deptdacs'
CREATE TABLE [dbo].[Deptdacs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Empdacs'
ALTER TABLE [dbo].[Empdacs]
ADD CONSTRAINT [PK_Empdacs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deptdacs'
ALTER TABLE [dbo].[Deptdacs]
ADD CONSTRAINT [PK_Deptdacs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptdacId] in table 'Empdacs'
ALTER TABLE [dbo].[Empdacs]
ADD CONSTRAINT [FK_DeptdacEmpdac]
    FOREIGN KEY ([DeptdacId])
    REFERENCES [dbo].[Deptdacs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptdacEmpdac'
CREATE INDEX [IX_FK_DeptdacEmpdac]
ON [dbo].[Empdacs]
    ([DeptdacId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------