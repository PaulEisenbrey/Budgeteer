CREATE TABLE [Budget].[InstitutionAccountsLookup] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [InstitutionId] INT NOT NULL,
    [AccountDataId] INT NOT NULL,
    CONSTRAINT [PK_InstitutionAccountsLookup] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AccountData_Lookup] FOREIGN KEY ([AccountDataId]) REFERENCES [Budget].[AccountData] ([Id]),
    CONSTRAINT [FK_Institution_Lookup] FOREIGN KEY ([InstitutionId]) REFERENCES [Budget].[Institution] ([Id])
);

