USE [MiniErp]
GO
ALTER TABLE [dbo].[tbPessoaJuridica] DROP CONSTRAINT [FK_tbPessoaJuridica_tbPessoa]
GO
ALTER TABLE [dbo].[tbPessoaFisica] DROP CONSTRAINT [FK_tbPessoaFisica_tbPessoa]
GO
ALTER TABLE [dbo].[tbPessoa] DROP CONSTRAINT [FK_tbPessoa_tbTipoPessoa]
GO
ALTER TABLE [dbo].[tbEstado] DROP CONSTRAINT [FK_tbEstado_tbPais]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] DROP CONSTRAINT [FK_tbEnderecoPessoa_tbTipoEndereco]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] DROP CONSTRAINT [FK_tbEnderecoPessoa_tbPessoa]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] DROP CONSTRAINT [FK_tbEnderecoPessoa_tbEndereco]
GO
ALTER TABLE [dbo].[tbEndereco] DROP CONSTRAINT [FK_tbEndereco_tbLogradouro]
GO
ALTER TABLE [dbo].[tbEndereco] DROP CONSTRAINT [FK_tbEndereco_tbBairro]
GO
ALTER TABLE [dbo].[tbContatoPessoa] DROP CONSTRAINT [FK_tbContatoPessoa_tbTipoContato]
GO
ALTER TABLE [dbo].[tbContatoPessoa] DROP CONSTRAINT [FK_tbContatoPessoa_tbPessoa]
GO
ALTER TABLE [dbo].[tbCidade] DROP CONSTRAINT [FK_tbCidade_tbEstado]
GO
ALTER TABLE [dbo].[tbBairro] DROP CONSTRAINT [FK_tbBairro_tbCidade]
GO
/****** Object:  Table [dbo].[tbTipoPessoa]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbTipoPessoa]
GO
/****** Object:  Table [dbo].[tbTipoEndereco]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbTipoEndereco]
GO
/****** Object:  Table [dbo].[tbTipoContato]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbTipoContato]
GO
/****** Object:  Table [dbo].[tbPessoaJuridica]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbPessoaJuridica]
GO
/****** Object:  Table [dbo].[tbPessoaFisica]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbPessoaFisica]
GO
/****** Object:  Table [dbo].[tbPessoa]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbPessoa]
GO
/****** Object:  Table [dbo].[tbPais]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbPais]
GO
/****** Object:  Table [dbo].[tbLogradouro]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbLogradouro]
GO
/****** Object:  Table [dbo].[tbEstado]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbEstado]
GO
/****** Object:  Table [dbo].[tbEnderecoPessoa]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbEnderecoPessoa]
GO
/****** Object:  Table [dbo].[tbEndereco]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbEndereco]
GO
/****** Object:  Table [dbo].[tbContatoPessoa]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbContatoPessoa]
GO
/****** Object:  Table [dbo].[tbCidade]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbCidade]
GO
/****** Object:  Table [dbo].[tbBairro]    Script Date: 27/08/2018 21:20:23 ******/
DROP TABLE [dbo].[tbBairro]
GO
/****** Object:  UserDefinedFunction [dbo].[ZerosEsquerda]    Script Date: 27/08/2018 21:20:23 ******/
DROP FUNCTION [dbo].[ZerosEsquerda]
GO
USE [master]
GO
/****** Object:  Database [MiniErp]    Script Date: 27/08/2018 21:20:23 ******/
DROP DATABASE [MiniErp]
GO
/****** Object:  Database [MiniErp]    Script Date: 27/08/2018 21:20:23 ******/
CREATE DATABASE [MiniErp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniErp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MiniErp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MiniErp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MiniErp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE Latin1_General_CI_AS
GO
ALTER DATABASE [MiniErp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniErp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniErp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniErp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniErp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniErp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniErp] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniErp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MiniErp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniErp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniErp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniErp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniErp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniErp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniErp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniErp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniErp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MiniErp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniErp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniErp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniErp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniErp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniErp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniErp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniErp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MiniErp] SET  MULTI_USER 
GO
ALTER DATABASE [MiniErp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniErp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniErp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniErp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MiniErp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MiniErp] SET QUERY_STORE = OFF
GO
USE [MiniErp]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MiniErp]
GO
/****** Object:  UserDefinedFunction [dbo].[ZerosEsquerda]    Script Date: 27/08/2018 21:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ZerosEsquerda]
(
	@Tamanho INT,
	@Valor Varchar (MAX)
)
RETURNS VARCHAR(MAX)
AS
BEGIN

	DECLARE @Retorno AS VARCHAR (MAX)

		IF (LEN(@Valor) <= @Tamanho )
			BEGIN
				SET @Retorno = REPLICATE('0', @Tamanho - LEN(@Valor)) + @Valor
			END
		ELSE

		SET @Retorno = @Valor

	RETURN @Retorno

END
GO
/****** Object:  Table [dbo].[tbBairro]    Script Date: 27/08/2018 21:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBairro](
	[idBairro] [int] IDENTITY(1,1) NOT NULL,
	[dscBairro] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
	[idCidade] [int] NULL,
 CONSTRAINT [PK__tbBairro__86B592A1F87939CB] PRIMARY KEY CLUSTERED 
(
	[idBairro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCidade]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCidade](
	[idCidade] [int] IDENTITY(1,1) NOT NULL,
	[dscCidade] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK__tbCidade__559AD0FE4BBFFE34] PRIMARY KEY CLUSTERED 
(
	[idCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbContatoPessoa]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbContatoPessoa](
	[idContato] [int] IDENTITY(1,1) NOT NULL,
	[idPessoa] [int] NULL,
	[idTipoContato] [int] NULL,
	[valorContato] [varchar](100) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbContat__278E896D4A196213] PRIMARY KEY CLUSTERED 
(
	[idContato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEndereco]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEndereco](
	[idEndereco] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
	[idLogradouro] [int] NULL,
	[cep] [varchar](8) COLLATE Latin1_General_CI_AS NULL,
	[obs] [varchar](1000) COLLATE Latin1_General_CI_AS NULL,
	[idBairro] [int] NULL,
 CONSTRAINT [PK__tbEndere__E45B8B275734AC26] PRIMARY KEY CLUSTERED 
(
	[idEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEnderecoPessoa]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEnderecoPessoa](
	[idPessoa] [int] NULL,
	[idEndereco] [int] NULL,
	[idTipoEndereco] [int] NULL,
	[numero] [int] NULL,
	[complemento] [varchar](200) COLLATE Latin1_General_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEstado]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEstado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[dscEstado] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
	[idPais] [int] NULL,
 CONSTRAINT [PK__tbEstado__62EA894AB1EA790E] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbLogradouro]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLogradouro](
	[idLogradouro] [int] IDENTITY(1,1) NOT NULL,
	[descLogradouro] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbLograd__C2023C435349A46F] PRIMARY KEY CLUSTERED 
(
	[idLogradouro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPais]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPais](
	[idPais] [int] IDENTITY(1,1) NOT NULL,
	[dscPais] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbPais__BD2285E3326C87C4] PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPessoa]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPessoa](
	[idPessoa] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](200) COLLATE Latin1_General_CI_AS NULL,
	[idTipoPessoa] [int] NULL,
 CONSTRAINT [PK_tbPessoa] PRIMARY KEY CLUSTERED 
(
	[idPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPessoaFisica]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPessoaFisica](
	[idPessoaFisica] [int] IDENTITY(1,1) NOT NULL,
	[idPessoa] [int] NULL,
	[cpf] [varchar](20) COLLATE Latin1_General_CI_AS NULL,
	[rg] [varchar](20) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_tbPessoaFisica] PRIMARY KEY CLUSTERED 
(
	[idPessoaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPessoaJuridica]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPessoaJuridica](
	[idPessoaJuridica] [int] IDENTITY(1,1) NOT NULL,
	[idPessoa] [int] NULL,
	[cnpj] [varchar](20) COLLATE Latin1_General_CI_AS NULL,
	[inscEstadual] [varchar](20) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_tbPessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[idPessoaJuridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoContato]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoContato](
	[idTipoContato] [int] IDENTITY(1,1) NOT NULL,
	[tipoContato] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbTipoCo__3E7CA59A6A6E8C56] PRIMARY KEY CLUSTERED 
(
	[idTipoContato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoEndereco]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoEndereco](
	[idTipoEndereco] [int] IDENTITY(1,1) NOT NULL,
	[tipoEndereco] [varchar](300) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbTipoEn__C6C1DCEBFD08F235] PRIMARY KEY CLUSTERED 
(
	[idTipoEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoPessoa]    Script Date: 27/08/2018 21:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoPessoa](
	[idTipoPessoa] [int] IDENTITY(1,1) NOT NULL,
	[dscTipoPessoa] [varchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK__tbTipoPe__6640F98AE75FB4BE] PRIMARY KEY CLUSTERED 
(
	[idTipoPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbEstado] ON 

INSERT [dbo].[tbEstado] ([idEstado], [dscEstado], [idPais]) VALUES (1, N'São Paulo', 1)
SET IDENTITY_INSERT [dbo].[tbEstado] OFF
SET IDENTITY_INSERT [dbo].[tbPais] ON 

INSERT [dbo].[tbPais] ([idPais], [dscPais]) VALUES (1, N'Brasil')
INSERT [dbo].[tbPais] ([idPais], [dscPais]) VALUES (2, N'USA')
SET IDENTITY_INSERT [dbo].[tbPais] OFF
ALTER TABLE [dbo].[tbBairro]  WITH CHECK ADD  CONSTRAINT [FK_tbBairro_tbCidade] FOREIGN KEY([idCidade])
REFERENCES [dbo].[tbCidade] ([idCidade])
GO
ALTER TABLE [dbo].[tbBairro] CHECK CONSTRAINT [FK_tbBairro_tbCidade]
GO
ALTER TABLE [dbo].[tbCidade]  WITH CHECK ADD  CONSTRAINT [FK_tbCidade_tbEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[tbEstado] ([idEstado])
GO
ALTER TABLE [dbo].[tbCidade] CHECK CONSTRAINT [FK_tbCidade_tbEstado]
GO
ALTER TABLE [dbo].[tbContatoPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbContatoPessoa_tbPessoa] FOREIGN KEY([idPessoa])
REFERENCES [dbo].[tbPessoa] ([idPessoa])
GO
ALTER TABLE [dbo].[tbContatoPessoa] CHECK CONSTRAINT [FK_tbContatoPessoa_tbPessoa]
GO
ALTER TABLE [dbo].[tbContatoPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbContatoPessoa_tbTipoContato] FOREIGN KEY([idTipoContato])
REFERENCES [dbo].[tbTipoContato] ([idTipoContato])
GO
ALTER TABLE [dbo].[tbContatoPessoa] CHECK CONSTRAINT [FK_tbContatoPessoa_tbTipoContato]
GO
ALTER TABLE [dbo].[tbEndereco]  WITH CHECK ADD  CONSTRAINT [FK_tbEndereco_tbBairro] FOREIGN KEY([idBairro])
REFERENCES [dbo].[tbBairro] ([idBairro])
GO
ALTER TABLE [dbo].[tbEndereco] CHECK CONSTRAINT [FK_tbEndereco_tbBairro]
GO
ALTER TABLE [dbo].[tbEndereco]  WITH CHECK ADD  CONSTRAINT [FK_tbEndereco_tbLogradouro] FOREIGN KEY([idLogradouro])
REFERENCES [dbo].[tbLogradouro] ([idLogradouro])
GO
ALTER TABLE [dbo].[tbEndereco] CHECK CONSTRAINT [FK_tbEndereco_tbLogradouro]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbEnderecoPessoa_tbEndereco] FOREIGN KEY([idEndereco])
REFERENCES [dbo].[tbEndereco] ([idEndereco])
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] CHECK CONSTRAINT [FK_tbEnderecoPessoa_tbEndereco]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbEnderecoPessoa_tbPessoa] FOREIGN KEY([idPessoa])
REFERENCES [dbo].[tbPessoa] ([idPessoa])
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] CHECK CONSTRAINT [FK_tbEnderecoPessoa_tbPessoa]
GO
ALTER TABLE [dbo].[tbEnderecoPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbEnderecoPessoa_tbTipoEndereco] FOREIGN KEY([idTipoEndereco])
REFERENCES [dbo].[tbTipoEndereco] ([idTipoEndereco])
GO
ALTER TABLE [dbo].[tbEnderecoPessoa] CHECK CONSTRAINT [FK_tbEnderecoPessoa_tbTipoEndereco]
GO
ALTER TABLE [dbo].[tbEstado]  WITH CHECK ADD  CONSTRAINT [FK_tbEstado_tbPais] FOREIGN KEY([idPais])
REFERENCES [dbo].[tbPais] ([idPais])
GO
ALTER TABLE [dbo].[tbEstado] CHECK CONSTRAINT [FK_tbEstado_tbPais]
GO
ALTER TABLE [dbo].[tbPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tbPessoa_tbTipoPessoa] FOREIGN KEY([idTipoPessoa])
REFERENCES [dbo].[tbTipoPessoa] ([idTipoPessoa])
GO
ALTER TABLE [dbo].[tbPessoa] CHECK CONSTRAINT [FK_tbPessoa_tbTipoPessoa]
GO
ALTER TABLE [dbo].[tbPessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_tbPessoaFisica_tbPessoa] FOREIGN KEY([idPessoa])
REFERENCES [dbo].[tbPessoa] ([idPessoa])
GO
ALTER TABLE [dbo].[tbPessoaFisica] CHECK CONSTRAINT [FK_tbPessoaFisica_tbPessoa]
GO
ALTER TABLE [dbo].[tbPessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_tbPessoaJuridica_tbPessoa] FOREIGN KEY([idPessoa])
REFERENCES [dbo].[tbPessoa] ([idPessoa])
GO
ALTER TABLE [dbo].[tbPessoaJuridica] CHECK CONSTRAINT [FK_tbPessoaJuridica_tbPessoa]
GO
USE [master]
GO
ALTER DATABASE [MiniErp] SET  READ_WRITE 
GO
