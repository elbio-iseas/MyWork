CREATE TABLE [dbo].[PriceHistory] (
    [InventoryNum]      INT          NOT NULL,
    [Description]       VARCHAR (50) NOT NULL,
    [DatePreviousPrice] DATE         NULL,
    [DateCurrentPrice]  DATE         NOT NULL,
    [DateEndPrice]      DATE         NULL,
    [InventoryPrice]    DECIMAL (10,2) NOT NULL,
    PRIMARY KEY CLUSTERED ([InventoryNum] ASC, [DateCurrentPrice] ASC)
);