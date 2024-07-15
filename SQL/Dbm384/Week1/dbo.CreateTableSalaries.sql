CREATE TABLE [dbo].[Salaries]
(
    [ID] INT NOT NULL, 
    [Amount] DECIMAL(3, 2) NOT NULL, 
    [SalaryDate] DATE NOT NULL, 
    CONSTRAINT [PK_Salaries] PRIMARY KEY ([ID])
)
