CREATE TABLE [dbo].[Customer] (
    [CustomerID] INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Mobile]     VARCHAR (12) NULL,
    [Home]       VARCHAR (12) NULL,
    [Work]       VARCHAR (12) NULL,
    [InsuranceCo] SMALLINT NOT NULL DEFAULT 0, 
    [InsurancePolicy] VARCHAR(15) NULL, 
    PRIMARY KEY CLUSTERED ([CustomerID] ASC), 
    CONSTRAINT [FK_Customer_Insurance] FOREIGN KEY ([InsuranceCo]) REFERENCES [Insurance]([InsuranceCoID])
);

