USE [master]
GO
/****** Object:  Database [DBFacturacionM1]    Script Date: 30/04/2015 01:45:48 p.m. ******/
CREATE DATABASE [DBFacturacionM1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBFacturacionM1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBFacturacionM1.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBFacturacionM1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBFacturacionM1_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBFacturacionM1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBFacturacionM1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBFacturacionM1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DBFacturacionM1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBFacturacionM1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBFacturacionM1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBFacturacionM1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBFacturacionM1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET RECOVERY FULL 
GO
ALTER DATABASE [DBFacturacionM1] SET  MULTI_USER 
GO
ALTER DATABASE [DBFacturacionM1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBFacturacionM1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBFacturacionM1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBFacturacionM1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBFacturacionM1', N'ON'
GO
USE [DBFacturacionM1]
GO
/****** Object:  StoredProcedure [dbo].[Acceso]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Acceso]
	@Cajero varchar(50)
as
begin
	select c.IDCajero, c.NombreAcceso, c.Contrasena, c.Nombre, 
		   c.Apellido, c.Telefono, c.Estado, c.IDTipoAcceso, case 
		   when t.Rol = 'Administrador' then 1 else 0 end AS Rol 
		from Cajero c inner join TipoAcceso t on 
					c.IDTipoAcceso = t.idTipoAcceso
		where (c.NombreAcceso = @Cajero and c.Estado = 1);
end
GO
/****** Object:  StoredProcedure [dbo].[AgregarBitacora]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[AgregarBitacora]
@CodigoBitac int,@Event varchar(200),@IDCajer int
as
begin try
BEGIN TRAN 
 insert into Bitacora(Evento,IDCajero, Fecha)
 values(@Event,@IDCajer, GetDate())
COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK TRAN
  SELECT @@ERROR 
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[AgregarDistribuidor]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AgregarDistribuidor]
@CodDistr int,@Nomb varchar(25), @Esta varchar(13),@Telef varchar(15)
as
begin try
BEGIN TRAN 
 insert into Distribuidor(Nombre,Estado,Telefono)
 values(@Nomb, @Esta,@Telef)
COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK TRAN
  SELECT @@ERROR 
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[ReducirStock]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReducirStock]
	@IdProducto varchar(50),
	@Cantidad int
as
begin try
BEGIN TRAN 
declare @existencias int;
declare @nuevacantidad int;
set @existencias = (select p.CantidadProd from Producto p where p.CodProducto = @IdProducto);
set @nuevacantidad = @existencias - @Cantidad;
update Producto set CantidadProd = @nuevacantidad where CodProducto = @IdProducto;
COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK TRAN
  SELECT @@ERROR 
END CATCH

GO
/****** Object:  StoredProcedure [dbo].[ReporteBitacora]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReporteBitacora]
@Fecha date
as
begin try
begin tran 
	select CodBitacora as Código_Bitácora, Evento, Fecha as Fecha_Realización, IDCajero 
	from Bitacora where Fecha = @Fecha
commit tran
END TRY
BEGIN CATCH
  ROLLBACK TRAN
  SELECT @@ERROR 
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_Cajero]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Cajero]
	@idCajer int,
	@NombAcce varchar(50),
	@Contrase varchar(20),
	@Nomb varchar(25),
	@Apelli varchar(30),
	@Telef varchar(15),
	@Estado bit,
	@IDTipoAcceso int
as
begin try
begin tran
	insert into Cajero(NombreAcceso, Contrasena, Nombre,Apellido,Telefono, Estado , IDTipoAcceso) values (@NombAcce, @Contrase, @Nomb, @Apelli,@Telef,@Estado, @IDTipoAcceso );
commit tran
end try
begin catch
  ROLLBACK TRAN
  SELECT @@ERROR 
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ConsultaProducto]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: script.sql|178|0|C:\Users\Dangelo\Documents\script.sql
CREATE procedure [dbo].[SP_ConsultaProducto]
	@Id varchar(50),
	@Accion int
as
begin 
	if @Accion = 1
	begin try
	begin tran
		Select p.CodProducto, p.NombreProd, p.Precio, p.CantidadProd, p.CodDistribuidor 
			from Producto p where p.CodProducto = @Id;
			commit tran
			end try
			begin catch
			rollback tran
			select @@ERROR
			end catch
	else
	begin TRY
	BEGIN TRAN
		Select p.CodProducto, p.NombreProd, p.Precio, p.CantidadProd, d.Nombre as Distribuidor 
			from Producto p inner join Distribuidor d on p.CodDistribuidor = d.CodDistribuidor
	commit tran
			end try
			begin catch
			rollback tran
			select @@ERROR
			end catch
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Detalle]
	@idFactura int,
	@CodP varchar(50),
	@Cantidad int,
	@Monto money,
	@SubTotal money
as
begin TRY
BEGIN TRAN
	insert into DetFactura (IdFactura, CodProd, Cantidad, Monto, Subtotal) values (@idFactura, @CodP, @Cantidad, @Monto, @SubTotal);
	COMMIT TRAN
end TRY
BEGIN CATCH
ROLLBACK TRAN
SELECT @@ERROR
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_Factura]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Factura]
	@Fecha date,
	@Total money,
	@Cajero int,
	@acc int
as
begin
	if @acc = 1
	begin
		insert into Factura (Fecha, Total, IDCajero) values (@Fecha, @Total, @Cajero);
		return 1;
	end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ProdMasvendidos]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ProdMasvendidos]
as
begin
Select top 5 d.CodProd as 'Código Producto',p.NombreProd,COUNT(d.CodProd) as 'Cantidad de Ventas'
from DetFactura as d inner join Producto as p on d.CodProd = p.CodProducto
group by d.CodProd,p.NombreProd
order by COUNT(d.CodProd) desc
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Producto]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Producto]
	@Id varchar(50),
	@Dis int,
	@Precio money,
	@Nombre varchar(60),
	@Cantidad int,
	@Accion int
as
begin
Declare @aux int
declare @aux_2 int
	if @Accion = 1
	begin try
	begin tran
		insert into Producto (CodProducto, CodDistribuidor, Precio, CantidadProd, NombreProd) values (@Id, @Dis, @Precio, 1, @Nombre);
		return 1;
		commit tran
		end try
		begin catch
		rollback tran
		select @@error
	end catch
	else
	begin try
	begin tran
		set @aux = (Select p.CantidadProd from Producto p where p.CodProducto = @Id);
		set @aux_2 = @aux + @Cantidad;
		update Producto set NombreProd = @Nombre, CodDistribuidor = @Dis, CantidadProd = @aux_2 ,Precio = @Precio 
		where CodProducto = @Id;
		return 1;
		commit tran
		end try
		begin catch
		rollback tran 
		select @@ERROR
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ProvedoresMasDistribuyen]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ProvedoresMasDistribuyen]
as
begin
Select top 3 p.CodDistribuidor as 'Proveedor',d.Nombre,d.Telefono,d.Estado,COUNT(p.CodDistribuidor) as 'Cantidad de productos por Proveedor'
from Producto as p inner join Distribuidor as d on p.CodDistribuidor = d.CodDistribuidor
group by p.CodDistribuidor,d.Nombre,d.Estado,d.Telefono 
order by COUNT(p.CodDistribuidor) desc
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteFactura]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReporteFactura]
	-- Add the parameters for the stored procedure here
	@idFactura int
AS
BEGIN try
begin tran
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dt.CodProd, p.NombreProd, dt.Monto,
		   dt.Cantidad, dt.Subtotal 
	FROM DetFactura dt inner join Producto p on dt.CodProd = p.CodProducto
	WHERE dt.IdFactura = @idFactura;
	commit tran
	end try
	begin catch
	rollback tran
	select @@error
END catch
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Evento] [varchar](200) NULL,
	[Fecha] [date] NULL,
	[CodBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IDCajero] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cajero]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cajero](
	[IDCajero] [int] IDENTITY(1,1) NOT NULL,
	[NombreAcceso] [varchar](50) NOT NULL,
	[Contrasena] [varchar](20) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IDTipoAcceso] [int] NOT NULL,
 CONSTRAINT [PK__Cajero__B9BE51DC77CA3650] PRIMARY KEY CLUSTERED 
(
	[IDCajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetFactura]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetFactura](
	[Cantidad] [int] NOT NULL,
	[Monto] [money] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[CodDetFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[CodProd] [varchar](50) NOT NULL,
 CONSTRAINT [PK__DetFactu__1DD0404F836F0329] PRIMARY KEY CLUSTERED 
(
	[CodDetFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Distribuidor]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Distribuidor](
	[Nombre] [varchar](25) NULL,
	[Estado] [varchar](13) NULL,
	[Telefono] [varchar](15) NULL,
	[CodDistribuidor] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodDistribuidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Fecha] [date] NULL,
	[Total] [money] NULL,
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IDCajero] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[NombreProd] [varchar](100) NULL,
	[CantidadProd] [int] NULL,
	[Precio] [money] NULL,
	[CodDistribuidor] [int] NOT NULL,
	[CodProducto] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Producto__0D06FDF3618A4DA6] PRIMARY KEY CLUSTERED 
(
	[CodProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAcceso]    Script Date: 30/04/2015 01:45:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAcceso](
	[idTipoAcceso] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TipoAcceso] PRIMARY KEY CLUSTERED 
(
	[idTipoAcceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 130', CAST(0xDC390B00 AS Date), 1, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 2320', CAST(0xDC390B00 AS Date), 2, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 3860', CAST(0xDC390B00 AS Date), 3, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1930', CAST(0xDC390B00 AS Date), 4, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 4100', CAST(0xDD390B00 AS Date), 5, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 2300', CAST(0xDD390B00 AS Date), 6, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 2000', CAST(0xDD390B00 AS Date), 7, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 3600', CAST(0xE1390B00 AS Date), 8, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1930', CAST(0xE1390B00 AS Date), 9, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1800', CAST(0xE1390B00 AS Date), 10, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1950', CAST(0xE3390B00 AS Date), 1008, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 3110', CAST(0xE3390B00 AS Date), 2008, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1040', CAST(0xE3390B00 AS Date), 2009, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 0', CAST(0xE3390B00 AS Date), 2010, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 0', CAST(0xE3390B00 AS Date), 2011, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1750', CAST(0xE3390B00 AS Date), 2012, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 2550', CAST(0xE3390B00 AS Date), 2013, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 7060', CAST(0xE3390B00 AS Date), 2014, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 1170', CAST(0xE3390B00 AS Date), 2015, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 980', CAST(0xE3390B00 AS Date), 2016, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 7330', CAST(0xE4390B00 AS Date), 2017, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 130', CAST(0xE4390B00 AS Date), 2018, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 2680', CAST(0xE4390B00 AS Date), 2019, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez ha generado una nueva factura por un monto de: 6400', CAST(0xE4390B00 AS Date), 2020, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 2355', CAST(0xE4390B00 AS Date), 2021, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 2355', CAST(0xE4390B00 AS Date), 2022, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 850', CAST(0xE4390B00 AS Date), 2023, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 135', CAST(0xE4390B00 AS Date), 2024, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 5400', CAST(0xE4390B00 AS Date), 2025, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 2820', CAST(0xE4390B00 AS Date), 2026, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 1835', CAST(0xE5390B00 AS Date), 2027, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2028, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 135', CAST(0xE5390B00 AS Date), 2029, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 7200', CAST(0xE5390B00 AS Date), 2030, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 270', CAST(0xE5390B00 AS Date), 2031, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 5700', CAST(0xE5390B00 AS Date), 2032, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 7605', CAST(0xE5390B00 AS Date), 2033, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 135', CAST(0xE5390B00 AS Date), 2034, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2035, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2036, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2037, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2038, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2039, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero Dangelo Rodriguez Muñoz ha generado una nueva factura por un monto de: 405', CAST(0xE5390B00 AS Date), 2040, 1)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[Cajero] ON 

INSERT [dbo].[Cajero] ([IDCajero], [NombreAcceso], [Contrasena], [Nombre], [Apellido], [Telefono], [Estado], [IDTipoAcceso]) VALUES (1, N'DJRM', N'djrm', N'Dangelo', N'Rodriguez Muñoz', N'61610641', 1, 1)
INSERT [dbo].[Cajero] ([IDCajero], [NombreAcceso], [Contrasena], [Nombre], [Apellido], [Telefono], [Estado], [IDTipoAcceso]) VALUES (2, N'Luis', N'luisca', N'Luis', N'Carrillo', N'89654789', 1, 2)
INSERT [dbo].[Cajero] ([IDCajero], [NombreAcceso], [Contrasena], [Nombre], [Apellido], [Telefono], [Estado], [IDTipoAcceso]) VALUES (3, N'maria', N'mari123', N'María', N'Arguedas', N'67648932', 0, 2)
INSERT [dbo].[Cajero] ([IDCajero], [NombreAcceso], [Contrasena], [Nombre], [Apellido], [Telefono], [Estado], [IDTipoAcceso]) VALUES (4, N'Mario.fallas', N'mario29', N'Mario', N'Fallas', N'89734362', 1, 2)
SET IDENTITY_INSERT [dbo].[Cajero] OFF
SET IDENTITY_INSERT [dbo].[DetFactura] ON 

INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 1, 1, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 130.0000, 520.0000, 2, 2, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 3, 2, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 130.0000, 260.0000, 4, 3, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 1800.0000, 3600.0000, 5, 3, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 6, 4, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 7, 4, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 8, 5, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 100.0000, 400.0000, 9, 5, N'086581311186')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1900.0000, 1900.0000, 10, 5, N'7441134002042')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 11, 6, N'7891024130933')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 12, 6, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 500.0000, 1000.0000, 13, 7, N'7891024136089')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 500.0000, 1000.0000, 14, 7, N'7891024130933')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 1800.0000, 3600.0000, 15, 8, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 16, 9, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 17, 10, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 150.0000, 150.0000, 1015, 1008, N'086581110888')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 1016, 1008, N'123')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 350.0000, 700.0000, 2015, 2008, N'7441003596993')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 130.0000, 390.0000, 2016, 2008, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 260.0000, 520.0000, 2017, 2008, N'7441000711528')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 500.0000, 1500.0000, 2018, 2008, N'7891024136089')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2019, 2009, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 260.0000, 780.0000, 2020, 2009, N'086581311193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2021, 2009, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 260.0000, 780.0000, 2022, 2010, N'7441000711528')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 1800.0000, 3600.0000, 2023, 2010, N'7441003571815')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2024, 2011, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (5, 350.0000, 1750.0000, 2025, 2012, N'7441003596993')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 850.0000, 2550.0000, 2026, 2013, N'7441003518483')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 130.0000, 260.0000, 2027, 2014, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (8, 850.0000, 6800.0000, 2028, 2014, N'7441003518483')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2029, 2015, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 260.0000, 1040.0000, 2030, 2015, N'7441000711528')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2031, 2016, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 850.0000, 850.0000, 2032, 2016, N'7441003518483')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2033, 2017, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 1800.0000, 7200.0000, 2034, 2017, N'7441003571815')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2035, 2018, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 130.0000, 130.0000, 2036, 2019, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 1800.0000, 1800.0000, 2037, 2019, N'7441003571815')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 750.0000, 750.0000, 2038, 2019, N'7441134002110')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (5, 260.0000, 1300.0000, 2039, 2020, N'7441000711528')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (6, 850.0000, 5100.0000, 2040, 2020, N'7441003545489')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 135.0000, 135.0000, 2041, 2030, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 1800.0000, 7200.0000, 2042, 2031, N'7441003520905')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (2, 135.0000, 270.0000, 2043, 2032, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 1900.0000, 5700.0000, 2044, 2033, N'7441134002042')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 135.0000, 405.0000, 2045, 2034, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (4, 1800.0000, 7200.0000, 2046, 2034, N'7441003571815')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 135.0000, 135.0000, 2047, 2035, N'086581014193')
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (3, 135.0000, 405.0000, 2048, 2040, N'086581014193')
SET IDENTITY_INSERT [dbo].[DetFactura] OFF
SET IDENTITY_INSERT [dbo].[Distribuidor] ON 

INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'HELADOS SENSACIÓN', N'Activo', N'24542113', 1)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'COCA-COLA', N'Activo', N'24473016', 2)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'POZUELO', N'Activo', N'24030263', 3)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'PIPASA', N'Activo', N'22930479', 4)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'DIANA', N'Activo', N'24471289', 5)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'TOSTY', N'Activo', N'24569812', 6)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'TortiRica', N'Activo', N'24780912', 7)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'Arvaco', N'Activo', N'24569789', 8)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'Pastas ROMA', N'Activo', N'25479087', 9)
INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'Jose Morales', N'Activo', N'89745210', 10)
SET IDENTITY_INSERT [dbo].[Distribuidor] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDC390B00 AS Date), 130.0000, 1, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDC390B00 AS Date), 2320.0000, 2, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDC390B00 AS Date), 3860.0000, 3, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDC390B00 AS Date), 1930.0000, 4, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDD390B00 AS Date), 4100.0000, 5, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDD390B00 AS Date), 2300.0000, 6, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xDD390B00 AS Date), 2000.0000, 7, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE1390B00 AS Date), 3600.0000, 8, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE1390B00 AS Date), 1930.0000, 9, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE1390B00 AS Date), 1800.0000, 10, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 1950.0000, 1008, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 3110.0000, 2008, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 1040.0000, 2009, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2010, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2011, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2012, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2013, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2014, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2015, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE3390B00 AS Date), 0.0000, 2016, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE4390B00 AS Date), 0.0000, 2017, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE4390B00 AS Date), 0.0000, 2018, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE4390B00 AS Date), 0.0000, 2019, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE4390B00 AS Date), 0.0000, 2020, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2030, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2031, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2032, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2033, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2034, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2035, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(0xE5390B00 AS Date), 0.0000, 2040, 1)
SET IDENTITY_INSERT [dbo].[Factura] OFF
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Sorbeto Festival Naranja unidad', 20, 135.0000, 3, N'086581014193')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Chiky chocolate individual ', 11, 150.0000, 3, N'086581110888')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Merendina Gatico guayaba unidad', 8, 100.0000, 3, N'086581311186')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Merendina Arrolladito unidad', 9, 260.0000, 3, N'086581311193')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'FANTA UVA 2 litros', 0, 1800.0000, 2, N'123')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Bravos Pizza 42g', 5, 260.0000, 5, N'7441000711528')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Cocacola zero 600ml', 9, 850.0000, 2, N'7441003518483')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Fanta Naranja 2.5 litros', 27, 1800.0000, 2, N'7441003520905')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Fresca toronja 600ml', 5, 850.0000, 2, N'7441003545489')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Canada Dry ginger ale 2 litros', 10, 1800.0000, 2, N'7441003571815')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Cocacola mini lata 237ml', 9, 350.0000, 2, N'7441003596993')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Helado Sensación Sensa-Crunch 495g', 20, 1900.0000, 1, N'7441134002042')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Helado Sensación Naranja piña 130g', 30, 750.0000, 1, N'7441134002110')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Helado Sensación Crema Chips 60g', 31, 385.0000, 1, N'7441134002127')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Quesitos 45g', 10, 350.0000, 6, N'748757007179')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'COLGATE Plax soft mint 60ml', 10, 500.0000, 8, N'7891024130933')
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Colgate plax ice', 20, 500.0000, 8, N'7891024136089')
SET IDENTITY_INSERT [dbo].[TipoAcceso] ON 

INSERT [dbo].[TipoAcceso] ([idTipoAcceso], [Rol]) VALUES (1, N'Administrador')
INSERT [dbo].[TipoAcceso] ([idTipoAcceso], [Rol]) VALUES (2, N'Usuario')
SET IDENTITY_INSERT [dbo].[TipoAcceso] OFF
USE [master]
GO
ALTER DATABASE [DBFacturacionM1] SET  READ_WRITE 
GO
