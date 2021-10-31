CREATE TABLE [dbo].[Ciudades](
    [id] [int] IDENTITY PRIMARY KEY,
    [Codigo] [int]  NOT NULL,
    [idPais]   [int]  NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
    CONSTRAINT fk_grupo FOREIGN KEY (idPais)
        REFERENCES [dbo].[Pais] (idPais)
   

)


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
    [id] [int]  IDENTITY(1,1) NOT NULL,
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


CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
    [LastName] [varchar](50) NOT NULL,
    [UserName] [varchar](50) NOT NULL,
    [Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [PK_Users] PRIMARY KEY NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

