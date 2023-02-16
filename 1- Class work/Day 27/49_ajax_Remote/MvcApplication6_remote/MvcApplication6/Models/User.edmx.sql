
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2020 15:31:32
-- Generated from EDMX file: D:\dot_net\Day_wise\day15mvc\examples\23Radio_checkbox_dropdown\49_ajax_auto\MvcApplication6_remote\MvcApplication6\Models\User.edmx
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

IF OBJECT_ID(N'[dbo].[tbluser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbluser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

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