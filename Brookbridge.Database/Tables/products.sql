﻿CREATE TABLE [dbo].[products]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(256) NOT NULL,
	[description] NVARCHAR(512) NOT NULL,
	[code] NVARCHAR(256) NOT NULL,
	[price] DECIMAL(8,2) NOT NULL,
	[qty] INT NOT NULL,
	[veg] BIT NOT NULL,
	[date_added] DATETIME NOT NULL
)
