CREATE TABLE [dbo].[Type] (
    [TypeID] TINYINT      NOT NULL,
    [Name]   VARCHAR (20) NOT NULL,
    [Notes]  VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([TypeID] ASC)
);

