CREATE TABLE [dbo].[Contacto]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Apellido] NVARCHAR(50) NOT NULL, 
    [Edad] INT NOT NULL, 
    [Usuario] NVARCHAR(10) NOT NULL, 
    [FechaCreacion] DATETIME2 NOT NULL 
)
