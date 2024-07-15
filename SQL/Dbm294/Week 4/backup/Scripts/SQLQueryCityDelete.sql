SET IDENTITY_INSERT [dbo].[City] ON
INSERT INTO [dbo].[City] ( [CityID], [Name], [Notes] ) VALUES (8, 'Pescadero', 'Row target for deletion.')
SELECT * FROM [dbo].[City] WHERE CityID = 8
DELETE FROM [dbo].[City] WHERE Name = 'Pescadero'
SELECT * FROM [dbo].[City]


