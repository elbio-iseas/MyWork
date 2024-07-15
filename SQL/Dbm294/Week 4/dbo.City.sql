CREATE TABLE [dbo].[City] (
    [CityID] INT          IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (50) NOT NULL,
    [Notes]  VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([CityID] ASC)
);

