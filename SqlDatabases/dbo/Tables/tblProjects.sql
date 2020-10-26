CREATE TABLE [dbo].[tblProjects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Key] NCHAR(3) NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Category] NVARCHAR(50) NULL, 
    [URL] NVARCHAR(MAX) NULL, 
    [ProjectLead] NVARCHAR(MAX) NULL
)
