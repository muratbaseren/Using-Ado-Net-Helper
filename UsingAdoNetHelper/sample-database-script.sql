USE [master]
GO

CREATE DATABASE [SampleKmbAdoNetDatabase]
GO

USE [SampleKmbAdoNetDatabase]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 16.8.2016 11:26:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Author] [nvarchar](40) NULL,
	[Description] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE PROCEDURE MyStoredProc1
	@MinPrice decimal(18,2),
	@MaxPrice decimal(18,2)
AS
BEGIN
	SELECT [Id], [Name], [Author], [Description], [Price] 
	FROM Books
	WHERE Price > @MinPrice AND Price < @MaxPrice
END
GO

CREATE PROCEDURE MyStoredProc2
	@NewPrice decimal(18,2)
AS
BEGIN
	UPDATE Books SET Price = @NewPrice
	WHERE Author LIKE '%Charles%'
END
GO
