CREATE TABLE [dbo].[DimDepartments] 
(
    [DepartmentID]    INT          NOT NULL,
    [DepartmentName]  VARCHAR (50) NOT NULL,
    [DepartmentNotes] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);

