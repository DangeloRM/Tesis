USE [master]
GO
/****** Object:  Database [DBFacturacionM]    Script Date: 31/03/2015 10:08:58 a.m. ******/
CREATE DATABASE [DBFacturacionM] ON  PRIMARY 
( NAME = N'DBFacturacionM', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.DESARROLLO\MSSQL\DATA\DBFacturacionM.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBFacturacionM_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.DESARROLLO\MSSQL\DATA\DBFacturacionM_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBFacturacionM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBFacturacionM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBFacturacionM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBFacturacionM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBFacturacionM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBFacturacionM] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBFacturacionM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBFacturacionM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBFacturacionM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBFacturacionM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBFacturacionM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBFacturacionM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBFacturacionM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBFacturacionM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBFacturacionM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBFacturacionM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBFacturacionM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBFacturacionM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBFacturacionM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBFacturacionM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBFacturacionM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBFacturacionM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBFacturacionM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBFacturacionM] SET RECOVERY FULL 
GO
ALTER DATABASE [DBFacturacionM] SET  MULTI_USER 
GO
ALTER DATABASE [DBFacturacionM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBFacturacionM] SET DB_CHAINING OFF 
GO
USE [DBFacturacionM]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
/****** Object:  Table [dbo].[Cajero]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
/****** Object:  Table [dbo].[DetFactura]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetFactura](
	[Cantidad] [int] NOT NULL,
	[Monto] [money] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[CodDetFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[CodProd] [int] NOT NULL,
 CONSTRAINT [PK__DetFactu__1DD0404F836F0329] PRIMARY KEY CLUSTERED 
(
	[CodDetFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Distribuidor]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
	[CodProducto] [int] NOT NULL,
 CONSTRAINT [PK__Producto__0D06FDF3618A4DA6] PRIMARY KEY CLUSTERED 
(
	[CodProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAcceso]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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

INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero WOrozco ha generado una nueva factura con un monto de: 500 a las: 00:00:00', CAST(N'2015-03-31' AS Date), 1, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero WOrozco ha generado una nueva factura con un monto de: 500 a las: 00:00:00', CAST(N'2015-03-31' AS Date), 2, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero WOrozco ha generado una nueva factura con un monto de: 500 a las: 00:00:00', CAST(N'2015-03-31' AS Date), 3, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero WOrozco ha generado una nueva factura con un monto de: 500 a las: 00:00:00', CAST(N'2015-03-31' AS Date), 4, 1)
INSERT [dbo].[Bitacora] ([Evento], [Fecha], [CodBitacora], [IDCajero]) VALUES (N'El cajero WOrozco ha generado una nueva factura con un monto de: 1500 a las: 00:00:00', CAST(N'2015-03-31' AS Date), 5, 1)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[Cajero] ON 

INSERT [dbo].[Cajero] ([IDCajero], [NombreAcceso], [Contrasena], [Nombre], [Apellido], [Telefono], [Estado], [IDTipoAcceso]) VALUES (1, N'WOrozco', N'12', N'William', N'Orozco', N'6176-4941', 1, 1)
SET IDENTITY_INSERT [dbo].[Cajero] OFF
SET IDENTITY_INSERT [dbo].[DetFactura] ON 

INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 3, 16, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 4, 17, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 5, 18, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 6, 19, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 7, 20, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 8, 20, 1)
INSERT [dbo].[DetFactura] ([Cantidad], [Monto], [Subtotal], [CodDetFactura], [IdFactura], [CodProd]) VALUES (1, 500.0000, 500.0000, 9, 20, 1)
SET IDENTITY_INSERT [dbo].[DetFactura] OFF
SET IDENTITY_INSERT [dbo].[Distribuidor] ON 

INSERT [dbo].[Distribuidor] ([Nombre], [Estado], [Telefono], [CodDistribuidor]) VALUES (N'Arvaco', N'Activo', N'2255-6677', 1)
SET IDENTITY_INSERT [dbo].[Distribuidor] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 2, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 3, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 4, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 5, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 3500.0000, 6, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 3500.0000, 7, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 3500.0000, 8, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 3500.0000, 9, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 10, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 11, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 12, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 13, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 14, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 15, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 16, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 17, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 18, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 500.0000, 19, 1)
INSERT [dbo].[Factura] ([Fecha], [Total], [IdFactura], [IDCajero]) VALUES (CAST(N'2015-03-31' AS Date), 1500.0000, 20, 1)
SET IDENTITY_INSERT [dbo].[Factura] OFF
INSERT [dbo].[Producto] ([NombreProd], [CantidadProd], [Precio], [CodDistribuidor], [CodProducto]) VALUES (N'Test', 95, 500.0000, 1, 1)
SET IDENTITY_INSERT [dbo].[TipoAcceso] ON 

INSERT [dbo].[TipoAcceso] ([idTipoAcceso], [Rol]) VALUES (1, N'Administrador')
INSERT [dbo].[TipoAcceso] ([idTipoAcceso], [Rol]) VALUES (2, N'Usuario')
SET IDENTITY_INSERT [dbo].[TipoAcceso] OFF
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK__Bitacora__IDCaje__20C1E124] FOREIGN KEY([IDCajero])
REFERENCES [dbo].[Cajero] ([IDCajero])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK__Bitacora__IDCaje__20C1E124]
GO
ALTER TABLE [dbo].[Cajero]  WITH CHECK ADD  CONSTRAINT [FK_Cajero_TipoAcceso] FOREIGN KEY([IDTipoAcceso])
REFERENCES [dbo].[TipoAcceso] ([idTipoAcceso])
GO
ALTER TABLE [dbo].[Cajero] CHECK CONSTRAINT [FK_Cajero_TipoAcceso]
GO
ALTER TABLE [dbo].[DetFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetFactura_Factura] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Factura] ([IdFactura])
GO
ALTER TABLE [dbo].[DetFactura] CHECK CONSTRAINT [FK_DetFactura_Factura]
GO
ALTER TABLE [dbo].[DetFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetFactura_Producto] FOREIGN KEY([CodProd])
REFERENCES [dbo].[Producto] ([CodProducto])
GO
ALTER TABLE [dbo].[DetFactura] CHECK CONSTRAINT [FK_DetFactura_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK__Factura__IDCajer__239E4DCF] FOREIGN KEY([IDCajero])
REFERENCES [dbo].[Cajero] ([IDCajero])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK__Factura__IDCajer__239E4DCF]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK__Producto__CodDis__2FCF1A8A] FOREIGN KEY([CodDistribuidor])
REFERENCES [dbo].[Distribuidor] ([CodDistribuidor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK__Producto__CodDis__2FCF1A8A]
GO
/****** Object:  StoredProcedure [dbo].[Acceso]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Acceso]
	@Cajero varchar(50)
as
begin
	select c.IDCajero, c.NombreAcceso, c.Contrasena, c.Nombre, 
		   c.Apellido, c.Telefono, c.Estado, c.IDTipoAcceso, case 
		   when t.Rol = 'Administrador' then 1 else 0 end AS Rol 
		from Cajero c inner join TipoAcceso t on 
					c.IDTipoAcceso = t.idTipoAcceso
		where (c.NombreAcceso = @Cajero);
end
GO
/****** Object:  StoredProcedure [dbo].[AgregarBitacora]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[AgregarBitacora]
@CodigoBitac int,@Event varchar(200),@IDCajer int
as
begin
 insert into Bitacora(Evento,IDCajero, Fecha)
 values(@Event,@IDCajer, GetDate())
end



GO
/****** Object:  StoredProcedure [dbo].[AgregarDistribuidor]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[AgregarDistribuidor]
@CodDistr int,@Nomb varchar(25), @Esta varchar(13),@Telef varchar(15)
as
begin
 insert into Distribuidor(Nombre,Estado,Telefono)
 values(@Nomb, @Esta,@Telef)
end



GO
/****** Object:  StoredProcedure [dbo].[ReducirStock]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReducirStock]
	@IdProducto int,
	@Cantidad int
as
begin
declare @existencias int;
declare @nuevacantidad int;
set @existencias = (select p.CantidadProd from Producto p where p.CodProducto = @IdProducto);
set @nuevacantidad = @existencias - @Cantidad;
update Producto set CantidadProd = @nuevacantidad where CodProducto = @IdProducto;
end
GO
/****** Object:  StoredProcedure [dbo].[ReporteBitacora]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ReporteBitacora]

as
begin

	select CodBitacora as Código_Bitácora, Evento, Fecha as Fecha_Realización, IDCajero as Cédula
	from Bitacora

end


GO
/****** Object:  StoredProcedure [dbo].[SP_ConsultaProducto]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ConsultaProducto]
	@Id int,
	@Accion int
as
begin
	if @Accion = 1
	begin
		Select p.CodProducto, p.NombreProd, p.Precio, p.CantidadProd, p.CodDistribuidor 
			from Producto p where p.CodProducto = @Id;
	end
	else
	begin
		Select p.CodProducto, p.NombreProd, p.Precio, p.CantidadProd, d.Nombre as Distribuidor 
			from Producto p inner join Distribuidor d on p.CodDistribuidor = d.CodDistribuidor
	end
end


GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Detalle]
	@idFactura int,
	@CodP int,
	@Cantidad int,
	@Monto money,
	@SubTotal money
as
begin
	insert into DetFactura (IdFactura, CodProd, Cantidad, Monto, Subtotal) values (@idFactura, @CodP, @Cantidad, @Monto, @SubTotal);
end


GO
/****** Object:  StoredProcedure [dbo].[SP_Factura]    Script Date: 31/03/2015 10:08:58 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Producto]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Producto]
	@Id int,
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
	begin
		insert into Producto (CodProducto, CodDistribuidor, Precio, CantidadProd, NombreProd) values (@Id, @Dis, @Precio, 1, @Nombre);
		return 1;
	end
	else
	begin
		set @aux = (Select p.CantidadProd from Producto p where p.CodProducto = @Id);
		set @aux_2 = @aux + @Cantidad;
		update Producto set NombreProd = @Nombre, CodDistribuidor = @Dis, CantidadProd = @aux_2 ,Precio = @Precio 
		where CodProducto = @Id;
		return 1;
	end
end


GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteFactura]    Script Date: 31/03/2015 10:08:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Dangelo>
-- Create date: <31/03/2015>
-- Description:	<Reporte Crystal>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ReporteFactura]
	-- Add the parameters for the stored procedure here
	@idFactura int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dt.CodProd, p.NombreProd, dt.Monto,
		   dt.Cantidad, dt.Subtotal 
	FROM DetFactura dt inner join Producto p on dt.CodProd = p.CodProducto
	WHERE dt.IdFactura = @idFactura;
END

GO
USE [master]
GO
ALTER DATABASE [DBFacturacionM] SET  READ_WRITE 
GO
