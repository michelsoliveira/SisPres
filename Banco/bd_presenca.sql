USE [master]
GO
/****** Object:  Database [bd_presenca]    Script Date: 25/05/2016 16:36:44 ******/
CREATE DATABASE [bd_presenca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_presenca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\bd_presenca.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bd_presenca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\bd_presenca_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [bd_presenca] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_presenca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_presenca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_presenca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_presenca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_presenca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_presenca] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_presenca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_presenca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_presenca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_presenca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_presenca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_presenca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_presenca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_presenca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_presenca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_presenca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_presenca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_presenca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_presenca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_presenca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_presenca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_presenca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_presenca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_presenca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bd_presenca] SET  MULTI_USER 
GO
ALTER DATABASE [bd_presenca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_presenca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_presenca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_presenca] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [bd_presenca] SET DELAYED_DURABILITY = DISABLED 
GO
USE [bd_presenca]
GO
/****** Object:  User [presenca]    Script Date: 25/05/2016 16:36:44 ******/
CREATE USER [presenca] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[db_datawriter]
GO
ALTER ROLE [db_datareader] ADD MEMBER [presenca]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [presenca]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[cod] [int] NOT NULL,
	[pessoa_cod] [int] NOT NULL,
	[ra] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[cod] [int] NOT NULL,
	[local_evento_cod] [int] NOT NULL,
	[Evento_local_evento_cod] [int] NULL,
	[Evento_cod] [int] NULL,
	[titulo] [text] NULL,
	[descricao] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[local_evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Local_evento]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local_evento](
	[cod] [int] NOT NULL,
	[sala] [text] NULL,
	[andar] [text] NULL,
	[bloco] [text] NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ministra]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ministra](
	[cod] [int] NOT NULL,
	[pessoa_cod] [int] NOT NULL,
	[Evento_local_evento_cod] [int] NOT NULL,
	[Evento_cod] [int] NOT NULL,
	[data_min] [date] NULL,
	[h_min] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[pessoa_cod] ASC,
	[Evento_local_evento_cod] ASC,
	[Evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Palestrante]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palestrante](
	[cod] [int] NOT NULL,
	[pessoa_cod] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Participacao]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participacao](
	[cod] [int] NOT NULL,
	[pessoa_cod] [int] NOT NULL,
	[Evento_local_evento_cod] [int] NOT NULL,
	[Evento_cod] [int] NOT NULL,
	[data_part] [date] NULL,
	[h_part] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[pessoa_cod] ASC,
	[Evento_local_evento_cod] ASC,
	[Evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [text] NULL,
 CONSTRAINT [PK__perfil__D8360F7B8CB89BB4] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[cod] [int] NOT NULL,
	[nome] [text] NULL,
	[sobrenome] [text] NULL,
	[email] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[cod] [int] NOT NULL,
	[pessoa_cod] [int] NOT NULL,
	[matricula] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/05/2016 16:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[perfil_cod] [int] NOT NULL,
	[nome] [varchar](50) NULL,
	[sobrenome] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[usuario] [varchar](50) NULL,
	[senha] [varchar](50) NULL,
 CONSTRAINT [PK__usuario__F167B89036AB3DCC] PRIMARY KEY CLUSTERED 
(
	[cod] ASC,
	[perfil_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [aluno_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [aluno_FKIndex1] ON [dbo].[Aluno]
(
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Evento_FKIndex3]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [Evento_FKIndex3] ON [dbo].[Evento]
(
	[local_evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Evento_FKIndex4]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [Evento_FKIndex4] ON [dbo].[Evento]
(
	[Evento_cod] ASC,
	[Evento_local_evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ministra_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [ministra_FKIndex1] ON [dbo].[Ministra]
(
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ministra_FKIndex2]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [ministra_FKIndex2] ON [dbo].[Ministra]
(
	[Evento_cod] ASC,
	[Evento_local_evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [palestrante_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [palestrante_FKIndex1] ON [dbo].[Palestrante]
(
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [participacao_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [participacao_FKIndex1] ON [dbo].[Participacao]
(
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [participacao_FKIndex2]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [participacao_FKIndex2] ON [dbo].[Participacao]
(
	[Evento_cod] ASC,
	[Evento_local_evento_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [professor_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [professor_FKIndex1] ON [dbo].[Professor]
(
	[pessoa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [usuario_FKIndex1]    Script Date: 25/05/2016 16:36:44 ******/
CREATE NONCLUSTERED INDEX [usuario_FKIndex1] ON [dbo].[Usuario]
(
	[perfil_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [bd_presenca] SET  READ_WRITE 
GO
