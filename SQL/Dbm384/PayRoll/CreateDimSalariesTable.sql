CREATE TABLE [dbo].[DimSalaries] 
(
    [SalaryID]           INT             NOT NULL,
    [SalaryAmount]       DECIMAL (10, 2) NOT NULL,
    [SalaryPreviousDate] DATE            NULL,
    [SalaryCurrentDate]  DATE            NOT NULL,
    [SalaryEndDate]      DATE            NULL,
    PRIMARY KEY CLUSTERED ([SalaryID] ASC)
);

