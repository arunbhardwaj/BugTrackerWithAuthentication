CREATE TABLE [dbo].[linkProjectsIssues]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProjectName] NVARCHAR(50) NULL, 
    [IssueName] NCHAR(10) NULL
)
