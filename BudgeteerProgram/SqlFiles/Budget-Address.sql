CREATE TABLE [Budget].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nvarchar](100) NULL,
	[UnitNumber] [nvarchar](50) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[PostalCode] [nvarchar](40) NULL,
	[Country] [nvarchar](10) NULL,
	CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]