USE [master]
GO
/****** Object:  Database [Buteco]    Script Date: 25/10/2020 16:33:58 ******/
CREATE DATABASE [Buteco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Buteco', FILENAME = N'E:\sql\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Buteco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Buteco_log', FILENAME = N'E:\sql\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Buteco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Buteco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Buteco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Buteco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Buteco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Buteco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Buteco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Buteco] SET ARITHABORT OFF 
GO
ALTER DATABASE [Buteco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Buteco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Buteco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Buteco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Buteco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Buteco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Buteco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Buteco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Buteco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Buteco] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Buteco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Buteco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Buteco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Buteco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Buteco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Buteco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Buteco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Buteco] SET RECOVERY FULL 
GO
ALTER DATABASE [Buteco] SET  MULTI_USER 
GO
ALTER DATABASE [Buteco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Buteco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Buteco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Buteco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Buteco] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Buteco', N'ON'
GO
ALTER DATABASE [Buteco] SET QUERY_STORE = OFF
GO
USE [Buteco]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 25/10/2020 16:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NOT NULL,
	[CNPJ] [varchar](255) NOT NULL,
	[Endereco] [varchar](255) NOT NULL,
	[Tipo] [varchar](255) NOT NULL,
	[Telefone] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 25/10/2020 16:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NOT NULL,
	[valor] [varchar](255) NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
	[Quantidade] [varchar](255) NOT NULL,
	[Categoria] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/10/2020 16:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](32) NOT NULL,
	[usuario] [varchar](32) NOT NULL,
	[senha] [varchar](32) NOT NULL,
	[endereco] [varchar](32) NOT NULL,
	[email] [varchar](32) NOT NULL,
	[telefone] [varchar](32) NOT NULL,
	[cpf] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Fornecedor] ON 

INSERT [dbo].[Fornecedor] ([ID], [nome], [CNPJ], [Endereco], [Tipo], [Telefone]) VALUES (2, N'Seu Zé bebidas', N'99,999,999/9999-99', N'Rua seu Ze,3030', N'Bebidas', N'(99)99999-9999')
SET IDENTITY_INSERT [dbo].[Fornecedor] OFF
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([ID], [nome], [valor], [Descricao], [Quantidade], [Categoria]) VALUES (1, N'Batata Frita', N'25.00', N'Batata frita prato 500g', N'2', N'Petiscos')
SET IDENTITY_INSERT [dbo].[Produto] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [nome], [usuario], [senha], [endereco], [email], [telefone], [cpf]) VALUES (1, N'Marcelo Felix', N'felix.marcelo', N'123', N'rua joao kleber', N'felix.marcelo@ifsp.edu.br', N'(12)99999-9999', N'999.999.999-99')
INSERT [dbo].[Usuarios] ([ID], [nome], [usuario], [senha], [endereco], [email], [telefone], [cpf]) VALUES (2, N'Joao Kleber', N'joao.kleber', N'123', N'rua abcbfcb', N'aluno@joao.ifsp', N'(12) 99999-9999', N'999,999,999-99')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
USE [master]
GO
ALTER DATABASE [Buteco] SET  READ_WRITE 
GO
