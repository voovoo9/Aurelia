﻿CREATE TABLE [dbo].[Form]
(
	[Id] INT IDENTITY (1,1) NOT NULL,
	[Email]	NVARCHAR (50) NULL,
	[FirstName] NVARCHAR (50) NULL,
	[LastName] NVARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)