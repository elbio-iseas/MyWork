CREATE TABLE [dbo].[Vehicle] (
    [VehicleID] INT     NOT NULL,
    [Type]      TINYINT NOT NULL,
    [Color]     TINYINT NOT NULL,
    [Doors]     TINYINT NOT NULL,
    [Capacity]  TINYINT NOT NULL,
    PRIMARY KEY CLUSTERED ([VehicleID] ASC)
);

