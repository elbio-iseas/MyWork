CREATE TABLE [dbo].[Insurance] (
    [InsuranceCoID] SMALLINT      IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR(50) NULL,
    [WorkPhone]     VARCHAR(12)  NULL,
    [WorkFax]       VARCHAR(12) NULL,
    [Notes]         VARCHAR(80) NULL,
    CONSTRAINT [PK_Insurance] PRIMARY KEY CLUSTERED ([InsuranceCoID] ASC)
);

