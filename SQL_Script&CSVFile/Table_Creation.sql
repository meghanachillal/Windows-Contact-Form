---- Table Creation Script
USE [CustomerDetails]
GO

CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](256) NULL,
	[LastName] [varchar](256) NULL,
	[StreetNumber] [varchar](50) NULL,
	[Address] [varchar](256) NULL,
	[City] [varchar](256) NULL,
	[Province] [varchar](256) NULL,
	[Country] [varchar](50) NULL,
	[PostalCode] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[EmailAddress] [varchar](255) NULL)
GO



