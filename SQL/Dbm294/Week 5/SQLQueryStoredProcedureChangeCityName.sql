﻿CREATE PROCEDURE dbo.changeCityName
@curcity varchar(50),
@newcity varchar(50)
AS
UPDATE [dbo].[City]
SET Name = @newcity
WHERE Name = @curcity
GO
EXEC dbo.changeCityName 'Salt Lake City', 'Taylorsville';
GO