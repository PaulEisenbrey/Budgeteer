CREATE TABLE [Budget].[Transaction] (
    [Id]                INT              IDENTITY (1, 1) NOT NULL,
    [TransactionId]     UNIQUEIDENTIFIER NOT NULL,
    [AccountDatumId]    INT              NOT NULL,
    [BudgetCategoryId]  INT              NOT NULL DEFAULT 0,
    [TransactionDate]   DATETIME         NOT NULL,
    [TransactionAmount] DECIMAL (18, 2)  NOT NULL,
    [SourceId]          INT              NOT NULL,
    [Description]       NVARCHAR (MAX)   NULL,
    [CheckNumber]       NVARCHAR (100)   NULL,
    [TransactionTypeId] INT              NOT NULL,
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Transaction_AccountDatum] FOREIGN KEY ([AccountDatumId]) REFERENCES [Budget].[AccountData] ([Id]),
    CONSTRAINT [FK_Transaction_TransactionType] FOREIGN KEY ([TransactionTypeId]) REFERENCES [Budget].[TransactionType]([Id]),
    CONSTRAINT [UQ_Transaction_TransactionId] unique ([TransactionId])
);