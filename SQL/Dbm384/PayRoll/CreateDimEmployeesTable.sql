CREATE TABLE [dbo].[DimEmployees] 
(
    [EmployeeID] INT          NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

