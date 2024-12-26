@echo off
@echo This cmd file creates a Data API Builder configuration based on the chosen database objects.
@echo To run the cmd, create an .env file with the following contents:
@echo dab-connection-string=your connection string
@echo ** Make sure to exclude the .env file from source control **
@echo **
dotnet tool install -g Microsoft.DataApiBuilder
dab init -c dab-config.json --database-type mssql --connection-string "@env('dab-connection-string')" --host-mode Development
@echo Adding tables
dab add "AccountDatum" --source "[Budget].[AccountData]" --fields.include "Id,InstitutionId,OpenDate,AccountTypeId,Name,Nickname,AccountNumber,RoutingNumber,InitialBalance,AccountUniqueId" --permissions "anonymous:*" 
dab add "AccountType" --source "[Budget].[AccountType]" --fields.include "Id,Description" --permissions "anonymous:*" 
dab add "Address" --source "[Budget].[Address]" --fields.include "Id,Street,UnitNumber,City,State,PostalCode,Country" --permissions "anonymous:*" 
dab add "AnnualPercentageRate" --source "[Budget].[AnnualPercentageRate]" --fields.include "Id,AccountDatumId,APR,EffectiveDate" --permissions "anonymous:*" 
dab add "BudgetCategory" --source "[Budget].[BudgetCategories]" --fields.include "Id,Description" --permissions "anonymous:*" 
dab add "Institution" --source "[Budget].[Institution]" --fields.include "Id,AddressId,Name,Nickname,AccountNumber,PhoneNumber,Url" --permissions "anonymous:*" 
dab add "Transaction" --source "[Budget].[Transaction]" --fields.include "Id,TransactionId,AccountDatumId,TransactionDate,TransactionAmount,SourceId,Description,CheckNumber,TransactionTypeId,BudgetCategoryId,IsDeposit" --permissions "anonymous:*" 
dab add "TransactionType" --source "[Budget].[TransactionType]" --fields.include "Id,Description" --permissions "anonymous:*" 
@echo Adding views and tables without primary key
@echo Adding relationships
dab update AccountDatum --relationship AccountType --target.entity AccountType --cardinality one
dab update AccountType --relationship AccountDatum --target.entity AccountDatum --cardinality many
dab update AccountDatum --relationship Institution --target.entity Institution --cardinality one
dab update Institution --relationship AccountDatum --target.entity AccountDatum --cardinality many
dab update AnnualPercentageRate --relationship AccountDatum --target.entity AccountDatum --cardinality one
dab update AccountDatum --relationship AnnualPercentageRate --target.entity AnnualPercentageRate --cardinality many
dab update Institution --relationship Address --target.entity Address --cardinality one
dab update Address --relationship Institution --target.entity Institution --cardinality many
dab update Transaction --relationship AccountDatum --target.entity AccountDatum --cardinality one
dab update AccountDatum --relationship Transaction --target.entity Transaction --cardinality many
dab update Transaction --relationship TransactionType --target.entity TransactionType --cardinality one
dab update TransactionType --relationship Transaction --target.entity Transaction --cardinality many
@echo Adding stored procedures
@echo **
@echo ** run 'dab validate' to validate your configuration **
@echo ** run 'dab start' to start the development API host **
