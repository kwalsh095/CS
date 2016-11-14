-- Create tables and populate with seed data
--    follow naming convention: "Users" table contains rows that are each "User" objects

-- ***********  Attach ***********
CREATE DATABASE [HW5] ON
PRIMARY (NAME=[HW5], FILENAME='$(dbdir)\HW5.mdf')
LOG ON (NAME=[HW5_log], FILENAME='$(dbdir)\HW5_log.ldf');
--FOR ATTACH;
GO

USE [HW5];
GO

-- *********** Drop Tables ***********

IF OBJECT_ID('dbo.Users','U') IS NOT NULL
	DROP TABLE [dbo].[Users];
GO

IF OBJECT_ID('dbo.TestInsert','U') IS NOT NULL
	DROP TABLE [dbo].[TestInsert];
GO


-- ########### Users ###########
CREATE TABLE [dbo].[Users] (
    [ID]        INT            NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    [DOB]       DATETIME       NOT NULL,
    [Date]      DATETIME       NOT NULL,
    [Phone]     NVARCHAR (12)  NOT NULL,
    [C_year]    INT            NOT NULL,
    [Email]     NVARCHAR (255) NOT NULL,
    [Major]     NVARCHAR (50)  NOT NULL,
    [Minor]     NVARCHAR (50)  NOT NULL,
    [Advisor]   NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

BULK INSERT [dbo].[Users]
	FROM '$(dbdir)\SeedData\Users.csv'
	WITH
	(
		FIELDTERMINATOR = ',',
		ROWTERMINATOR	= '\n',
		FIRSTROW = 2
	);
GO

-- ***********  Detach ***********
USE master;
GO

ALTER DATABASE [HW5] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

EXEC sp_detach_db 'HW5', 'true'
