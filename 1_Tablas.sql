CREATE TABLE [dbo].[Ciudades](
	[idCuidad] [int]  NOT NULL,
    [idPais]   [int]  NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
     CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[idCuidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]


GO

CREATE TABLE [dbo].[Pais](
	[idPais]   [int]  NOT NULL,
	[Nombre] [varchar](100) NOT NULL,

     CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ClimasHistorico](
    [id] [int]  NOT NULL,
    [idCuidad] [int]  NOT NULL,
    [idPais]   [int]  NOT NULL,
	[Clima] [varchar](100) NOT NULL,
    [SenacionTerminca] [varchar](100) NOT NULL,
    [FechaAlta] [varchar](100) NOT NULL,

 CONSTRAINT [PK_ClimasHistorico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE   TABLE [dbo].[TdbErroresEcheq](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Error] [varchar](10) NOT NULL,
	[descripcion] [varchar](250) NULL,
	[observacion] [varchar](250) NULL,
	[fecha] [datetime] NULL,
	[cue_cta] [char](10) NULL,
	[cue_div] [char](1)  NULL,
	[cue_sec] [char](2)  NULL,
	[cue_suc] [char](2)  NULL,
	[cue_mon] [char](2)  NULL,
	[idchequera] [int] NUll,
	[idchequera_item] [int] NUll,
	[procesado]  [bit] NULL, 
	[fecha_procesado]  [datetime] NULL,

 CONSTRAINT [PK_TdbErrores_Echeq] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

