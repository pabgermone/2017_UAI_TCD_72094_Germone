
CREATE TABLE [dbo].[Aerolinea](
	[aerolinea_id] [int] IDENTITY(1,1) NOT NULL,
	[aerolinea_nombre] [varchar](100) NULL,
 CONSTRAINT [PK__Aeroline__039221DD7F60ED59] PRIMARY KEY CLUSTERED 
(
	[aerolinea_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asiento]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asiento](
	[asiento_numero] [int] IDENTITY(1,1) NOT NULL,
	[asiento_vuelo_numero] [varchar](10) NOT NULL,
	[asiento_ocupado] [bit] NOT NULL,
 CONSTRAINT [PK__Asiento__C41DDDFE0BC6C43E] PRIMARY KEY CLUSTERED 
(
	[asiento_numero] ASC,
	[asiento_vuelo_numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[cliente_id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_nombre] [varchar](50) NULL,
	[cliente_apellido] [varchar](50) NULL,
	[cliente_dni] [int] NULL,
	[cliente_pasaporte] [int] NULL,
	[cliente_fechaNac] [date] NULL,
	[cliente_telefono] [int] NULL,
	[cliente_sexo] [varchar](50) NULL,
	[cliente_estadoCivil] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[cliente_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Destino]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
/****** Object:  Table [dbo].[Paquete]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[permiso_id] [int] IDENTITY(1,1) NOT NULL,
	[permiso_nombre] [varchar](50) NOT NULL,
	[permiso_padre] [int] NOT NULL,
	[permiso_formulario] [varchar](50) NULL,
 CONSTRAINT [PK__Permiso__60B569CD22AA2996] PRIMARY KEY CLUSTERED 
(
	[permiso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PermisoCompuesto]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisoCompuesto](
	[permisoCompuesto_id] [int] IDENTITY(1,1) NOT NULL,
	[permisoCompuesto_nombre] [varchar](50) NOT NULL,
	[permisoCompuesto_padre] [int] NULL,
	[permisoCompuesto_formulario] [varchar](50) NULL,
 CONSTRAINT [PK__PermisoC__6E99017F1DE57479] PRIMARY KEY CLUSTERED 
(
	[permisoCompuesto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[rol_id] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Rol__CF32E443276EDEB3] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RolPermiso]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
/****** Object:  Table [dbo].[RolPermisoCompuesto]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
 CONSTRAINT [PK__Usuario__2ED7D2AF36B12243] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[venta_id] [int] IDENTITY(1,1) NOT NULL,
	[venta_usuario] [int] NOT NULL,
	[venta_fecha] [date] NOT NULL,
	[venta_precio] [decimal](19, 2) NOT NULL,
	[venta_paquete] [int] NULL,
 CONSTRAINT [PK__Venta__B13508093E52440B] PRIMARY KEY CLUSTERED 
(
	[venta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VentaCliente]    Script Date: 5/6/2017 12:29:47 a. m. ******/
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
/****** Object:  Table [dbo].[VentaVuelo]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaVuelo](
	[ventaVuelo_venta] [int] NOT NULL,
	[ventaVuelo_vuelo] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ventaVuelo_venta] ASC,
	[ventaVuelo_vuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vuelo]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vuelo](
	[vuelo_numero] [varchar](10) NOT NULL,
	[vuelo_disponible] [bit] NOT NULL,
	[vuelo_fecha] [date] NOT NULL,
	[vuelo_hora] [time](7) NOT NULL,
	[vuelo_destino] [int] NOT NULL,
	[vuelo_aerolinea] [int] NOT NULL,
 CONSTRAINT [PK_Vuelo_1] PRIMARY KEY CLUSTERED 
(
	[vuelo_numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VueloCliente]    Script Date: 5/6/2017 12:29:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VueloCliente](
	[vueloCliente_vuelo] [varchar](10) NOT NULL,
	[vueloCliente_cliente] [int] NOT NULL,
 CONSTRAINT [PK_VueloCliente] PRIMARY KEY CLUSTERED 
(
	[vueloCliente_vuelo] ASC,
	[vueloCliente_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (8, N'Declarar Permisos', 10, N'InterfazUsuario.FormPermisos')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (9, N'Declarar Roles', 10, N'InterfazUsuario.FormRoles')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (10, N'Asignar Roles', 10, N'InterfazUsuario.FormAsignacion')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (11, N'Alta Usuario', 10, N'InterfazUsuario.FormRegistro')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (12, N'ABM Vuelos-Aerolineas', 11, N'InterfazUsuario.FormAerolineas')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (13, N'ABM Clientes', 11, N'InterfazUsuario.FormClientes')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (14, N'ABM Destinos', 11, N'InterfazUsuario.FormDestinos')
INSERT [dbo].[Permiso] ([permiso_id], [permiso_nombre], [permiso_padre], [permiso_formulario]) VALUES (15, N'Ventas', 11, N'InterfazUsuario.FormVentas')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
SET IDENTITY_INSERT [dbo].[PermisoCompuesto] ON 

INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario]) VALUES (0, N' Permisos del Sistema', NULL, NULL)
INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario]) VALUES (10, N'Seguridad', 0, N'')
INSERT [dbo].[PermisoCompuesto] ([permisoCompuesto_id], [permisoCompuesto_nombre], [permisoCompuesto_padre], [permisoCompuesto_formulario]) VALUES (11, N'Negocio', 0, N'')
SET IDENTITY_INSERT [dbo].[PermisoCompuesto] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([rol_id], [rol_nombre]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[Rol] OFF
INSERT [dbo].[RolPermisoCompuesto] ([rolPermisoCompuesto_rol], [rolPermisoCompuesto_Permiso]) VALUES (1, 0)
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([usuario_id], [usuario_userName], [usuario_nombre], [usuario_apellido], [usuario_password], [usuario_rol]) VALUES (1, N'Administrador', N'', N'', N'2A2E9A58102784CA18E2605A4E727B5F', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_Rol_rolNombre]    Script Date: 5/6/2017 12:29:47 a. m. ******/
ALTER TABLE [dbo].[Rol] ADD  CONSTRAINT [UQ_Rol_rolNombre] UNIQUE NONCLUSTERED 
(
	[rol_nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Usuario__80C2FBAC398D8EEE]    Script Date: 5/6/2017 12:29:47 a. m. ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UQ__Usuario__80C2FBAC398D8EEE] UNIQUE NONCLUSTERED 
(
	[usuario_userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asiento]  WITH CHECK ADD  CONSTRAINT [FK_Asiento_Vuelo] FOREIGN KEY([asiento_vuelo_numero])
REFERENCES [dbo].[Vuelo] ([vuelo_numero])
GO
ALTER TABLE [dbo].[Asiento] CHECK CONSTRAINT [FK_Asiento_Vuelo]
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
ALTER TABLE [dbo].[VentaVuelo]  WITH CHECK ADD  CONSTRAINT [FK__VentaVuel__venta__4BAC3F29] FOREIGN KEY([ventaVuelo_venta])
REFERENCES [dbo].[Venta] ([venta_id])
GO
ALTER TABLE [dbo].[VentaVuelo] CHECK CONSTRAINT [FK__VentaVuel__venta__4BAC3F29]
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
ALTER TABLE [dbo].[VueloCliente]  WITH CHECK ADD  CONSTRAINT [FK_VueloCliente_Cliente] FOREIGN KEY([vueloCliente_cliente])
REFERENCES [dbo].[Cliente] ([cliente_id])
GO
ALTER TABLE [dbo].[VueloCliente] CHECK CONSTRAINT [FK_VueloCliente_Cliente]
GO
ALTER TABLE [dbo].[VueloCliente]  WITH CHECK ADD  CONSTRAINT [FK_VueloCliente_Vuelo] FOREIGN KEY([vueloCliente_vuelo])
REFERENCES [dbo].[Vuelo] ([vuelo_numero])
GO
ALTER TABLE [dbo].[VueloCliente] CHECK CONSTRAINT [FK_VueloCliente_Vuelo]
GO
USE [master]
GO
ALTER DATABASE [Campo2017_VentaPasajes] SET  READ_WRITE 
GO
