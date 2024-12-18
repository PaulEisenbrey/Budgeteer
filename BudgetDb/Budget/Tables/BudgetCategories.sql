CREATE TABLE [Budget].[BudgetCategories]
(
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR(100) NOT NULL,
    CONSTRAINT [PK_BudgetCategoriesR] PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO