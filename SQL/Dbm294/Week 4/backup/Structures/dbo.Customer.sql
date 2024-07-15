CREATE TABLE [dbo].[Customer] (
    [CustomerID] INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Mobile]     VARCHAR (12) NULL,
    [Home]       VARCHAR (12) NULL,
    [Work]       VARCHAR (12) NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

