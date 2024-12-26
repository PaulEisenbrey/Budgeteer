CREATE TABLE [Budget].[PostalCodes]
(
    [Id] INT NOT NULL, 
    [StateProvince] NCHAR(10) NOT NULL, 
    [City] NCHAR(100) NOT NULL, 
    [CountryCode] NCHAR(10) NOT NULL, 
    [PostalCode] NCHAR(10) NOT NULL,
    CONSTRAINT [PK_PostalCode] PRIMARY KEY CLUSTERED ([Id] ASC)
)
