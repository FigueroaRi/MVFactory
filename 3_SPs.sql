CREATE PROCEDURE UsersGetByUserAndPassword
(
    @UserName varchar(50),
    @Password varchar(50)
)
AS
BEGIN
    SELECT UserId, FirstName, LastName, UserName,  [Password]
    FROM Users
    WHERE UserName = @UserName and Password = @Password
END

GO


CREATE PROCEDURE CiudadesGetAll
(
    @Nombre varchar(50)=NULL,
    @Codigo INT=NULL,
    @Id  INT=NULL
)
AS
BEGIN
   SELECT  [id]
      ,[Codigo]
      ,[idPais]
      ,[Nombre]
  FROM [dbo].[Ciudades]
  WHERE  ([id]= @Id OR  @Id IS NULL)
       AND ([Codigo] =   @Codigo OR    @Codigo IS NULL)
        AND ([Nombre]= @Nombre OR  @Nombre IS NULL)
END
GO


CREATE PROCEDURE ClimasHistoricoInsert
(
   @idCiudad INT,
   @IdPais INT,
   @Clima as Char(100),
   @SensacionTermica as char(100),
   @FechaAlta as DATETIME
)
AS
BEGIN
   INSERT INTO [dbo].[ClimasHistorico]([idCuidad],[idPais],Clima,SenacionTerminca,FechaAlta )
VALUES (@idCiudad, @IdPais ,@Clima,@SensacionTermica,@FechaAlta)
END
GO


CREATE PROCEDURE ClimasHistoricoGetByCiudad
(
   @idCiudad INT=NULL,
   @IdPais INT=NULL,
   @FechaAlta as DATETIME=NULL
)
AS
 select  C.id IdCiudad, C.Nombre NombreCiudad, P.idPais, P.Nombre NombrePais, CH.Clima,CH.SenacionTerminca,CH.FechaAlta from  
  [dbo].[ClimasHistorico] ch
  INNER JOIN [dbo].[Ciudades] C ON (ch.idCuidad=c.id)
  INNER JOIN [dbo].[Pais] P ON (P.idPais=C.idPais)

WHERE ([idCuidad] = @idCiudad OR  @idCiudad IS NULL)
AND  (p.[idPais]=   @IdPais OR    @IdPais IS NULL)
AND ([FechaAlta]=@FechaAlta OR @FechaAlta IS NULL)

GO