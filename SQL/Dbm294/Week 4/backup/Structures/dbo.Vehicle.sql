CREATE TABLE [dbo].[Vehicle] (
    [VehicleID] INT          IDENTITY (1, 1) NOT NULL,
    [Type]      TINYINT      NOT NULL,
    [Color]     TINYINT      NOT NULL,
    [Doors]     TINYINT      NOT NULL,
    [Capacity]  TINYINT      NOT NULL,
    [Year]      SMALLINT     DEFAULT ((1980)) NULL,
    [Make]      VARCHAR (30) NULL,
    [Model]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([VehicleID] ASC),
    CONSTRAINT [FK_Vehicle_Type] FOREIGN KEY ([Type]) REFERENCES [dbo].[Type] ([TypeID])
);

