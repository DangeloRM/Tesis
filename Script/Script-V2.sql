USE [master]
GO
/****** Object:  Database [DBFacturacionM]    Script Date: 30/03/2015 08:28:05 p.m. ******/
CREATE DATABASE [DBFacturacionM] ON  PRIMARY 
( NAME = N'DBFacturacionM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DESARROLLO\MSSQL\DATA\DBFacturacionM.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBFacturacionM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DESARROLLO\MSSQL\DATA\DBFacturacionM_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[Cajero]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[DetFactura]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[Distribuidor]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  Table [dbo].[TipoAcceso]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[AgregarBitacora]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[AgregarDistribuidor]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[ReporteBitacora]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ConsultaProducto]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Detalle]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Factura]    Script Date: 30/03/2015 08:28:05 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Factura]
	@Fecha datetime,
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
/****** Object:  StoredProcedure [dbo].[SP_Producto]    Script Date: 30/03/2015 08:28:05 p.m. ******/
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
USE [master]
GO
ALTER DATABASE [DBFacturacionM] SET  READ_WRITE 
GO
