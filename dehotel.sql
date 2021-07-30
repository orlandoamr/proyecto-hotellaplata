USE [master]
GO
/****** Object:  Database [proyecto_hotel]    Script Date: 7/29/2021 6:37:57 PM ******/
CREATE DATABASE [proyecto_hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto_hotel', FILENAME = N'D:\SQL 2019\root\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyecto_hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_hotel_log', FILENAME = N'D:\SQL 2019\root\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyecto_hotel_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [proyecto_hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto_hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto_hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto_hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto_hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto_hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto_hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto_hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyecto_hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto_hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto_hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto_hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto_hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto_hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto_hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto_hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto_hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyecto_hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto_hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto_hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto_hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto_hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto_hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto_hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto_hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [proyecto_hotel] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto_hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto_hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto_hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto_hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto_hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyecto_hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyecto_hotel', N'ON'
GO
ALTER DATABASE [proyecto_hotel] SET QUERY_STORE = OFF
GO
USE [proyecto_hotel]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[CargoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[CargoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [nvarchar](30) NOT NULL,
	[NombreCliente] [varchar](30) NOT NULL,
	[ApellidoCliente] [varchar](30) NOT NULL,
	[Extranjero] [bit] NULL,
	[FKDepartamentoId] [int] NOT NULL,
	[FkPaisId] [int] NOT NULL,
 CONSTRAINT [PK__Clientes__71ABD087E6118EDF] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[DepartamentoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreDepartamento] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[DepartamentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleHabitaciones]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleHabitaciones](
	[HabitacionId] [int] NOT NULL,
	[VentaId] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVentas_1] PRIMARY KEY CLUSTERED 
(
	[HabitacionId] ASC,
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleServicios]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleServicios](
	[ServicioId] [int] NOT NULL,
	[VentaId] [int] NOT NULL,
 CONSTRAINT [PK_DetalleServicios] PRIMARY KEY CLUSTERED 
(
	[ServicioId] ASC,
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiarioEmpleados]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiarioEmpleados](
	[DiarioEmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[HoraEntrada] [time](7) NOT NULL,
	[HoraSalida] [time](7) NULL,
	[Observacion] [varchar](100) NOT NULL,
	[FkEmpleadoId] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__DiarioEm__47E2189B3F19980D] PRIMARY KEY CLUSTERED 
(
	[DiarioEmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoId] [nvarchar](30) NOT NULL,
	[NombreEmpleado] [nvarchar](50) NOT NULL,
	[ApellidoEmpleado] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[FKCargoId] [int] NOT NULL,
 CONSTRAINT [PK__Empleado__958BE91095E279CE] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GastosAdicionales]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GastosAdicionales](
	[GastoAdicionalId] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FkProductoId] [int] NOT NULL,
	[FkVentaId] [int] NOT NULL,
 CONSTRAINT [PK__GastosAd__5C18C405A12C2BD9] PRIMARY KEY CLUSTERED 
(
	[GastoAdicionalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[HabitacionId] [int] NOT NULL,
	[CostoHabitacion] [int] NOT NULL,
	[CantCamas] [tinyint] NOT NULL,
	[CantAlmohadas] [tinyint] NOT NULL,
	[CantMesas] [tinyint] NOT NULL,
	[CantSillas] [tinyint] NOT NULL,
	[Observacion] [nvarchar](100) NOT NULL,
	[CantTVs] [tinyint] NOT NULL,
	[EstadoDisponibilidad] [bit] NOT NULL,
	[FKTipoAireId] [tinyint] NOT NULL,
	[FKTipoHabitacionId] [tinyint] NOT NULL,
	[FKTipoCamaId] [tinyint] NOT NULL,
 CONSTRAINT [PK__Habitaci__11AD44614C46182B] PRIMARY KEY CLUSTERED 
(
	[HabitacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[PaisId] [int] IDENTITY(1,1) NOT NULL,
	[NombrePais] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[PaisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [nvarchar](100) NOT NULL,
	[Precio] [int] NOT NULL,
	[EstadoProducto] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[ServicioId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [int] NOT NULL,
	[EstadoServicio] [bit] NOT NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[ServicioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAiresAcondicionados]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAiresAcondicionados](
	[TipoAireId] [tinyint] IDENTITY(1,1) NOT NULL,
	[DescripcionAire] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_AiresAcondicionados] PRIMARY KEY CLUSTERED 
(
	[TipoAireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCamas]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCamas](
	[TipoCamaId] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoCamas] PRIMARY KEY CLUSTERED 
(
	[TipoCamaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoHabitaciones]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoHabitaciones](
	[TipoHabitacionId] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoHabitaciones] PRIMARY KEY CLUSTERED 
(
	[TipoHabitacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[EmpleadoId] [nvarchar](30) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contrasenia] [nvarchar](30) NOT NULL,
	[Nivel] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 7/29/2021 6:37:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[VentaId] [int] IDENTITY(1,1) NOT NULL,
	[FechaEntrada] [datetime] NOT NULL,
	[FechaSalida] [datetime] NULL,
	[TotalVenta] [int] NOT NULL,
	[Observacion] [nvarchar](100) NULL,
	[FkClienteId] [nvarchar](30) NOT NULL,
	[FkEmpleadoId] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__DetalleV__340EEDA42140963D] PRIMARY KEY CLUSTERED 
(
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([CargoId], [Descripcion]) VALUES (1, N'Recepcionista                 ')
INSERT [dbo].[Cargos] ([CargoId], [Descripcion]) VALUES (2, N'Guardia                       ')
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
INSERT [dbo].[Clientes] ([ClienteId], [NombreCliente], [ApellidoCliente], [Extranjero], [FKDepartamentoId], [FkPaisId]) VALUES (N'1615199900003', N'Orlando', N'Medina', 1, 16, 76)
INSERT [dbo].[Clientes] ([ClienteId], [NombreCliente], [ApellidoCliente], [Extranjero], [FKDepartamentoId], [FkPaisId]) VALUES (N'1615199945889', N'Javier', N'Gonzales', 0, 16, 76)
GO
SET IDENTITY_INSERT [dbo].[Departamentos] ON 

INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (1, N'Atlántida')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (2, N'Choluteca')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (3, N'Colón')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (4, N'Comayagua')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (5, N'Copán')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (6, N'Cortés')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (7, N'El Paraíso')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (8, N'Francisco Morazán')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (9, N'Gracias a Dios')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (10, N'Intibucá')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (11, N'Islas de la Bahía')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (12, N'La Paz ')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (13, N'Lempira')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (14, N'Ocotepeque')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (15, N'Olancho')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (16, N'Santa Bárbara')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (17, N'Valle')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (18, N'Yoro
')
INSERT [dbo].[Departamentos] ([DepartamentoId], [NombreDepartamento]) VALUES (20, N'NA')
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
GO
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 2)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 14)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 15)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 16)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 17)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (1, 18)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (2, 8)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (2, 14)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (2, 15)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (2, 16)
INSERT [dbo].[DetalleHabitaciones] ([HabitacionId], [VentaId]) VALUES (2, 17)
GO
INSERT [dbo].[DetalleServicios] ([ServicioId], [VentaId]) VALUES (1, 17)
INSERT [dbo].[DetalleServicios] ([ServicioId], [VentaId]) VALUES (3, 17)
INSERT [dbo].[DetalleServicios] ([ServicioId], [VentaId]) VALUES (4, 17)
GO
INSERT [dbo].[Empleados] ([EmpleadoId], [NombreEmpleado], [ApellidoEmpleado], [Telefono], [Correo], [FKCargoId]) VALUES (N'1615200084558', N'Daniel', N'Gallegos', N'98812305', N'orlando@gmail.com', 1)
GO
SET IDENTITY_INSERT [dbo].[GastosAdicionales] ON 

INSERT [dbo].[GastosAdicionales] ([GastoAdicionalId], [Cantidad], [FkProductoId], [FkVentaId]) VALUES (1, 3, 1, 2)
INSERT [dbo].[GastosAdicionales] ([GastoAdicionalId], [Cantidad], [FkProductoId], [FkVentaId]) VALUES (2, 2, 2, 2)
SET IDENTITY_INSERT [dbo].[GastosAdicionales] OFF
GO
INSERT [dbo].[Habitaciones] ([HabitacionId], [CostoHabitacion], [CantCamas], [CantAlmohadas], [CantMesas], [CantSillas], [Observacion], [CantTVs], [EstadoDisponibilidad], [FKTipoAireId], [FKTipoHabitacionId], [FKTipoCamaId]) VALUES (1, 600, 1, 2, 1, 1, N'Vista al boulevar', 1, 1, 1, 1, 2)
INSERT [dbo].[Habitaciones] ([HabitacionId], [CostoHabitacion], [CantCamas], [CantAlmohadas], [CantMesas], [CantSillas], [Observacion], [CantTVs], [EstadoDisponibilidad], [FKTipoAireId], [FKTipoHabitacionId], [FKTipoCamaId]) VALUES (2, 800, 2, 4, 2, 4, N'Vista al patio', 2, 1, 1, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Paises] ON 

INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (1, N'Afghanistan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (2, N'Albania')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (3, N'Algeria')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (4, N'Andorra')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (5, N'Angola')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (6, N'Antigua and Barbuda')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (7, N'Argentina')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (8, N'Armenia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (9, N'Australia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (10, N'Austria')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (11, N'Azerbaijan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (12, N'Bahamas, The')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (13, N'Bahrain')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (14, N'Bangladesh')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (15, N'Barbados')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (16, N'Belarus')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (17, N'Belgium')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (18, N'Belize')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (19, N'Benin')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (20, N'Bhutan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (21, N'Bolivia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (22, N'Bosnia and Herzegovina')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (23, N'Botswana')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (24, N'Brazil')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (25, N'Brunei')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (26, N'Bulgaria')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (27, N'Burkina Faso')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (28, N'Burma')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (29, N'Burundi')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (30, N'Cambodia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (31, N'Cameroon')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (32, N'Canada')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (33, N'Cape Verde')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (34, N'Central Africa')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (35, N'Chad')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (36, N'Chile')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (37, N'China')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (38, N'Colombia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (39, N'Comoros')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (40, N'Congo, Democratic Republic of the')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (41, N'Costa Rica')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (42, N'Cote dIvoire')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (43, N'Crete')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (44, N'Croatia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (45, N'Cuba')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (46, N'Cyprus')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (47, N'Czech Republic')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (48, N'Denmark')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (49, N'Djibouti')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (50, N'Dominican Republic')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (51, N'East Timor')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (52, N'Ecuador')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (53, N'Egypt')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (54, N'El Salvador')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (55, N'Equatorial Guinea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (56, N'Eritrea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (57, N'Estonia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (58, N'Ethiopia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (59, N'Fiji')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (60, N'Finland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (61, N'France')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (62, N'Gabon')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (63, N'Gambia, The')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (64, N'Georgia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (65, N'Germany')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (66, N'Ghana')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (67, N'Greece')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (68, N'Grenada')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (69, N'Guadeloupe')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (70, N'Guatemala')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (71, N'Guinea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (72, N'Guinea-Bissau')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (73, N'Guyana')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (74, N'Haiti')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (75, N'Holy See')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (76, N'Honduras')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (77, N'Hong Kong')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (78, N'Hungary')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (79, N'Iceland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (80, N'India')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (81, N'Indonesia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (82, N'Iran')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (83, N'Iraq')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (84, N'Ireland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (85, N'Israel')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (86, N'Italy')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (87, N'Ivory Coast')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (88, N'Jamaica')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (89, N'Japan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (90, N'Jordan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (91, N'Kazakhstan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (92, N'Kenya')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (93, N'Kiribati')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (94, N'Korea, North')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (95, N'Korea, South')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (96, N'Kosovo')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (97, N'Kuwait')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (98, N'Kyrgyzstan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (99, N'Laos')
GO
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (100, N'Latvia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (101, N'Lebanon')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (102, N'Lesotho')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (103, N'Liberia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (104, N'Libya')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (105, N'Liechtenstein')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (106, N'Lithuania')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (107, N'Macau')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (108, N'Macedonia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (109, N'Madagascar')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (110, N'Malawi')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (111, N'Malaysia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (112, N'Maldives')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (113, N'Mali')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (114, N'Malta')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (115, N'Marshall Islands')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (116, N'Mauritania')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (117, N'Mauritius')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (118, N'Mexico')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (119, N'Micronesia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (120, N'Moldova')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (121, N'Monaco')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (122, N'Mongolia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (123, N'Montenegro')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (124, N'Morocco')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (125, N'Mozambique')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (126, N'Namibia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (127, N'Nauru')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (128, N'Nepal')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (129, N'Netherlands')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (130, N'New Zealand')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (131, N'Nicaragua')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (132, N'Niger')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (133, N'Nigeria')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (134, N'North Korea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (135, N'Norway')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (136, N'Oman')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (137, N'Pakistan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (138, N'Palau')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (139, N'Panama')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (140, N'Papua New Guinea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (141, N'Paraguay')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (142, N'Peru')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (143, N'Philippines')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (144, N'Poland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (145, N'Portugal')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (146, N'Qatar')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (147, N'Romania')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (148, N'Russia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (149, N'Rwanda')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (150, N'Saint Lucia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (151, N'Saint Vincent and the Grenadines')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (152, N'Samoa')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (153, N'San Marino')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (154, N'Sao Tome and Principe')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (155, N'Saudi Arabia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (156, N'Scotland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (157, N'Senegal')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (158, N'Serbia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (159, N'Seychelles')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (160, N'Sierra Leone')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (161, N'Singapore')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (162, N'Slovakia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (163, N'Slovenia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (164, N'Solomon Islands')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (165, N'Somalia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (166, N'South Africa')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (167, N'South Korea')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (168, N'Spain')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (169, N'Sri Lanka')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (170, N'Sudan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (171, N'Suriname')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (172, N'Swaziland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (173, N'Sweden')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (174, N'Switzerland')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (175, N'Syria')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (176, N'Taiwan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (177, N'Tajikistan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (178, N'Tanzania')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (179, N'Thailand')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (180, N'Tibet')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (181, N'Timor-Leste')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (182, N'Togo')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (183, N'Tonga')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (184, N'Trinidad and Tobago')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (185, N'Tunisia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (186, N'Turkey')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (187, N'Turkmenistan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (188, N'Tuvalu')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (189, N'Uganda')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (190, N'Ukraine')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (191, N'United Arab Emirates')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (192, N'United Kingdom')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (193, N'United States')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (194, N'Uruguay')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (195, N'Uzbekistan')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (196, N'Vanuatu')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (197, N'Venezuela')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (198, N'Vietnam')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (199, N'Yemen')
GO
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (200, N'Zambia')
INSERT [dbo].[Paises] ([PaisId], [NombrePais]) VALUES (201, N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[Paises] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ProductoId], [NombreProducto], [Precio], [EstadoProducto]) VALUES (1, N'Café                                                                                                ', 60, 1)
INSERT [dbo].[Productos] ([ProductoId], [NombreProducto], [Precio], [EstadoProducto]) VALUES (2, N'Refresco                                                                                            ', 25, 1)
INSERT [dbo].[Productos] ([ProductoId], [NombreProducto], [Precio], [EstadoProducto]) VALUES (3, N'Galleta                                                                                             ', 10, 1)
INSERT [dbo].[Productos] ([ProductoId], [NombreProducto], [Precio], [EstadoProducto]) VALUES (4, N'Prestobarba', 15, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicios] ON 

INSERT [dbo].[Servicios] ([ServicioId], [Descripcion], [Precio], [EstadoServicio]) VALUES (1, N'Desayuno', 100, 1)
INSERT [dbo].[Servicios] ([ServicioId], [Descripcion], [Precio], [EstadoServicio]) VALUES (3, N'Cena', 100, 1)
INSERT [dbo].[Servicios] ([ServicioId], [Descripcion], [Precio], [EstadoServicio]) VALUES (4, N'Almuerzo', 150, 1)
INSERT [dbo].[Servicios] ([ServicioId], [Descripcion], [Precio], [EstadoServicio]) VALUES (5, N'erwr', 466, 1)
SET IDENTITY_INSERT [dbo].[Servicios] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoAiresAcondicionados] ON 

INSERT [dbo].[TipoAiresAcondicionados] ([TipoAireId], [DescripcionAire]) VALUES (1, N'MiniSplit')
INSERT [dbo].[TipoAiresAcondicionados] ([TipoAireId], [DescripcionAire]) VALUES (2, N'Ventana')
SET IDENTITY_INSERT [dbo].[TipoAiresAcondicionados] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoCamas] ON 

INSERT [dbo].[TipoCamas] ([TipoCamaId], [Descripcion]) VALUES (1, N'Matrimonial')
INSERT [dbo].[TipoCamas] ([TipoCamaId], [Descripcion]) VALUES (2, N'Personal')
SET IDENTITY_INSERT [dbo].[TipoCamas] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoHabitaciones] ON 

INSERT [dbo].[TipoHabitaciones] ([TipoHabitacionId], [Descripcion]) VALUES (1, N'Sencilla')
INSERT [dbo].[TipoHabitaciones] ([TipoHabitacionId], [Descripcion]) VALUES (2, N'Doble')
SET IDENTITY_INSERT [dbo].[TipoHabitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), NULL, 600, N'OK', N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (8, CAST(N'2021-10-12T00:00:00.000' AS DateTime), NULL, 800, N'OK', N'1615199945889', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (9, CAST(N'2021-07-29T00:53:55.023' AS DateTime), NULL, 600, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (10, CAST(N'2021-07-29T01:47:05.970' AS DateTime), NULL, 600, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (11, CAST(N'2021-07-29T01:47:39.067' AS DateTime), NULL, 600, NULL, N'1615199945889', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (12, CAST(N'2021-07-29T01:48:07.237' AS DateTime), NULL, 600, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (13, CAST(N'2021-07-29T01:49:19.187' AS DateTime), NULL, 600, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (14, CAST(N'2021-07-29T02:00:32.783' AS DateTime), NULL, 1750, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (15, CAST(N'2021-07-29T02:03:10.373' AS DateTime), NULL, 1750, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (16, CAST(N'2021-07-29T02:10:21.553' AS DateTime), NULL, 1750, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (17, CAST(N'2021-07-29T02:14:11.057' AS DateTime), NULL, 1750, NULL, N'1615199900003', N'1615200084558')
INSERT [dbo].[Ventas] ([VentaId], [FechaEntrada], [FechaSalida], [TotalVenta], [Observacion], [FkClienteId], [FkEmpleadoId]) VALUES (18, CAST(N'2021-07-29T02:15:49.807' AS DateTime), NULL, 600, NULL, N'1615199945889', N'1615200084558')
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Departamentos] FOREIGN KEY([FKDepartamentoId])
REFERENCES [dbo].[Departamentos] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Departamentos]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Paises] FOREIGN KEY([FkPaisId])
REFERENCES [dbo].[Paises] ([PaisId])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Paises]
GO
ALTER TABLE [dbo].[DetalleHabitaciones]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Habitaciones] FOREIGN KEY([HabitacionId])
REFERENCES [dbo].[Habitaciones] ([HabitacionId])
GO
ALTER TABLE [dbo].[DetalleHabitaciones] CHECK CONSTRAINT [FK_DetalleVentas_Habitaciones]
GO
ALTER TABLE [dbo].[DetalleHabitaciones]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Ventas] FOREIGN KEY([VentaId])
REFERENCES [dbo].[Ventas] ([VentaId])
GO
ALTER TABLE [dbo].[DetalleHabitaciones] CHECK CONSTRAINT [FK_DetalleVentas_Ventas]
GO
ALTER TABLE [dbo].[DetalleServicios]  WITH CHECK ADD  CONSTRAINT [FK_DetalleServicios_Servicios] FOREIGN KEY([ServicioId])
REFERENCES [dbo].[Servicios] ([ServicioId])
GO
ALTER TABLE [dbo].[DetalleServicios] CHECK CONSTRAINT [FK_DetalleServicios_Servicios]
GO
ALTER TABLE [dbo].[DetalleServicios]  WITH CHECK ADD  CONSTRAINT [FK_DetalleServicios_Ventas] FOREIGN KEY([VentaId])
REFERENCES [dbo].[Ventas] ([VentaId])
GO
ALTER TABLE [dbo].[DetalleServicios] CHECK CONSTRAINT [FK_DetalleServicios_Ventas]
GO
ALTER TABLE [dbo].[DiarioEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_DiarioEmpleados_Empleados] FOREIGN KEY([FkEmpleadoId])
REFERENCES [dbo].[Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[DiarioEmpleados] CHECK CONSTRAINT [FK_DiarioEmpleados_Empleados]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargos] FOREIGN KEY([FKCargoId])
REFERENCES [dbo].[Cargos] ([CargoId])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargos]
GO
ALTER TABLE [dbo].[GastosAdicionales]  WITH CHECK ADD  CONSTRAINT [FK_GastosAdicionales_Productos] FOREIGN KEY([FkProductoId])
REFERENCES [dbo].[Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[GastosAdicionales] CHECK CONSTRAINT [FK_GastosAdicionales_Productos]
GO
ALTER TABLE [dbo].[GastosAdicionales]  WITH CHECK ADD  CONSTRAINT [FK_GastosAdicionales_Ventas] FOREIGN KEY([FkVentaId])
REFERENCES [dbo].[Ventas] ([VentaId])
GO
ALTER TABLE [dbo].[GastosAdicionales] CHECK CONSTRAINT [FK_GastosAdicionales_Ventas]
GO
ALTER TABLE [dbo].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Habitaciones_TipoAiresAcondicionados] FOREIGN KEY([FKTipoAireId])
REFERENCES [dbo].[TipoAiresAcondicionados] ([TipoAireId])
GO
ALTER TABLE [dbo].[Habitaciones] CHECK CONSTRAINT [FK_Habitaciones_TipoAiresAcondicionados]
GO
ALTER TABLE [dbo].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Habitaciones_TipoCamas] FOREIGN KEY([FKTipoCamaId])
REFERENCES [dbo].[TipoCamas] ([TipoCamaId])
GO
ALTER TABLE [dbo].[Habitaciones] CHECK CONSTRAINT [FK_Habitaciones_TipoCamas]
GO
ALTER TABLE [dbo].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Habitaciones_TipoHabitaciones1] FOREIGN KEY([FKTipoHabitacionId])
REFERENCES [dbo].[TipoHabitaciones] ([TipoHabitacionId])
GO
ALTER TABLE [dbo].[Habitaciones] CHECK CONSTRAINT [FK_Habitaciones_TipoHabitaciones1]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([FkClienteId])
REFERENCES [dbo].[Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([FkEmpleadoId])
REFERENCES [dbo].[Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
USE [master]
GO
ALTER DATABASE [proyecto_hotel] SET  READ_WRITE 
GO
