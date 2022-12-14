USE [master]
GO
/****** Object:  Database [planesCarrera]    Script Date: 27/08/2022 17:34:02 ******/
CREATE DATABASE [planesCarrera]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'planesCarrera', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\planesCarrera.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'planesCarrera_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\planesCarrera_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [planesCarrera] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [planesCarrera].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [planesCarrera] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [planesCarrera] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [planesCarrera] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [planesCarrera] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [planesCarrera] SET ARITHABORT OFF 
GO
ALTER DATABASE [planesCarrera] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [planesCarrera] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [planesCarrera] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [planesCarrera] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [planesCarrera] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [planesCarrera] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [planesCarrera] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [planesCarrera] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [planesCarrera] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [planesCarrera] SET  ENABLE_BROKER 
GO
ALTER DATABASE [planesCarrera] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [planesCarrera] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [planesCarrera] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [planesCarrera] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [planesCarrera] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [planesCarrera] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [planesCarrera] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [planesCarrera] SET RECOVERY FULL 
GO
ALTER DATABASE [planesCarrera] SET  MULTI_USER 
GO
ALTER DATABASE [planesCarrera] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [planesCarrera] SET DB_CHAINING OFF 
GO
ALTER DATABASE [planesCarrera] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [planesCarrera] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [planesCarrera] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [planesCarrera] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'planesCarrera', N'ON'
GO
ALTER DATABASE [planesCarrera] SET QUERY_STORE = OFF
GO
USE [planesCarrera]
GO
/****** Object:  Table [dbo].[Asignaturas]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaturas](
	[materia] [varchar](20) NOT NULL,
	[idAsignatura] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[idCarrera] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[titulo] [varchar](25) NULL,
 CONSTRAINT [pk_carreras] PRIMARY KEY CLUSTERED 
(
	[idCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detallesCarrera]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallesCarrera](
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
	[anioCursado] [tinyint] NOT NULL,
	[cuatrimestre] [tinyint] NOT NULL,
	[materia] [varchar](20) NULL,
	[carrera] [int] NULL,
 CONSTRAINT [PK_Detalles] PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC,
	[anioCursado] ASC,
	[cuatrimestre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asignaturas] ON 

INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Ingles I', 1)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Ingles II', 2)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Ingles III', 3)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Ingles IV', 14)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Ingles V', 15)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Matemática I', 4)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Matemática II', 5)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Matemática III', 6)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Matemática IV', 12)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Programacion I', 7)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Programación II', 8)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Programacion III', 9)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Programacion IV', 10)
INSERT [dbo].[Asignaturas] ([materia], [idAsignatura]) VALUES (N'Programacion V', 11)
SET IDENTITY_INSERT [dbo].[Asignaturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Carreras] ON 

INSERT [dbo].[Carreras] ([idCarrera], [nombre], [titulo]) VALUES (20, N'Programacion', N'Programador')
INSERT [dbo].[Carreras] ([idCarrera], [nombre], [titulo]) VALUES (23, N'zzzzzzzzzzzzzzz', N'xxxxxxxxxxxxx')
INSERT [dbo].[Carreras] ([idCarrera], [nombre], [titulo]) VALUES (24, N'yyyyyyyyyyyyyy', N'uuuuuuuuuuuu')
SET IDENTITY_INSERT [dbo].[Carreras] OFF
GO
SET IDENTITY_INSERT [dbo].[detallesCarrera] ON 

INSERT [dbo].[detallesCarrera] ([idDetalle], [anioCursado], [cuatrimestre], [materia], [carrera]) VALUES (2, 1, 1, N'Ingles I', 22)
INSERT [dbo].[detallesCarrera] ([idDetalle], [anioCursado], [cuatrimestre], [materia], [carrera]) VALUES (3, 1, 1, N'Ingles I', 25)
SET IDENTITY_INSERT [dbo].[detallesCarrera] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_ASIGNATURA]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CARGAR_ASIGNATURA]
	@Nombre varchar(20)
AS
BEGIN
    -- Insert statements for procedure here
	INSERT INTO Asignaturas (materia)
	values (@Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_CARRERAS]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CARGAR_CARRERAS]
	@carrera varchar(20),
	@titulo varchar(25)

AS
BEGIN
	insert into Carreras (nombre,titulo)
	values(@carrera,@titulo)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_PLANES]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CARGAR_PLANES]
	@anio int,
	@cuatrimestre int,
	@materia varchar(20),
	@carrera int

AS
BEGIN
    INSERT INTO detallesCarrera(anioCursado,cuatrimestre,materia,carrera)
	values (@anio,@cuatrimestre,@materia,@carrera)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_carreras]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_carreras]
AS
BEGIN
	SELECT nombre as Carrera, titulo as Título from carreras
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_programas]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Consultar_programas] 
	-- Add the parameters for the stored procedure here
	@carrera int
AS
BEGIN
	SELECT * FROM dbo.detallesCarrera WHERE carrera = @carrera
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ULTIMA_CARRERA]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ULTIMA_CARRERA]
	
	@NewId int OUTPUT

AS
BEGIN
   SET @NewId = (select max(idCarrera)+1 from carreras)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_ASIGNATURAS]    Script Date: 27/08/2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_OBTENER_ASIGNATURAS]
AS
BEGIN
	SELECT * FROM Asignaturas
END
GO
USE [master]
GO
ALTER DATABASE [planesCarrera] SET  READ_WRITE 
GO
