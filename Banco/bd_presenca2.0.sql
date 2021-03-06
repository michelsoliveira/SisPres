USE [master]
GO

/****** Object:  Database [bd_presenca]    Script Date: 02/06/2016 08:47:34 ******/
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

ALTER DATABASE [bd_presenca] SET  READ_WRITE 
GO

