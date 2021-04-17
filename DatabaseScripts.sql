/* CREATES DATABASE */
IF NOT EXISTS(SELECT TOP 1 1 FROM sysdatabases  WHERE NAME='RealPage.Diego.ApplyTest.DB')
BEGIN
    PRINT N'Creating Database';
    CREATE DATABASE [RealPage.Diego.ApplyTest.DB];
    PRINT N'Creating Database finished';
END

PRINT N'Using Database';
USE [RealPage.Diego.ApplyTest.DB];


/***** CREATE USERS TABLE ****/
/* CREATES CUSTOMERS TABLE */
IF NOT EXISTS(SELECT TOP 1 1 FROM sysobjects WHERE NAME='Users' AND TYPE='U')
BEGIN
PRINT N'Creating Users Table';
    CREATE TABLE [dbo].[Users] (
        [UserId]       INT           IDENTITY (1, 1) NOT NULL,
        [FirstName]    VARCHAR (50)  NOT NULL,
        [LastName]     VARCHAR (50)  NULL,
        [UserName]     VARCHAR (120) NOT NULL,
        [Password]     VARCHAR (250) NOT NULL,
        [Role]         INT           NOT NULL DEFAULT 2,
        [RecordStatus] INT           NOT NULL DEFAULT 1,
        PRIMARY KEY CLUSTERED ([UserId] ASC)
    );
    PRINT N'Creating Users Table Finished';

    INSERT INTO [dbo].[Users] ([FirstName], [LastName], [UserName], [Password], [Role], [RecordStatus]) 
    VALUES (N'Real', N'Page', N'dtarenas@gmail.com', N'9b8c980631971f8cfcc83357f6e470ee6c11f08aa65fefcd2febb3e10a4f4e9c', 1, 1)

END;