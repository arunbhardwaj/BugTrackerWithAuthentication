CREATE TABLE [dbo].[tblIssues]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] NVARCHAR(50) NULL, 
    [CreatedBy] NVARCHAR(256) NULL, 
    [IssueType] NVARCHAR(50) NULL, 
    [Summary] NVARCHAR(MAX) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Priority] NVARCHAR(10) NULL
)
