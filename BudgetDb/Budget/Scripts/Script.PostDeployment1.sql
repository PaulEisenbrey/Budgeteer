/*
Post-Deployment Script Template                            
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.        
 Use SQLCMD syntax to include a file in the post-deployment script.            
 Example:      :r .\myfile.sql                                
 Use SQLCMD syntax to reference a variable in the post-deployment script.        
 Example:      :setvar TableName MyTable                            
               SELECT * FROM [$(TableName)]                    
--------------------------------------------------------------------------------------
*/

insert into [Budget].[BudgetCategories] (Description) values
('cable'),
('carInsurance'),
('carPayment'),
('clothing'),
('creditCard'),
('dental'),
('eatingOut'),
('electricity'),
('emergencyFund'),
('entertainment'),
('gas'),
('gasoline'),
('gifts'),
('groceries'),
('gym'),
('healthInsurance'),
('homeInsurance'),
('homeownerDues'),
('internet'),
('investment'),
('lifeInsurance'),
('medical'),
('mortgage'),
('other'),
('personalLoan'),
('phone'),
('rent'),
('retirement'),
('salary'),
('savings'),
('streaming'),
('studentLoan'),
('subscriptions'),
('trash'),
('travel'),
('vacation'),
('vision'),
('water')