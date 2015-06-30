USE [CSCInventariosDB]
GO
/****** Object:  Table [dbo].[Estacion]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estacion](
	[estacion_id] [int] IDENTITY(1,1) NOT NULL,
	[estacion_nombre] [nvarchar](50) NULL,
	[estacion_zona] [nvarchar](50) NULL,
	[estacion_coordenadas] [nvarchar](50) NULL,
	[estacion_referencia] [nvarchar](50) NULL,
 CONSTRAINT [PK_Estacion] PRIMARY KEY CLUSTERED 
(
	[estacion_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[material_id] [int] IDENTITY(1,1) NOT NULL,
	[material_nombre] [nvarchar](50) NULL,
	[material_modelo] [nvarchar](50) NULL,
	[material_cantidad] [int] NULL,
	[material_observacion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[material_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_nombre] [nvarchar](50) NULL,
	[usuario_apellido] [nvarchar](50) NULL,
	[usuario_telefono] [nvarchar](50) NULL,
	[usuario_usuario] [nvarchar](50) NULL,
	[usuario_clave] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud](
	[sl_id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[estacion_id] [int] NULL,
	[sl_feha] [datetime] NULL,
	[sl_recepcion] [bit] NULL,
	[sl_asignacion] [bit] NULL,
	[sl_atencion] [bit] NULL,
	[sl_aceptacion] [bit] NULL,
 CONSTRAINT [PK_Solicitud] PRIMARY KEY CLUSTERED 
(
	[sl_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[rq_id] [int] NOT NULL,
	[usuario_id] [int] NULL,
	[rq_fecha] [datetime] NULL,
	[rq_validacion] [bit] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[rq_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[inventario_id] [int] IDENTITY(1,1) NOT NULL,
	[sl_id] [int] NULL,
	[rq_id] [int] NULL,
	[inventario_cantidad] [int] NULL,
	[inventario_accion] [bit] NULL,
	[inventario_fecha] [datetime] NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[inventario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleSolicitud]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleSolicitud](
	[ds_id] [int] IDENTITY(1,1) NOT NULL,
	[sl_id] [int] NOT NULL,
	[material_id] [int] NULL,
	[ds_cantidad_solicitada] [int] NULL,
	[ds_cantidad_asignada] [int] NULL,
	[ds_cantidad_aceptada] [int] NULL,
 CONSTRAINT [PK_DetalleSolicitud] PRIMARY KEY CLUSTERED 
(
	[ds_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleRequerimiento]    Script Date: 06/30/2015 01:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleRequerimiento](
	[dr_id] [int] NOT NULL,
	[rq_id] [int] NOT NULL,
	[material_id] [int] NOT NULL,
	[dr_cantidad_rq] [int] NULL,
	[dr_cantidad_ingreso] [int] NULL,
 CONSTRAINT [PK_DetalleRequerimiento] PRIMARY KEY CLUSTERED 
(
	[dr_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Material]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Material] FOREIGN KEY([material_id])
REFERENCES [dbo].[Material] ([material_id])
GO
ALTER TABLE [dbo].[DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Material]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Requerimiento]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Requerimiento] FOREIGN KEY([rq_id])
REFERENCES [dbo].[Requerimiento] ([rq_id])
GO
ALTER TABLE [dbo].[DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Requerimiento]
GO
/****** Object:  ForeignKey [FK_DetalleSolicitud_Material]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_DetalleSolicitud_Material] FOREIGN KEY([material_id])
REFERENCES [dbo].[Material] ([material_id])
GO
ALTER TABLE [dbo].[DetalleSolicitud] CHECK CONSTRAINT [FK_DetalleSolicitud_Material]
GO
/****** Object:  ForeignKey [FK_DetalleSolicitud_Solicitud]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_DetalleSolicitud_Solicitud] FOREIGN KEY([sl_id])
REFERENCES [dbo].[Solicitud] ([sl_id])
GO
ALTER TABLE [dbo].[DetalleSolicitud] CHECK CONSTRAINT [FK_DetalleSolicitud_Solicitud]
GO
/****** Object:  ForeignKey [FK_Inventario_Requerimiento]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Requerimiento] FOREIGN KEY([rq_id])
REFERENCES [dbo].[Requerimiento] ([rq_id])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Requerimiento]
GO
/****** Object:  ForeignKey [FK_Inventario_Solicitud]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Solicitud] FOREIGN KEY([sl_id])
REFERENCES [dbo].[Solicitud] ([sl_id])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Solicitud]
GO
/****** Object:  ForeignKey [FK_Requerimiento_Usuario]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Usuario]
GO
/****** Object:  ForeignKey [FK_Solicitud_Estacion]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Estacion] FOREIGN KEY([estacion_id])
REFERENCES [dbo].[Estacion] ([estacion_id])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_Solicitud_Estacion]
GO
/****** Object:  ForeignKey [FK_Solicitud_Usuario]    Script Date: 06/30/2015 01:03:23 ******/
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_Solicitud_Usuario]
GO
