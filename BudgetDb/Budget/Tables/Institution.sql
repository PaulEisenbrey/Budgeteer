CREATE TABLE [Budget].[Institution] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [AddressId]     INT            NULL,
    [Name]          NVARCHAR (100) NULL,
    [Nickname]      NVARCHAR (100) NULL,
    [AccountNumber] NVARCHAR (100) NULL,
    [PhoneNumber]   NVARCHAR (20)  NULL,
    [Url]           NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Institution] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Institution_Address] FOREIGN KEY ([AddressId]) REFERENCES [Budget].[Address] ([Id])
);

