
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/22/2020 21:03:07
-- Generated from EDMX file: C:\Sanket CDAC\.Net\1- Class work\Project_MVC(Demo MVC project by Maam)\Project_MVC\MvcApplication_project\MvcApplication_project\Models\Pro_Model.edmx
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

IF OBJECT_ID(N'[dbo].[Product_pro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product_pro];
GO
IF OBJECT_ID(N'[dbo].[tblusers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblusers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Product_pro'
CREATE TABLE [dbo].[Product_pro] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] real  NOT NULL,
    [Image] nvarchar(max)  NOT NULL,
    [Product_number] int  NOT NULL,
    [Brand] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tblusers'
CREATE TABLE [dbo].[tblusers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NULL,
    [UserName] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Product_pro'
ALTER TABLE [dbo].[Product_pro]
ADD CONSTRAINT [PK_Product_pro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblusers'
ALTER TABLE [dbo].[tblusers]
ADD CONSTRAINT [PK_tblusers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------