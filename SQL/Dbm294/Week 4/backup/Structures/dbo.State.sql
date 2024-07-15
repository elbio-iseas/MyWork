CREATE TABLE [dbo].[State] (
    [StateID] TINYINT      IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (50) NOT NULL,
    [Notes]   VARCHAR (80) NULL,
    [Code]    VARCHAR (2)  NOT NULL,
    PRIMARY KEY CLUSTERED ([StateID] ASC)
);

