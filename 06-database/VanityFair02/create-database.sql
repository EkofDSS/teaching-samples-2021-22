USE [master]
GO

/****** Object:  Database [VanityFair02]    Script Date: 23-Nov-21 21:05:29 ******/
CREATE DATABASE [VanityFair02]
 CONTAINMENT = NONE
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VanityFair02].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VanityFair02] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VanityFair02] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VanityFair02] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VanityFair02] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VanityFair02] SET ARITHABORT OFF 
GO

ALTER DATABASE [VanityFair02] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [VanityFair02] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VanityFair02] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VanityFair02] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VanityFair02] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VanityFair02] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VanityFair02] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VanityFair02] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VanityFair02] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VanityFair02] SET  DISABLE_BROKER 
GO

ALTER DATABASE [VanityFair02] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VanityFair02] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VanityFair02] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VanityFair02] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VanityFair02] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VanityFair02] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VanityFair02] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VanityFair02] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [VanityFair02] SET  MULTI_USER 
GO

ALTER DATABASE [VanityFair02] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VanityFair02] SET DB_CHAINING OFF 
GO

ALTER DATABASE [VanityFair02] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [VanityFair02] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [VanityFair02] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [VanityFair02] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [VanityFair02] SET QUERY_STORE = OFF
GO

ALTER DATABASE [VanityFair02] SET  READ_WRITE 
GO

