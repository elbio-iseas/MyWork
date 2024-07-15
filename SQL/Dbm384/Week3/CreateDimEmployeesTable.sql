CREATE TABLE [dbo].[Employees] 
(
    [EmployeeID] INT          NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
	[LatWork]    FLOAT        NOT NULL,
	[LongWork]   FLOAT        NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

