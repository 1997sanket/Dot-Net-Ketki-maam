
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/13/2020 02:05:30
-- Generated from EDMX file: C:\Users\User\Desktop\ModelFirstApproach\ModelFirstApproach\Model_First.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mydb];
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

-- Creating table 'EmployeeTable2'
CREATE TABLE [dbo].[EmployeeTable2] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] real  NOT NULL,
    [DepartmentTable2Id] int  NOT NULL
);
GO

-- Creating table 'DepartmentTable2'
CREATE TABLE [dbo].[DepartmentTable2] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmployeeTable2'
ALTER TABLE [dbo].[EmployeeTable2]
ADD CONSTRAINT [PK_EmployeeTable2]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartmentTable2'
ALTER TABLE [dbo].[DepartmentTable2]
ADD CONSTRAINT [PK_DepartmentTable2]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmentTable2Id] in table 'EmployeeTable2'
ALTER TABLE [dbo].[EmployeeTable2]
ADD CONSTRAINT [FK_DepartmentTable2EmployeeTable2]
    FOREIGN KEY ([DepartmentTable2Id])
    REFERENCES [dbo].[DepartmentTable2]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentTable2EmployeeTable2'
CREATE INDEX [IX_FK_DepartmentTable2EmployeeTable2]
ON [dbo].[EmployeeTable2]
    ([DepartmentTable2Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------