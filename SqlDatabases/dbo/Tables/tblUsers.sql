CREATE TABLE [dbo].[tblUsers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(100) NULL, 
    [Username] NVARCHAR(100) NULL
)
