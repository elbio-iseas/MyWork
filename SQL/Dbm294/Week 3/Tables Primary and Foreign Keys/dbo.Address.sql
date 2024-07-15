CREATE TABLE [dbo].[Address] (
    [AddressID]  INT          IDENTITY (1, 1) NOT NULL,
    [Street]     VARCHAR (80) NOT NULL,
    [City]       INT          NOT NULL,
    [State]      TINYINT      NOT NULL,
    [ZipCode]    NCHAR (10)   NOT NULL,
    [CustomerID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_Address_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]),
    CONSTRAINT [FK_Address_City] FOREIGN KEY ([City]) REFERENCES [dbo].[City] ([CityID]),
    CONSTRAINT [FK_Address_State] FOREIGN KEY ([State]) REFERENCES [dbo].[State] ([StateID])
);

