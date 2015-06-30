USE [CSCInventariosDB]
GO
/****** Object:  Table [dbo].[Estacion]    Script Date: 06/30/2015 16:45:13 ******/
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
	[estacion_eliminado] [bit] NULL,
 CONSTRAINT [PK_Estacion] PRIMARY KEY CLUSTERED 
(
	[estacion_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/30/2015 16:45:13 ******/
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
	[usuario_eliminado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 06/30/2015 16:45:13 ******/
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
	[material_eliminado] [bit] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[material_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[LeerTodosLosMateriales]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerTodosLosMateriales]

AS
BEGIN
	SELECT 
		material_id, 
		material_nombre, 
		material_modelo, 
		material_cantidad, 
		material_observacion, 
		material_eliminado
	from 
		dbo.Material

END
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 06/30/2015 16:45:13 ******/
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
	[sl_eliminado] [bit] NULL,
 CONSTRAINT [PK_Solicitud] PRIMARY KEY CLUSTERED 
(
	[sl_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[rq_id] [int] NOT NULL,
	[usuario_id] [int] NULL,
	[rq_fecha] [datetime] NULL,
	[rq_validacion] [bit] NULL,
	[rq_eliminado] [bit] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[rq_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ModificarMaterial]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ModificarMaterial]

	@material_id int, 
	@material_nombre nvarchar(50), 
	@material_modelo nvarchar(50), 
	@material_cantidad int, 
	@material_observacion nvarchar(50)
    
AS 
BEGIN 

 UPDATE dbo.Material
  SET 
	material_nombre = @material_nombre, 
	material_modelo = @material_modelo,
	material_cantidad = @material_cantidad,
	material_observacion = @material_observacion
	
  WHERE material_id = @material_id;

END
GO
/****** Object:  StoredProcedure [dbo].[ModificarEstacion]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarEstacion]
	@estacion_id int,
	@estacion_nombre nvarchar(50), 
	@estacion_zona nvarchar(50), 
	@estacion_coordenadas nvarchar(50), 
	@estacion_referencia nvarchar(50)
    
AS 
BEGIN 

 UPDATE dbo.Estacion
  SET 
	estacion_nombre = @estacion_nombre, 
	estacion_zona = @estacion_zona,
	estacion_coordenadas = @estacion_coordenadas,
	estacion_referencia = @estacion_referencia
	
  WHERE estacion_id = @estacion_id;

END
GO
/****** Object:  StoredProcedure [dbo].[CrearMaterial]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CrearMaterial]
	@material_nombre nvarchar(50), 
	@material_modelo nvarchar(50), 
	@material_cantidad int, 
	@material_observacion nvarchar(50), 
	@material_eliminado bit
	
    
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Material
          ( 
			material_nombre, 
			material_modelo, 
			material_cantidad, 
			material_observacion, 
			material_eliminado
          ) 
     VALUES 
          ( 
			@material_nombre , 
			@material_modelo , 
			@material_cantidad , 
			@material_observacion , 
			@material_eliminado 
          ) 

END
GO
/****** Object:  StoredProcedure [dbo].[CrearEstacion]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CrearEstacion]
	@estacion_nombre nvarchar(50), 
	@estacion_zona nvarchar(50), 
	@estacion_coordenadas nvarchar(50), 
	@estacion_referencia nvarchar(50)
    
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Estacion
          ( 
              estacion_nombre, 
              estacion_zona, 
              estacion_coordenadas, 
              estacion_referencia  
          ) 
     VALUES 
          ( 
				@estacion_nombre , 
				@estacion_zona , 
				@estacion_coordenadas , 
				@estacion_referencia
          ) 

END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMaterial]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarMaterial]
	@material_id int,
	@material_eliminado bit = 0

AS 
BEGIN 

 UPDATE dbo.Material
  SET 
	material_eliminado = @material_eliminado
	
  WHERE material_id = @material_id;

END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEstacion]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarEstacion]
	@estacion_id int,
	@estacion_eliminado bit = 0

AS 
BEGIN 

 UPDATE dbo.Estacion
  SET 
	estacion_eliminado = @estacion_eliminado
	
  WHERE estacion_id = @estacion_id;

END
GO
/****** Object:  StoredProcedure [dbo].[LeerTodasLasEstaciones]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerTodasLasEstaciones]

AS
BEGIN
	SELECT 
		estacion_id, 
		estacion_nombre, 
		estacion_zona, 
		estacion_coordenadas, 
		estacion_referencia

	from 
		Estacion 

END
GO
/****** Object:  StoredProcedure [dbo].[LeerMaterialPorMaterialId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerMaterialPorMaterialId]
	@material_id int
AS
BEGIN
	SELECT 
		material_id, 
		material_nombre, 
		material_modelo, 
		material_cantidad, 
		material_observacion

	from 
		 dbo.Material
	where 
		material_id = @material_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerMaterialPorCriterio]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[LeerMaterialPorCriterio]
	@criterio nvarchar(50)
AS
BEGIN
	SELECT 
		material_id, 
		material_nombre, 
		material_modelo, 
		material_cantidad, 
		material_observacion
	from 
		 dbo.Material
	where 
		material_nombre like @criterio  or material_modelo like @criterio or material_observacion like @criterio
END
GO
/****** Object:  StoredProcedure [dbo].[LeerEstacionPorEstacionId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[LeerEstacionPorEstacionId] 
	@estacion_id int
AS
BEGIN
	SELECT 
		estacion_id, 
		estacion_nombre, 
		estacion_zona, 
		estacion_coordenadas, 
		estacion_referencia

	from 
		Estacion 
	where 
		estacion_id = @estacion_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerEstacionPorCriterio]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerEstacionPorCriterio] 
	@criterio nvarchar(50)
AS
BEGIN
	SELECT 
		estacion_id, 
		estacion_nombre, 
		estacion_zona, 
		estacion_coordenadas, 
		estacion_referencia
	from 
		Estacion 
	where 
		estacion_nombre like @criterio  or estacion_zona like @criterio or estacion_referencia like @criterio
END
GO
/****** Object:  Table [dbo].[DetalleSolicitud]    Script Date: 06/30/2015 16:45:13 ******/
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
/****** Object:  Table [dbo].[DetalleRequerimiento]    Script Date: 06/30/2015 16:45:13 ******/
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
/****** Object:  Table [dbo].[Inventario]    Script Date: 06/30/2015 16:45:13 ******/
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
/****** Object:  StoredProcedure [dbo].[CrearDetalleSolicitud]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CrearDetalleSolicitud]
	@ds_id int, 
	@sl_id int, 
	@material_id int, 
	@ds_cantidad_solicitada int, 
	@ds_cantidad_asignada int, 
	@ds_cantidad_aceptada int
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO DetalleSolicitud
          ( 
			sl_id, 
			material_id, 
			ds_cantidad_solicitada, 
			ds_cantidad_asignada, 
			ds_cantidad_aceptada
          ) 
     VALUES 
          ( 
			@sl_id, 
			@material_id, 
			@ds_cantidad_solicitada, 
			@ds_cantidad_asignada, 
			@ds_cantidad_aceptada
          ) 

END
GO
/****** Object:  StoredProcedure [dbo].[CrearDetalleRequerimiento]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CrearDetalleRequerimiento]
	@dr_id int, 
	@rq_id int, 
	@material_id int, 
	@dr_cantidad_rq int, 
	@dr_cantidad_ingreso int
    
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO DetalleRequerimiento
          ( 
				 rq_id, 
				 material_id, 
				 dr_cantidad_rq, 
				 dr_cantidad_ingreso
          ) 
     VALUES 
          ( 
				@rq_id , 
				@material_id , 
				@dr_cantidad_rq , 
				@dr_cantidad_ingreso 
          ) 

END
GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleSolicitud]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ModificarDetalleSolicitud]
	@ds_id int, 
	@sl_id int, 
	@material_id int, 
	@ds_cantidad_solicitada int, 
	@ds_cantidad_asignada int, 
	@ds_cantidad_aceptada int

AS 
BEGIN 

 UPDATE dbo.DetalleSolicitud
  SET 
	sl_id = @sl_id, 
	material_id = @material_id,
	ds_cantidad_solicitada = @ds_cantidad_solicitada,
	ds_cantidad_asignada = @ds_cantidad_asignada,
	ds_cantidad_aceptada = @ds_cantidad_aceptada	
	
  WHERE @ds_id = @ds_id;

END
GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleRequerimiento]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ModificarDetalleRequerimiento]

    @dr_id int, 
    @rq_id int, 
    @material_id int, 
    @dr_cantidad_rq int, 
    @dr_cantidad_ingreso int
AS 
BEGIN 

 UPDATE dbo.DetalleRequerimiento
  SET 
	rq_id = @rq_id, 
	material_id = @material_id,
	dr_cantidad_rq = @dr_cantidad_rq,
	dr_cantidad_ingreso = @dr_cantidad_ingreso
	
  WHERE @dr_id = @dr_id;

END
GO
/****** Object:  StoredProcedure [dbo].[LeerTodosLosDetalleSolicitud]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerTodosLosDetalleSolicitud]

AS
BEGIN
	SELECT 
		ds_id, 
		sl_id, 
		material_id, 
		ds_cantidad_solicitada, 
		ds_cantidad_asignada, 
		ds_cantidad_aceptada
	from 
		dbo.DetalleSolicitud

END
GO
/****** Object:  StoredProcedure [dbo].[LeerTodosLosDetalleRequerimiento]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerTodosLosDetalleRequerimiento]

AS
BEGIN
	SELECT 
		dr_id, 
		rq_id, 
		material_id, 
		dr_cantidad_rq, 
		dr_cantidad_ingreso
	from 
		dbo.DetalleRequerimiento

END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleSolicitudPorSlId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleSolicitudPorSlId]
	@sl_id int
AS
BEGIN
	SELECT 
		ds_id, 
		sl_id, 
		material_id, 
		ds_cantidad_solicitada, 
		ds_cantidad_asignada, 
		ds_cantidad_aceptada
	from 
		DetalleSolicitud 
	where 
		sl_id = @sl_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleSolicitudPorMaterialId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleSolicitudPorMaterialId]
	@material_id int
AS
BEGIN
	SELECT 
		ds_id, 
		sl_id, 
		material_id, 
		ds_cantidad_solicitada, 
		ds_cantidad_asignada, 
		ds_cantidad_aceptada
	from 
		DetalleSolicitud 
	where 
		material_id = @material_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleSolicitudPorDsId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleSolicitudPorDsId] 
	@ds_id int
AS
BEGIN
	SELECT 
		ds_id, 
		sl_id, 
		material_id, 
		ds_cantidad_solicitada, 
		ds_cantidad_asignada, 
		ds_cantidad_aceptada
	from 
		DetalleSolicitud 
	where 
		ds_id = @ds_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleRequerimientoPorRqId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleRequerimientoPorRqId] 
	@rq_id int
AS
BEGIN
	SELECT 
		dr_id, 
		rq_id, 
		material_id, 
		dr_cantidad_rq, 
		dr_cantidad_ingreso
	from 
		DetalleRequerimiento 
	where 
		rq_id = @rq_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleRequerimientoPorMaterialId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleRequerimientoPorMaterialId] 
	@material_id int
AS
BEGIN
	SELECT 
		dr_id, 
		rq_id, 
		material_id, 
		dr_cantidad_rq, 
		dr_cantidad_ingreso
	from 
		DetalleRequerimiento 
	where 
		material_id = @material_id
END
GO
/****** Object:  StoredProcedure [dbo].[LeerDetalleRequerimientoPorDrId]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[LeerDetalleRequerimientoPorDrId] 
	@dr_id int
AS
BEGIN
	SELECT 
		dr_id, 
		rq_id, 
		material_id, 
		dr_cantidad_rq, 
		dr_cantidad_ingreso
	from 
		DetalleRequerimiento 
	where 
		dr_id = @dr_id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarDetalleSolicitud]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarDetalleSolicitud]
	@ds_id int
as
BEGIN 

DELETE FROM DetalleSolicitud
WHERE ds_id=@ds_id

END
GO
/****** Object:  StoredProcedure [dbo].[EliminarDetalleRequerimiento]    Script Date: 06/30/2015 16:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarDetalleRequerimiento]
	@dr_id int
as
BEGIN 

DELETE FROM DetalleRequerimiento
WHERE dr_id=@dr_id

END
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Material]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Material] FOREIGN KEY([material_id])
REFERENCES [dbo].[Material] ([material_id])
GO
ALTER TABLE [dbo].[DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Material]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Requerimiento]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Requerimiento] FOREIGN KEY([rq_id])
REFERENCES [dbo].[Requerimiento] ([rq_id])
GO
ALTER TABLE [dbo].[DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Requerimiento]
GO
/****** Object:  ForeignKey [FK_DetalleSolicitud_Material]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_DetalleSolicitud_Material] FOREIGN KEY([material_id])
REFERENCES [dbo].[Material] ([material_id])
GO
ALTER TABLE [dbo].[DetalleSolicitud] CHECK CONSTRAINT [FK_DetalleSolicitud_Material]
GO
/****** Object:  ForeignKey [FK_DetalleSolicitud_Solicitud]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_DetalleSolicitud_Solicitud] FOREIGN KEY([sl_id])
REFERENCES [dbo].[Solicitud] ([sl_id])
GO
ALTER TABLE [dbo].[DetalleSolicitud] CHECK CONSTRAINT [FK_DetalleSolicitud_Solicitud]
GO
/****** Object:  ForeignKey [FK_Inventario_Requerimiento]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Requerimiento] FOREIGN KEY([rq_id])
REFERENCES [dbo].[Requerimiento] ([rq_id])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Requerimiento]
GO
/****** Object:  ForeignKey [FK_Inventario_Solicitud]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Solicitud] FOREIGN KEY([sl_id])
REFERENCES [dbo].[Solicitud] ([sl_id])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Solicitud]
GO
/****** Object:  ForeignKey [FK_Requerimiento_Usuario]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Usuario]
GO
/****** Object:  ForeignKey [FK_Solicitud_Estacion]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Estacion] FOREIGN KEY([estacion_id])
REFERENCES [dbo].[Estacion] ([estacion_id])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_Solicitud_Estacion]
GO
/****** Object:  ForeignKey [FK_Solicitud_Usuario]    Script Date: 06/30/2015 16:45:13 ******/
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_Solicitud_Usuario]
GO
