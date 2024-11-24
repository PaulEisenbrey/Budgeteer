create table Budget.AccountType
(
	Id int IDENTITY(1,1) NOT NULL,
	[Description] nvarchar(100) null,
	CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]

GO

insert into Budget.AccountType ([Description]) values
	('bucket'), ('checking'), ('savings'), ('credit'), ('securedLoan'), ('unsecuredLoan')
