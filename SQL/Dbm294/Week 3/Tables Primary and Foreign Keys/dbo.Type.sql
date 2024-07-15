CREATE TABLE [dbo].[Type] (
    [TypeID] TINYINT      IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (20) NOT NULL,
    [Notes]  VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([TypeID] ASC)
);

