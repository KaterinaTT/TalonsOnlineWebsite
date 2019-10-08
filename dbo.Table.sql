CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Фамилия] NVARCHAR(50) NULL, 
    [Имя] NVARCHAR(MAX) NULL, 
    [Отчество] NVARCHAR(MAX) NULL
)
