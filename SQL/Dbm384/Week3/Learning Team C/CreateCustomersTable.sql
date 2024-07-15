CREATE TABLE [dbo].[Customers] 
(
    [CustomerID]        INT              NOT NULL,
    [CustomerFirstName] VARCHAR (30)     NOT NULL,
    [CustomerLastName]  VARCHAR (30)     NOT NULL,
    [CustomerAddress]   VARCHAR (50)     NOT NULL,
    [CustomerLat]       [sys].[geometry] NOT NULL,
    [CustomerLong]      [sys].[geometry] NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

