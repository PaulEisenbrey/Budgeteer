CREATE TABLE [Budget].[Institution](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AddressId] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Nickname] [nvarchar](100) NULL,
	[AccountNumber] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Url] [nvarchar] (MAX) NULL,
	CONSTRAINT [PK_Institution] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]

ALTER TABLE [Budget].[Institution] WITH CHECK 
ADD CONSTRAINT [FK_Institution_Address] FOREIGN KEY([AddressId])
REFERENCES [Budget].[Address]([Id])