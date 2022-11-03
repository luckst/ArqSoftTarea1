USE [master]
GO

/****** Object:  Database [CrudDB]    Script Date: 2/11/2022 8:13:37 p. m. ******/
CREATE DATABASE [CrudDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CrudDB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CrudDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CrudDB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CrudDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CrudDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CrudDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CrudDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CrudDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CrudDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CrudDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [CrudDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CrudDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CrudDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CrudDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CrudDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CrudDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CrudDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CrudDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CrudDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CrudDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CrudDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CrudDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CrudDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CrudDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CrudDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CrudDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CrudDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CrudDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [CrudDB] SET  MULTI_USER 
GO

ALTER DATABASE [CrudDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CrudDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CrudDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CrudDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CrudDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CrudDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CrudDB] SET  READ_WRITE 
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2/11/2022 8:12:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[LastName] [varchar](150) NOT NULL,
	[FirstMidName] [varchar](150) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO