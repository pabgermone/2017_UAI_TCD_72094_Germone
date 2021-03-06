USE [master]
GO
/****** Object:  Database [Diploma2017_VentaPasajes]    Script Date: 2/11/2017 11:48:39 a. m. ******/
CREATE DATABASE [Diploma2017_VentaPasajes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Diploma2017_VentaPasajes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Diploma2017_VentaPasajes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Diploma2017_VentaPasajes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Diploma2017_VentaPasajes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Diploma2017_VentaPasajes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET RECOVERY FULL 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET  MULTI_USER 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Diploma2017_VentaPasajes', N'ON'
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET QUERY_STORE = OFF
GO
USE [Diploma2017_VentaPasajes]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Diploma2017_VentaPasajes]
GO
/****** Object:  Table [dbo].[Aerolinea]    Script Date: 2/11/2017 11:48:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aerolinea](
	[aerolinea_id] [int] IDENTITY(1,1) NOT NULL,
	[aerolinea_nombre] [varchar](100) NULL,
 CONSTRAINT [PK__Aeroline__039221DD7F60ED59] PRIMARY KEY CLUSTERED 
(
	[aerolinea_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asiento]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asiento](
	[asiento_numero] [int] IDENTITY(1,1) NOT NULL,
	[asiento_vuelo_numero] [varchar](10) NOT NULL,
	[asiento_clase] [varchar](50) NOT NULL,
	[asiento_ocupado] [bit] NOT NULL,
 CONSTRAINT [PK__Asiento__C41DDDFE0BC6C43E] PRIMARY KEY CLUSTERED 
(
	[asiento_numero] ASC,
	[asiento_vuelo_numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[bitacora_id] [int] IDENTITY(1,1) NOT NULL,
	[bitacora_usuario] [varchar](50) NOT NULL,
	[bitacora_fecha] [date] NOT NULL,
	[bitacora_descripcion] [varchar](200) NOT NULL,
	[bitacora_dv] [int] NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[bitacora_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[cliente_id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_nombre] [varchar](50) NULL,
	[cliente_apellido] [varchar](50) NULL,
	[cliente_tipoDocumento] [varchar](50) NULL,
	[cliente_numeroDocumento] [int] NULL,
	[cliente_pasaporte] [int] NULL,
	[cliente_fechaNac] [date] NULL,
	[cliente_pais] [varchar](50) NULL,
	[cliente_direccion] [varchar](100) NULL,
	[cliente_codPostal] [int] NULL,
	[cliente_dv] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[cliente_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Destino]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destino](
	[destino_id] [int] IDENTITY(1,1) NOT NULL,
	[destino_nombre] [varchar](60) NULL,
 CONSTRAINT [PK__Destino__3B72E2A803317E3D] PRIMARY KEY CLUSTERED 
(
	[destino_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DVV]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[dvv_id] [int] IDENTITY(1,1) NOT NULL,
	[dvv_tabla] [varchar](50) NOT NULL,
	[dvv_digito] [int] NOT NULL,
	[dvv_fechaVerificacion] [date] NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[dvv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Email]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Email](
	[email_id] [int] IDENTITY(1,1) NOT NULL,
	[email_direccion] [varchar](50) NOT NULL,
	[email_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[email_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[idioma_id] [int] IDENTITY(1,1) NOT NULL,
	[idioma_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[idioma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paquete]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paquete](
	[paquete_id] [int] IDENTITY(1,1) NOT NULL,
	[paquete_descripcion] [varchar](140) NULL,
 CONSTRAINT [PK__Paquete__5CD980851A14E395] PRIMARY KEY CLUSTERED 
(
	[paquete_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[permiso_id] [int] IDENTITY(1,1) NOT NULL,
	[permiso_nombre] [varchar](50) NOT NULL,
	[permiso_padre] [int] NOT NULL,
	[permiso_formulario] [varchar](50) NULL,
	[permiso_dv] [int] NULL,
 CONSTRAINT [PK__Permiso__60B569CD22AA2996] PRIMARY KEY CLUSTERED 
(
	[permiso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PermisoCompuesto]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisoCompuesto](
	[permisoCompuesto_id] [int] IDENTITY(1,1) NOT NULL,
	[permisoCompuesto_nombre] [varchar](50) NOT NULL,
	[permisoCompuesto_padre] [int] NULL,
	[permisoCompuesto_formulario] [varchar](50) NULL,
	[permisoCompuesto_dv] [int] NULL,
 CONSTRAINT [PK__PermisoC__6E99017F1DE57479] PRIMARY KEY CLUSTERED 
(
	[permisoCompuesto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[rol_id] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [varchar](50) NOT NULL,
	[rol_dv] [int] NULL,
 CONSTRAINT [PK__Rol__CF32E443276EDEB3] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RolPermiso]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolPermiso](
	[rolPermiso_rol] [int] NOT NULL,
	[rolPermiso_permiso] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rolPermiso_rol] ASC,
	[rolPermiso_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RolPermisoCompuesto]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolPermisoCompuesto](
	[rolPermisoCompuesto_rol] [int] NOT NULL,
	[rolPermisoCompuesto_Permiso] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rolPermisoCompuesto_rol] ASC,
	[rolPermisoCompuesto_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[telefono_id] [int] IDENTITY(1,1) NOT NULL,
	[telefono_numero] [int] NOT NULL,
	[telefono_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[telefono_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Texto]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Texto](
	[texto_id] [int] IDENTITY(1,1) NOT NULL,
	[texto_texto] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Texto] PRIMARY KEY CLUSTERED 
(
	[texto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TextoIdioma]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TextoIdioma](
	[textoIdioma_texto] [int] NOT NULL,
	[textoIdioma_idioma] [int] NOT NULL,
	[textoIdioma_traduccion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_TextoIdioma] PRIMARY KEY CLUSTERED 
(
	[textoIdioma_texto] ASC,
	[textoIdioma_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_userName] [varchar](50) NOT NULL,
	[usuario_nombre] [varchar](50) NOT NULL,
	[usuario_apellido] [varchar](50) NOT NULL,
	[usuario_password] [varchar](50) NOT NULL,
	[usuario_rol] [int] NULL,
	[usuario_dv] [int] NULL,
 CONSTRAINT [PK__Usuario__2ED7D2AF36B12243] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[venta_id] [int] IDENTITY(1,1) NOT NULL,
	[venta_usuario] [int] NOT NULL,
	[venta_fecha] [date] NOT NULL,
	[venta_paquete] [int] NULL,
	[venta_dv] [int] NULL,
 CONSTRAINT [PK__Venta__B13508093E52440B] PRIMARY KEY CLUSTERED 
(
	[venta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VentaCliente]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaCliente](
	[ventaCliente_venta] [int] NOT NULL,
	[ventaCliente_cliente] [int] NOT NULL,
 CONSTRAINT [PK_VentaCliente] PRIMARY KEY CLUSTERED 
(
	[ventaCliente_venta] ASC,
	[ventaCliente_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VentaVuelo]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaVuelo](
	[ventaVuelo_venta] [int] NOT NULL,
	[ventaVuelo_vuelo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_VentaVuelo] PRIMARY KEY CLUSTERED 
(
	[ventaVuelo_venta] ASC,
	[ventaVuelo_vuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vuelo]    Script Date: 2/11/2017 11:48:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vuelo](
	[vuelo_numero] [varchar](10) NOT NULL,
	[vuelo_disponible] [bit] NOT NULL,
	[vuelo_cantidadEspacios] [int] NOT NULL,
	[vuelo_fecha] [date] NOT NULL,
	[vuelo_hora] [time](7) NOT NULL,
	[vuelo_origen] [int] NOT NULL,
	[vuelo_destino] [int] NOT NULL,
	[vuelo_escalas] [int] NOT NULL,
	[vuelo_aerolinea] [int] NOT NULL,
	[vuelo_precio] [decimal](19, 2) NOT NULL,
	[vuelo_dv] [int] NULL,
 CONSTRAINT [PK_Vuelo_1] PRIMARY KEY CLUSTERED 
(
	[vuelo_numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (2, N'Administrador', CAST(N'2017-09-14' AS Date), N'Ingreso al sistema', 7)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (3, N'Administrador', CAST(N'2017-09-15' AS Date), N'Ingreso al sistema', 5)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (4, N'Administrador', CAST(N'2017-09-15' AS Date), N'Ingreso al sistema', 5)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (5, N'Administrador', CAST(N'2017-09-17' AS Date), N'Ingreso al sistema', 1)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (6, N'Administrador', CAST(N'2017-10-09' AS Date), N'Ingreso al sistema', 7)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (7, N'Administrador', CAST(N'2017-10-09' AS Date), N'Ingreso al sistema', 7)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (8, N'Administrador', CAST(N'2017-10-09' AS Date), N'Ingreso al sistema', 7)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (9, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (10, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (11, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (12, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (13, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (14, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (15, N'asd', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 2)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (16, N'asd', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 2)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (17, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (18, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (19, N'Administrador', CAST(N'2017-10-10' AS Date), N'Ingreso al sistema', 6)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (20, N'Administrador', CAST(N'2017-10-20' AS Date), N'Ingreso al sistema', 5)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (21, N'Administrador', CAST(N'2017-10-20' AS Date), N'Ingreso al sistema', 5)
INSERT [dbo].[Bitacora] ([bitacora_id], [bitacora_usuario], [bitacora_fecha], [bitacora_descripcion], [bitacora_dv]) VALUES (22, N'Administrador', CAST(N'2017-10-20' AS Date), N'Ingreso al sistema', 5)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[DVV] ON 

INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (1, N'Bitacora', 6, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (2, N'Cliente', 0, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (3, N'Permiso', 9, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (4, N'PermisoCompuesto', 9, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (5, N'Rol', 1, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (6, N'Usuario', 4, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (7, N'Venta', 0, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[DVV] ([dvv_id], [dvv_tabla], [dvv_digito], [dvv_fechaVerificacion]) VALUES (8, N'Vuelo', 0, CAST(N'2017-10-20' AS Date))
SET IDENTITY_INSERT [dbo].[DVV] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([idioma_id], [idioma_nombre]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([idioma_id], [idioma_nombre]) VALUES (3, N'Ingles')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (8, N'Declarar Permisos', 10, N'InterfazUsuario.FormPermisos', 9)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (9, N'Declarar Roles', 10, N'InterfazUsuario.FormRoles', 5)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (10, N'Asignar Roles', 10, N'InterfazUsuario.FormAsignacion', 7)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (11, N'Alta Usuario', 10, N'InterfazUsuario.FormRegistro', 1)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (12, N'ABM Vuelos-Aerolineas', 11, N'InterfazUsuario.FormAerolineas', 1)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (13, N'ABM Clientes', 11, N'InterfazUsuario.FormClientes', 2)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (14, N'ABM Destinos', 11, N'InterfazUsuario.FormDestinos', 2)
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario], [permiso_dv]) VALUES (16, N'Ventas', 11, N'InterfazUsuario.FormVentas', 7)
SET IDENTITY_INSERT [dbo].[Permiso] OFF
SET IDENTITY_INSERT [dbo].[PermisoCompuesto] ON 

INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario], [permisoCompuesto_dv]) VALUES (0, N'Permisos del Sistema', NULL, NULL, 2)
INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario], [permisoCompuesto_dv]) VALUES (10, N'Seguridad', 0, N'', 9)
INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario], [permisoCompuesto_dv]) VALUES (11, N'Negocio', 0, N'', 8)
SET IDENTITY_INSERT [dbo].[PermisoCompuesto] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([rol_id], [rol_nombre], [rol_dv]) VALUES (1, N'Administrador', 8)
INSERT [dbo].[Rol] ([rol_id], [rol_nombre], [rol_dv]) VALUES (2, N'Prueba', 5)
SET IDENTITY_INSERT [dbo].[Rol] OFF
INSERT [dbo].[RolPermisoCompuesto] ([rolPermisoCompuesto_rol], [rolPermisoCompuesto_Permiso]) VALUES (1, 0)
INSERT [dbo].[RolPermisoCompuesto] ([rolPermisoCompuesto_rol], [rolPermisoCompuesto_Permiso]) VALUES (2, 11)
SET IDENTITY_INSERT [dbo].[Texto] ON 

INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (1, N'Numero de vuelo:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (2, N'Fecha:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (3, N'Hora:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (4, N'Destino:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (5, N'Guardar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (6, N'Renombrar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (7, N'Nueva Aerolinea')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (8, N'Agregar Vuelo')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (9, N'Editar Vuelo')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (10, N'Eliminar Vuelo')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (11, N'Nombre y Apellido:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (12, N'DNI:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (13, N'Pasaporte:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (14, N'Fecha de Nacimiento:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (15, N'Telefono:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (16, N'Sexo:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (17, N'Estado Civil:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (18, N'- Seleccione un Cliente -')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (19, N'Editar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (20, N'Nuevo Cliente')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (21, N'Guardar Cambios')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (22, N'Eliminar Datos')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (23, N'Agregar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (24, N'Eliminar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (25, N'Texto Seleccionado')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (26, N'Traduccion')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (27, N'Nuevo Idioma')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (28, N'Eliminar Idioma')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (29, N'Nombre del Permiso')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (30, N'Seleccione Formulario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (31, N'Aceptar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (32, N'Permisos')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (33, N'Nuevo Permiso')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (34, N'Nuevo Permiso Compuesto')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (35, N'Modificar Permiso')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (36, N'Eliminar Permiso')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (37, N'Asignacion de Roles')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (38, N'Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (39, N'Rol')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (40, N'Cancelar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (41, N'Roles del Sistema')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (42, N'Roles')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (43, N'Permisos del Rol')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (44, N'Nuevo Rol')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (47, N'Deshacer Cambios')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (48, N'Rol de')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (49, N'Nombre de Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (50, N'Contraseña')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (51, N'Olvido su contraseña')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (52, N'*Por favor, revise los datos ingresados')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (53, N'Ingresar')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (54, N'Nombre')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (55, N'Apellido')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (56, N'Verificar Contraseña')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (57, N'*Las contraseñas no coinciden')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (58, N'Administracion de usuarios')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (59, N'Usuarios')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (60, N'Nombre de Usuario:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (61, N'Rol del Usuario:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (62, N'Ver detalles del Rol')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (63, N'Nuevo Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (64, N'Modificar Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (65, N'Eliminar Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (66, N'Nombre:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (67, N'Apellido:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (68, N'Rol:')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (69, N'Cambiar rol')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (70, N'Declarar Permisos')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (71, N'Declarar Roles')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (72, N'Asignar Roles')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (73, N'Alta Usuario')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (74, N'ABM Vuelos-Aerolineas')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (75, N'ABM Clientes')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (76, N'ABM Destinos')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (77, N'Ventas')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (78, N'Permisos del Sistema')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (79, N'Seguridad')
INSERT [dbo].[Texto] ([texto_id], [texto_texto]) VALUES (80, N'Negocio')
SET IDENTITY_INSERT [dbo].[Texto] OFF
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (1, 1, N'Numero de vuelo:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (1, 3, N'Flight Number:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (2, 1, N'Fecha:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (2, 3, N'Date:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (3, 1, N'Hora:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (3, 3, N'Time:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (4, 1, N'Destino:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (4, 3, N'Destination:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (5, 1, N'Guardar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (5, 3, N'Save')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (6, 1, N'Renombrar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (6, 3, N'Renombrar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (7, 1, N'Nueva Aerolinea')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (7, 3, N'New Airline')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (8, 1, N'Agregar Vuelo')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (8, 3, N'Add Flight')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (9, 1, N'Editar Vuelo')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (9, 3, N'Edit Flight')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (10, 1, N'Eliminar Vuelo')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (10, 3, N'Delete Flight')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (11, 1, N'Nombre y Apellido:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (11, 3, N'Name and Lastname:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (12, 1, N'DNI:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (12, 3, N'DNI:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (13, 1, N'Pasaporte:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (13, 3, N'Passport:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (14, 1, N'Fecha de Nacimiento:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (14, 3, N'Birthdate:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (15, 1, N'Telefono:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (15, 3, N'Phone number:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (16, 1, N'Sexo:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (16, 3, N'Sex:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (17, 1, N'Estado Civil:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (17, 3, N'Civil Status:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (18, 1, N'- Seleccione un Cliente -')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (18, 3, N'- Select a Client -')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (19, 1, N'Editar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (19, 3, N'Edit')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (20, 1, N'Nuevo Cliente')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (20, 3, N'New Client')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (21, 1, N'Guardar Cambios')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (21, 3, N'Save Changes')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (22, 1, N'Eliminar Datos')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (22, 3, N'Delete Data')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (23, 1, N'Agregar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (23, 3, N'Add')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (24, 1, N'Eliminar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (24, 3, N'Delete')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (25, 1, N'Texto Seleccionado')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (25, 3, N'Selected Text')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (26, 1, N'Traduccion')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (26, 3, N'Translation')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (27, 1, N'Nuevo Idioma')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (27, 3, N'New Language')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (28, 1, N'Eliminar Idioma')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (28, 3, N'Delete Language')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (29, 1, N'Nombre del Permiso')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (29, 3, N'Permit Name')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (30, 1, N'Seleccione Formulario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (30, 3, N'Select a Form')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (31, 1, N'Aceptar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (31, 3, N'Accept')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (32, 1, N'Permisos')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (32, 3, N'Permissions')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (33, 1, N'Nuevo Permiso')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (33, 3, N'New Permit')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (34, 1, N'Nuevo Permiso Compuesto')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (34, 3, N'New Compound Permit')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (35, 1, N'Modificar Permiso')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (35, 3, N'Modify Permit')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (36, 1, N'Eliminar Permiso')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (36, 3, N'Delete Permit')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (37, 1, N'Asignacion de Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (37, 3, N'Role Assingment')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (38, 1, N'Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (38, 3, N'User')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (39, 1, N'Rol')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (39, 3, N'Role')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (40, 1, N'Cancelar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (40, 3, N'Cancel')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (41, 1, N'Roles del Sistema')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (41, 3, N'System Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (42, 1, N'Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (42, 3, N'Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (43, 1, N'Permisos del Rol')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (43, 3, N'Role s Permissions')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (44, 1, N'Nuevo Rol')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (44, 3, N'New Role')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (47, 1, N'Deshacer Cambios')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (47, 3, N'Undo Changes')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (48, 1, N'Rol de')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (48, 3, N'Role assigned to ')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (49, 1, N'Nombre de Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (49, 3, N'Username')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (50, 1, N'Contraseña')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (50, 3, N'Password')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (51, 1, N'Olvido su contraseña')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (51, 3, N'Fort my password')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (52, 1, N'*Por favor, revise los datos ingresados')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (52, 3, N'*Please, check the entered information')
GO
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (53, 1, N'Ingresar')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (53, 3, N'Log In')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (54, 1, N'Nombre')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (54, 3, N'Name')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (55, 1, N'Apellido')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (55, 3, N'Last Name')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (56, 1, N'Verificar Contraseña')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (56, 3, N'Verify password')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (57, 1, N'*Las contraseñas no coinciden')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (57, 3, N'*The passwords dont match')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (58, 1, N'Administracion de usuarios')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (58, 3, N'User Administration')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (59, 1, N'Usuarios')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (59, 3, N'Users')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (60, 1, N'Nombre de Usuario:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (60, 3, N'Username:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (61, 1, N'Rol del Usuario:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (61, 3, N'User s role:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (62, 1, N'Ver detalles del Rol')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (62, 3, N'View role details')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (63, 1, N'Nuevo Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (63, 3, N'New User')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (64, 1, N'Modificar Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (64, 3, N'Modify User')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (65, 1, N'Eliminar Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (65, 3, N'Delete User')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (66, 1, N'Nombre:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (66, 3, N'Name:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (67, 1, N'Apellido:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (67, 3, N'Lastname:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (68, 1, N'Rol:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (68, 3, N'Role:')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (69, 1, N'Cambiar rol')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (69, 3, N'Change Role')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (70, 1, N'Declarar Permisos')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (70, 3, N'Declare Permissions')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (71, 1, N'Declarar Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (71, 3, N'Declare Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (72, 1, N'Asignar Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (72, 3, N'Assing Roles')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (73, 1, N'Alta Usuario')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (73, 3, N'User Registration')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (74, 1, N'ABM Vuelos-Aerolineas')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (74, 3, N'Airline-Flights')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (75, 1, N'ABM Clientes')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (75, 3, N'Clients')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (76, 1, N'ABM Destinos')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (76, 3, N'Destinations')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (77, 1, N'Ventas')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (77, 3, N'Sales')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (78, 1, N'Permisos del Sistema')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (78, 3, N'System Permissions')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (79, 1, N'Seguridad')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (79, 3, N'Security')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (80, 1, N'Negocio')
INSERT [dbo].[TextoIdioma] ([textoIdioma_texto], [textoIdioma_idioma], [textoIdioma_traduccion]) VALUES (80, 3, N'Bussines')
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([usuario_id], [usuario_userName], [usuario_nombre], [usuario_apellido], [usuario_password], [usuario_rol], [usuario_dv]) VALUES (1, N'Administrador', N'', N'', N'2A2E9A58102784CA18E2605A4E727B5F', 1, 3)
INSERT [dbo].[Usuario] ([usuario_id], [usuario_userName], [usuario_nombre], [usuario_apellido], [usuario_password], [usuario_rol], [usuario_dv]) VALUES (2, N'germone', N'pablo', N'germone', N'81DC9BDB52D04DC20036DBD8313ED055', 2, 8)
INSERT [dbo].[Usuario] ([usuario_id], [usuario_userName], [usuario_nombre], [usuario_apellido], [usuario_password], [usuario_rol], [usuario_dv]) VALUES (3, N'asd', N'asd', N'asd', N'7815696ECBF1C96E6894B779456D330E', NULL, 5)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_Rol_rolNombre]    Script Date: 2/11/2017 11:48:45 a. m. ******/
ALTER TABLE [dbo].[Rol] ADD  CONSTRAINT [UQ_Rol_rolNombre] UNIQUE NONCLUSTERED 
(
	[rol_nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Usuario__80C2FBAC398D8EEE]    Script Date: 2/11/2017 11:48:45 a. m. ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UQ__Usuario__80C2FBAC398D8EEE] UNIQUE NONCLUSTERED 
(
	[usuario_userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asiento]  WITH CHECK ADD  CONSTRAINT [FK_Asiento_Vuelo] FOREIGN KEY([asiento_vuelo_numero])
REFERENCES [dbo].[Vuelo] ([vuelo_numero])
GO
ALTER TABLE [dbo].[Asiento] CHECK CONSTRAINT [FK_Asiento_Vuelo]
GO
ALTER TABLE [dbo].[Email]  WITH CHECK ADD  CONSTRAINT [FK_Email_Cliente] FOREIGN KEY([email_cliente])
REFERENCES [dbo].[Cliente] ([cliente_id])
GO
ALTER TABLE [dbo].[Email] CHECK CONSTRAINT [FK_Email_Cliente]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK__Permiso__permiso__24927208] FOREIGN KEY([permiso_padre])
REFERENCES [dbo].[PermisoCompuesto] ([permisoCompuesto_id])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK__Permiso__permiso__24927208]
GO
ALTER TABLE [dbo].[PermisoCompuesto]  WITH CHECK ADD  CONSTRAINT [FK__PermisoCo__permi__1FCDBCEB] FOREIGN KEY([permisoCompuesto_padre])
REFERENCES [dbo].[PermisoCompuesto] ([permisoCompuesto_id])
GO
ALTER TABLE [dbo].[PermisoCompuesto] CHECK CONSTRAINT [FK__PermisoCo__permi__1FCDBCEB]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__rolPe__2D27B809] FOREIGN KEY([rolPermiso_rol])
REFERENCES [dbo].[Rol] ([rol_id])
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK__RolPermis__rolPe__2D27B809]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__rolPe__2E1BDC42] FOREIGN KEY([rolPermiso_permiso])
REFERENCES [dbo].[Permiso] ([permiso_id])
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK__RolPermis__rolPe__2E1BDC42]
GO
ALTER TABLE [dbo].[RolPermisoCompuesto]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__rolPe__32E0915F] FOREIGN KEY([rolPermisoCompuesto_rol])
REFERENCES [dbo].[Rol] ([rol_id])
GO
ALTER TABLE [dbo].[RolPermisoCompuesto] CHECK CONSTRAINT [FK__RolPermis__rolPe__32E0915F]
GO
ALTER TABLE [dbo].[RolPermisoCompuesto]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__rolPe__33D4B598] FOREIGN KEY([rolPermisoCompuesto_Permiso])
REFERENCES [dbo].[PermisoCompuesto] ([permisoCompuesto_id])
GO
ALTER TABLE [dbo].[RolPermisoCompuesto] CHECK CONSTRAINT [FK__RolPermis__rolPe__33D4B598]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Cliente] FOREIGN KEY([telefono_cliente])
REFERENCES [dbo].[Cliente] ([cliente_id])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefono_Cliente]
GO
ALTER TABLE [dbo].[TextoIdioma]  WITH CHECK ADD  CONSTRAINT [FK_TextoIdioma_Idioma] FOREIGN KEY([textoIdioma_idioma])
REFERENCES [dbo].[Idioma] ([idioma_id])
GO
ALTER TABLE [dbo].[TextoIdioma] CHECK CONSTRAINT [FK_TextoIdioma_Idioma]
GO
ALTER TABLE [dbo].[TextoIdioma]  WITH CHECK ADD  CONSTRAINT [FK_TextoIdioma_Texto] FOREIGN KEY([textoIdioma_texto])
REFERENCES [dbo].[Texto] ([texto_id])
GO
ALTER TABLE [dbo].[TextoIdioma] CHECK CONSTRAINT [FK_TextoIdioma_Texto]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__usuario__3B75D760] FOREIGN KEY([usuario_rol])
REFERENCES [dbo].[Rol] ([rol_id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__usuario__3B75D760]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK__Venta__venta_usu__412EB0B6] FOREIGN KEY([venta_usuario])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK__Venta__venta_usu__412EB0B6]
GO
ALTER TABLE [dbo].[VentaCliente]  WITH CHECK ADD  CONSTRAINT [FK_VentaCliente_Cliente] FOREIGN KEY([ventaCliente_cliente])
REFERENCES [dbo].[Cliente] ([cliente_id])
GO
ALTER TABLE [dbo].[VentaCliente] CHECK CONSTRAINT [FK_VentaCliente_Cliente]
GO
ALTER TABLE [dbo].[VentaCliente]  WITH CHECK ADD  CONSTRAINT [FK_VentaCliente_Venta] FOREIGN KEY([ventaCliente_venta])
REFERENCES [dbo].[Venta] ([venta_id])
GO
ALTER TABLE [dbo].[VentaCliente] CHECK CONSTRAINT [FK_VentaCliente_Venta]
GO
ALTER TABLE [dbo].[VentaVuelo]  WITH CHECK ADD  CONSTRAINT [FK_VentaVuelo_Venta] FOREIGN KEY([ventaVuelo_venta])
REFERENCES [dbo].[Venta] ([venta_id])
GO
ALTER TABLE [dbo].[VentaVuelo] CHECK CONSTRAINT [FK_VentaVuelo_Venta]
GO
ALTER TABLE [dbo].[VentaVuelo]  WITH CHECK ADD  CONSTRAINT [FK_VentaVuelo_Vuelo] FOREIGN KEY([ventaVuelo_vuelo])
REFERENCES [dbo].[Vuelo] ([vuelo_numero])
GO
ALTER TABLE [dbo].[VentaVuelo] CHECK CONSTRAINT [FK_VentaVuelo_Vuelo]
GO
ALTER TABLE [dbo].[Vuelo]  WITH CHECK ADD  CONSTRAINT [FK__Vuelo__vuelo_des__08EA5793] FOREIGN KEY([vuelo_destino])
REFERENCES [dbo].[Destino] ([destino_id])
GO
ALTER TABLE [dbo].[Vuelo] CHECK CONSTRAINT [FK__Vuelo__vuelo_des__08EA5793]
GO
ALTER TABLE [dbo].[Vuelo]  WITH CHECK ADD  CONSTRAINT [FK_Vuelo_Aerolinea] FOREIGN KEY([vuelo_aerolinea])
REFERENCES [dbo].[Aerolinea] ([aerolinea_id])
GO
ALTER TABLE [dbo].[Vuelo] CHECK CONSTRAINT [FK_Vuelo_Aerolinea]
GO
USE [master]
GO
ALTER DATABASE [Diploma2017_VentaPasajes] SET  READ_WRITE 
GO
