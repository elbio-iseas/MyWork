CREATE TABLE [dbo].[FactWorkedHours] 
(
    [EmployeeID]   INT             NOT NULL,
    [DepartmentID] INT             NOT NULL,
    [SalaryID]     INT             NOT NULL,
    [Hours]        DECIMAL (5, 2)  NOT NULL,
    [Amount]       DECIMAL (10, 2) NOT NULL,
    [PayDate]      DATE            NOT NULL,
    CONSTRAINT [PK_FactWorkedHours] PRIMARY KEY CLUSTERED ([EmployeeID] ASC, [DepartmentID] ASC, [SalaryID] ASC),
    CONSTRAINT [FK_FactWorkedHours_DimDepartments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[DimDepartments] ([DepartmentID]),
    CONSTRAINT [FK_FactWorkedHours_DimEmployees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[DimEmployees] ([EmployeeID]),
    CONSTRAINT [FK_FactWorkedHours_DimSalaries] FOREIGN KEY ([SalaryID]) REFERENCES [dbo].[DimSalaries] ([SalaryID])
);

