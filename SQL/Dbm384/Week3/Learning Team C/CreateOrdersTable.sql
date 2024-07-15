CREATE TABLE [dbo].[Orders] 
(
    [OrderNum]      INT          NOT NULL,
    [CustomerID]    INT          NOT NULL,
    [InventoryNum]  INT          NOT NULL,
    [OrderStore]    INT          NOT NULL,
    [OrderQty]      INT          NOT NULL,
    [OrderAmount]   MONEY        NOT NULL,
    [OrderDate]     DATE         NOT NULL,
    [OrderDistance] DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderNum] ASC, [CustomerID] ASC, [InventoryNum] ASC, [OrderStore] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID]),
    CONSTRAINT [FK_Orders_Stores] FOREIGN KEY ([OrderStore]) REFERENCES [dbo].[Stores] ([StoreID]),
    CONSTRAINT [FK_Orders_PriceHistory] FOREIGN KEY ([InventoryNum]) REFERENCES [dbo].[PriceHistory] ([InventoryNum])
);

