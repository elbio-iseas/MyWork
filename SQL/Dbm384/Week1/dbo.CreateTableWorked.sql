CREATE TABLE [dbo].[Worked] (
    [EmployeeID] INT            NOT NULL,
    [Hours]      DECIMAL (5, 2) NOT NULL,
    [Payday]     DATE           NOT NULL,
    [Amount]     DECIMAL (8, 2) NOT NULL,
    CONSTRAINT [PK_Worked] PRIMARY KEY CLUSTERED ([EmployeeID] ASC, [Payday] ASC),
    CONSTRAINT [FK_Worked_ToEmployees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([ID])
);

