CREATE TABLE [Budget].[AccountAPRLookup] (
    [Id]                     INT IDENTITY (1, 1) NOT NULL,
    [AccountDataId]          INT NOT NULL,
    [AnnualPercentageRateId] INT NOT NULL,
    CONSTRAINT [PK_AccountAPRLookup] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AccountAPRLookup_AccountData] FOREIGN KEY ([AccountDataId]) REFERENCES [Budget].[AccountData] ([Id]),
    CONSTRAINT [FK_AccountAPRLookup_AnnualPercentageRate] FOREIGN KEY ([AnnualPercentageRateId]) REFERENCES [Budget].[AnnualPercentageRate] ([Id])
);

