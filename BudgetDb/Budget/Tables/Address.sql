CREATE TABLE [Budget].[Address] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Street]     NVARCHAR (100) NULL,
    [UnitNumber] NVARCHAR (50)  NULL,
    [City]       NVARCHAR (100) NULL,
    [State]      NVARCHAR (100) NULL,
    [PostalCode] NVARCHAR (40)  NULL,
    IsActive     BIT DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([Id] ASC)
);

