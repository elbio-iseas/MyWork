CREATE TABLE [dbo].[Rented] (
    [RentedID]        INT          NOT NULL,
    [RentedDate]      DATE         NOT NULL,
    [ReturnDate]      DATE         NULL,
    [ReturnCondition] INT          NOT NULL,
    [InsuranceCo]     VARCHAR (50) NOT NULL,
    [InsurancePolicy] VARCHAR (20) NOT NULL,
    [VehicleID]       INT          NOT NULL,
    [CustomerID]      INT          NOT NULL,
    [Notes]           VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([RentedID] ASC)
);

