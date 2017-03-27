CREATE TABLE [dbo].[Usuario]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(10) NOT NULL, 
    [Password] NVARCHAR(40) NOT NULL, 
    [FechaCreacion] DATETIME2 NOT NULL, 
    [Activo] NCHAR(1) NOT NULL
)
