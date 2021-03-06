USE [master]
GO
/****** Object:  Database [BlackSip]    Script Date: 18/12/2019 8:51:27 p. m. ******/
CREATE DATABASE [BlackSip]
GO
/****** Object:  Table [dbo].[SiteMenu]    Script Date: 18/12/2019 8:51:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteMenu](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Url] [nvarchar](50) NULL,
	[ParentId] [int] NOT NULL,
 CONSTRAINT [PK_SiteMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitante]    Script Date: 18/12/2019 8:51:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Telefono] [bigint] NOT NULL,
	[Procesado] [bit] NOT NULL,
 CONSTRAINT [PK_Visitante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Visitante] ADD  CONSTRAINT [DF_Visitante_Procesado]  DEFAULT ((0)) FOR [Procesado]
GO
/****** Object:  StoredProcedure [dbo].[SPGETVISITANTESPROCESADOS]    Script Date: 18/12/2019 8:51:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGETVISITANTESPROCESADOS] 
AS
BEGIN
	UPDATE Visitante SET Procesado = 1 WHERE Procesado = 0;
	SELECT TOP 1 * FROM Visitante WHERE Procesado = 1 ORDER BY Id ASC;
END

GO
USE [master]
GO
ALTER DATABASE [BlackSip] SET  READ_WRITE 
GO
