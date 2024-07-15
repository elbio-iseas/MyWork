CREATE TABLE [dbo].[Stores] 
(
    [StoreID]      INT              NOT NULL,
    [StoreName]    VARCHAR (50)     NOT NULL,
    [StoreAddress] VARCHAR (50)     NOT NULL,
    [StoreLat]     [sys].[geometry] NOT NULL,
    [StoredLong]   [sys].[geometry] NOT NULL,
    PRIMARY KEY CLUSTERED ([StoreID] ASC)
);

