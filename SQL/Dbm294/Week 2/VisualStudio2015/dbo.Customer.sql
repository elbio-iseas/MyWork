CREATE TABLE [dbo].[Customer] (
    [CustomerID] INT          NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Mobile]     VARCHAR (12) NULL,
    [Home]       VARCHAR (12) NULL,
    [Work]       VARCHAR (12) NULL,
    [AddressID]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC), 
    CONSTRAINT [FK_Customer_Address] FOREIGN KEY ([AddressID]) REFERENCES [Address]([AddressID])
);

