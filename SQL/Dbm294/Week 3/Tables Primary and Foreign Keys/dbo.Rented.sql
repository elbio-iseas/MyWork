CREATE TABLE [dbo].[Rented] (
    [RentedID]        INT          IDENTITY (1, 1) NOT NULL,
    [RentedDate]      DATE         NOT NULL,
    [ReturnDate]      DATE         NULL,
    [ReturnCondition] INT          NOT NULL,
    [InsuranceCo]     VARCHAR (50) NOT NULL,
    [InsurancePolicy] VARCHAR (20) NOT NULL,
    [VehicleID]       INT          NOT NULL,
    [CustomerID]      INT          NOT NULL,
    [Notes]           VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([RentedID] ASC),
    CONSTRAINT [FK_Rented_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]),
    CONSTRAINT [FK_Rented_Vehicle] FOREIGN KEY ([VehicleID]) REFERENCES [dbo].[Vehicle] ([VehicleID])
);

