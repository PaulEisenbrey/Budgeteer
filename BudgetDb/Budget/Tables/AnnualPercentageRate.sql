CREATE TABLE [Budget].[AnnualPercentageRate] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [APR]           DECIMAL (18, 2) NOT NULL,
    [EffectiveDate] DATETIME        NOT NULL,
    CONSTRAINT [PK_APR] PRIMARY KEY CLUSTERED ([Id] ASC)
);

