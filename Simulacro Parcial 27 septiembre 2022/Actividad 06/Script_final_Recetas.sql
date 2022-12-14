USE [master]
GO
/****** Object:  Database [recetas_db]    Script Date: 24/09/2022 23:12:35 ******/
CREATE DATABASE [recetas_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'recetas_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\recetas_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'recetas_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\recetas_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [recetas_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [recetas_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [recetas_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [recetas_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [recetas_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [recetas_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [recetas_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [recetas_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [recetas_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [recetas_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [recetas_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [recetas_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [recetas_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [recetas_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [recetas_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [recetas_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [recetas_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [recetas_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [recetas_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [recetas_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [recetas_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [recetas_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [recetas_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [recetas_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [recetas_db] SET RECOVERY FULL 
GO
ALTER DATABASE [recetas_db] SET  MULTI_USER 
GO
ALTER DATABASE [recetas_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [recetas_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [recetas_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [recetas_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [recetas_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [recetas_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'recetas_db', N'ON'
GO
ALTER DATABASE [recetas_db] SET QUERY_STORE = OFF
GO
USE [recetas_db]
GO
/****** Object:  Table [dbo].[Detalles_Receta]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Receta](
	[id_receta] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[cantidad] [numeric](5, 2) NOT NULL,
 CONSTRAINT [PK_Detalles_Receta] PRIMARY KEY CLUSTERED 
(
	[id_receta] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[id_ingrediente] [int] NOT NULL,
	[n_ingrediente] [varchar](50) NOT NULL,
	[unidad_medida] [varchar](50) NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recetas]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recetas](
	[id_receta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cheff] [varchar](100) NULL,
	[tipo_receta] [int] NOT NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[id_receta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tiposReceta]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tiposReceta](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombreTipo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (1, N'Sal', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (2, N'Pimienta', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (3, N'Agua', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (4, N'Aceite', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (5, N'carne', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (6, N'caldo', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (7, N'Azucar', N'gramos')
GO
SET IDENTITY_INSERT [dbo].[tiposReceta] ON 

INSERT [dbo].[tiposReceta] ([idTipo], [nombreTipo]) VALUES (1, N'Tradicional')
INSERT [dbo].[tiposReceta] ([idTipo], [nombreTipo]) VALUES (2, N'Vegetariana')
INSERT [dbo].[tiposReceta] ([idTipo], [nombreTipo]) VALUES (3, N'Asiática')
SET IDENTITY_INSERT [dbo].[tiposReceta] OFF
GO
ALTER TABLE [dbo].[Detalles_Receta]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Receta_Ingredientes] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingredientes] ([id_ingrediente])
GO
ALTER TABLE [dbo].[Detalles_Receta] CHECK CONSTRAINT [FK_Detalles_Receta_Ingredientes]
GO
ALTER TABLE [dbo].[Ingredientes]  WITH CHECK ADD  CONSTRAINT [FK_Ingredientes_Ingredientes] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingredientes] ([id_ingrediente])
GO
ALTER TABLE [dbo].[Ingredientes] CHECK CONSTRAINT [FK_Ingredientes_Ingredientes]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INGREDIENTES]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_INGREDIENTES]
AS
BEGIN
	
	SELECT * from Ingredientes ORDER BY 1;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPOS_RECETA]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPOS_RECETA]
AS
BEGIN
	
	SELECT * from tiposReceta ORDER BY 2;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLES]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLES] 
	@id_receta int,
	@id_ingrediente int, 
	@cantidad int
AS
BEGIN
	INSERT INTO DETALLES_RECETA(id_receta,id_ingrediente,cantidad)
    VALUES (@id_receta, @id_ingrediente, @cantidad);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_RECETA]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_RECETA] 
	@tipo_receta int,
	@nombre varchar(50),
	@cheff varchar(100)
AS
BEGIN
	INSERT INTO Recetas (nombre, cheff , tipo_receta)
    VALUES (@nombre, @cheff, @tipo_receta );

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID]    Script Date: 24/09/2022 23:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(ID_RECETA)+1  FROM RECETAS);
END
GO
USE [master]
GO
ALTER DATABASE [recetas_db] SET  READ_WRITE 
GO
