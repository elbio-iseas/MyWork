CREATE TABLE [dbo].[Inventory] (
    [InventoryID]     INT          NOT NULL,
    [Vehicle]         INT          NOT NULL,
    [Vin]             VARCHAR (20) NOT NULL,
    [AdquisitionDate] DATE         NOT NULL,
    [LicensePlates]   VARCHAR (10) NOT NULL,
    [Available]       BIT          NOT NULL,
    [Notes]           VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([InventoryID] ASC)
);

