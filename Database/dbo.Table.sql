CREATE TABLE [dbo].[Table]
(
	[Username] VARCHAR(15) NOT NULL PRIMARY KEY, 
    [First Name] VARCHAR(30) NOT NULL, 
    [Last Name] VARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [Weight] DECIMAL(5, 2) NOT NULL, 
    [Height] DECIMAL(3, 2) NOT NULL, 
    [Resting Heart Rate] INT NOT NULL, 
    [Sleep] INT NOT NULL, 
    [BMI] DECIMAL(3, 1) NULL, 
    [Password] VARCHAR(40) NOT NULL
)
