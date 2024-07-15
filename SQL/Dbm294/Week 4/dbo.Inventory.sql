CREATE TABLE [dbo].[Inventory] (
    [InventoryID]     INT          IDENTITY (1, 1) NOT NULL,
    [Vehicle]         INT          NOT NULL,
    [Vin]             VARCHAR (20) NOT NULL,
    [AdquisitionDate] DATE         NOT NULL,
    [LicensePlates]   VARCHAR (10) NOT NULL,
    [Available]       BIT          DEFAULT ((1)) NULL,
    [Notes]           VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([InventoryID] ASC),
    CONSTRAINT [FK_Inventory_Vehicle] FOREIGN KEY ([Vehicle]) REFERENCES [dbo].[Vehicle] ([VehicleID])
);

