CREATE TABLE [dbo].[Employees]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [SalaryID] INT NOT NULL, 
    CONSTRAINT [FK_Employees_Salaries] FOREIGN KEY ([SalaryID]) REFERENCES [Salaries]([ID])
)
