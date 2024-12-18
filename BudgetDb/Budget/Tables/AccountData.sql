CREATE TABLE [Budget].[AccountData] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [InstitutionId]  INT             NOT NULL,
    [OpenDate]       DATETIME        NOT NULL,
    [AccountTypeId]  INT             NOT NULL,
    [Name]           NVARCHAR (100)  NOT NULL,
    [Nickname]       NVARCHAR (100)  NULL,
    [AccountNumber]  NVARCHAR (100)  NULL,
    [RoutingNumber]  NVARCHAR (100)  NULL,
    [InitialBalance] DECIMAL (18, 2) NOT NULL,
    [AccountUniqueId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_AccountData] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AccountData_Institution] FOREIGN KEY ([InstitutionId]) REFERENCES [Budget].[Institution] ([Id]),
    CONSTRAINT [FK_AccountData_AccountType] FOREIGN KEY ([AccountTypeId]) REFERENCES [Budget].[AccountType] ([Id]),
    CONSTRAINT [UQ_AccountData_AccountUniqueId] UNIQUE ([AccountUniqueId])
);

