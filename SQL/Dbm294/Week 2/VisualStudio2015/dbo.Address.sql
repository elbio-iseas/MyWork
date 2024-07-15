CREATE TABLE [dbo].[Address] (
    [AddressID] INT          NOT NULL,
    [Street]    VARCHAR (80) NOT NULL,
    [City]      INT          NOT NULL,
    [State]     TINYINT      NOT NULL,
    [ZipCode]   NCHAR (10)   NOT NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC), 
    CONSTRAINT [FK_Address_City] FOREIGN KEY ([City]) REFERENCES [City]([CityID]), 
    CONSTRAINT [FK_Address_State] FOREIGN KEY ([State]) REFERENCES [State]([StateID])
);

