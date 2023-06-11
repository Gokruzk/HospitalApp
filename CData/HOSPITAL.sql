USE [HOSPITAL]
GO
/****** Object:  UserDefinedDataType [dbo].[Dir]    Script Date: 6/10/2023 10:58:12 PM ******/
CREATE TYPE [dbo].[Dir] FROM [varchar](100) NOT NULL
GO
/****** Object:  UserDefinedDataType [dbo].[Nombre]    Script Date: 6/10/2023 10:58:12 PM ******/
CREATE TYPE [dbo].[Nombre] FROM [varchar](80) NOT NULL
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Cedula] [char](10) NOT NULL,
	[Nombre] [dbo].[Nombre] NOT NULL,
	[Direccion] [dbo].[Dir] NOT NULL,
	[NumeroSeguridadSocial] [varchar](20) NOT NULL,
	[TipoEmpleado] [varchar](20) NOT NULL,
	[Poblacion] [int] NOT NULL,
	[Estado] [int] NULL,
	[FechaNacimiento] [datetime] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[HorarioID] [int] IDENTITY(1,1) NOT NULL,
	[CedulaMedico] [char](10) NOT NULL,
	[DiaSemana] [varchar](20) NOT NULL,
	[HoraInicio] [time](7) NOT NULL,
	[HoraFin] [time](7) NOT NULL,
 CONSTRAINT [PK__Horarios__BB881A9EE93882DC] PRIMARY KEY CLUSTERED 
(
	[HorarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[Cedula] [char](10) NOT NULL,
	[Nombre] [dbo].[Nombre] NOT NULL,
	[Direccion] [dbo].[Dir] NOT NULL,
	[NumeroSeguridadSocial] [varchar](20) NOT NULL,
	[NumeroColegiado] [varchar](20) NOT NULL,
	[TipoMedico] [varchar](20) NOT NULL,
	[Poblacion] [int] NOT NULL,
	[FechaA] [date] NULL,
	[FechaB] [date] NULL,
	[Estado] [int] NULL,
	[FechaNacimiento] [datetime] NULL,
 CONSTRAINT [PK_Medicos] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Cedula] [char](10) NOT NULL,
	[Nombre] [dbo].[Nombre] NOT NULL,
	[Direccion] [dbo].[Dir] NOT NULL,
	[NumeroSeguridadSocial] [varchar](20) NOT NULL,
	[CedulaMedico] [char](10) NOT NULL,
	[Estado] [int] NULL,
	[FechaNacimiento] [datetime] NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonaEstado]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonaEstado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PersonaEstado_pk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poblacion]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poblacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NOT NULL,
 CONSTRAINT [PK__Poblacio__3213E83FA991C021] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacaciones]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacaciones](
	[VacacionesID] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](10) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK__Vacacion__DC3149A0AC5FAA4B] PRIMARY KEY CLUSTERED 
(
	[VacacionesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VacacionesEstado]    Script Date: 6/10/2023 10:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VacacionesEstado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [VacacionesEstado_pk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [Empleados_Poblacion__fk] FOREIGN KEY([Poblacion])
REFERENCES [dbo].[Poblacion] ([id])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [Empleados_Poblacion__fk]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [EstadoEmpleado_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[PersonaEstado] ([Id])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [EstadoEmpleado_fk]
GO
ALTER TABLE [dbo].[Horarios]  WITH CHECK ADD  CONSTRAINT [FK_Horarios_Medicos] FOREIGN KEY([CedulaMedico])
REFERENCES [dbo].[Medicos] ([Cedula])
GO
ALTER TABLE [dbo].[Horarios] CHECK CONSTRAINT [FK_Horarios_Medicos]
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [Medicos_Estado_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[PersonaEstado] ([Id])
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [Medicos_Estado_fk]
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [Medicos_Poblacion__fk] FOREIGN KEY([Poblacion])
REFERENCES [dbo].[Poblacion] ([id])
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [Medicos_Poblacion__fk]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [EstadoPaciente_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[PersonaEstado] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [EstadoPaciente_fk]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Medicos] FOREIGN KEY([CedulaMedico])
REFERENCES [dbo].[Medicos] ([Cedula])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Medicos]
GO
ALTER TABLE [dbo].[Vacaciones]  WITH CHECK ADD  CONSTRAINT [FK_Medicos_Vacaciones] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Empleados] ([Cedula])
GO
ALTER TABLE [dbo].[Vacaciones] CHECK CONSTRAINT [FK_Medicos_Vacaciones]
GO
ALTER TABLE [dbo].[Vacaciones]  WITH CHECK ADD  CONSTRAINT [FK_Vacaciones_Medicos] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Medicos] ([Cedula])
GO
ALTER TABLE [dbo].[Vacaciones] CHECK CONSTRAINT [FK_Vacaciones_Medicos]
GO
ALTER TABLE [dbo].[Vacaciones]  WITH CHECK ADD  CONSTRAINT [Vacaciones_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[VacacionesEstado] ([Id])
GO
ALTER TABLE [dbo].[Vacaciones] CHECK CONSTRAINT [Vacaciones_fk]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [CHK_TipoEmpleado] CHECK  (([TipoEmpleado]='Administrativo' OR [TipoEmpleado]='Celador' OR [TipoEmpleado]='Auxiliar de Enfermería' OR [TipoEmpleado]='ATS de Zona' OR [TipoEmpleado]='ATS'))
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [CHK_TipoEmpleado]
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [CHK_TipoMedico] CHECK  (([TipoMedico]='Médico Sustituto' OR [TipoMedico]='Médico Interino' OR [TipoMedico]='Médico Titular'))
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [CHK_TipoMedico]
GO
