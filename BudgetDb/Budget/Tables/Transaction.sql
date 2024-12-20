CREATE TABLE [Budget].[Transaction] (
    [Id]                INT              IDENTITY (1, 1) NOT NULL,
    [TransactionId]     UNIQUEIDENTIFIER NOT NULL,
    [TransactionDate]   DATETIME         NOT NULL,
    [TransactionAmount] DECIMAL (18, 2)  NOT NULL,
    [Source]            INT              NOT NULL,
    [CheckNumber]       NVARCHAR (100)   NULL,
    [TransactionTypeId] INT              NOT NULL,
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Transaction_TransactionType] FOREIGN KEY ([TransactionTypeId]) REFERENCES [Budget].[TransactionType] ([Id])
);

