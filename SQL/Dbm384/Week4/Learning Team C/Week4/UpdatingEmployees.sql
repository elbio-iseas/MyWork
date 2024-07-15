UPDATE DimEmployees 
SET
[EmployeeID]=x.EmployeeID,
[FirstName]=x.FirstName,
[LastName]=x.LastName,
[LatWork]=x.LatWork,
[LongWork]=x.LongWork
FROM
OPENXML(@hdoc, 'Employees/Employee',2)
WITH
([EmployeeID] INT,
 [FirstName] VARCHAR(50),
 [LastName] VARCHAR(50),
 [LatWork] FLOAT,
 [LongWork] FLOAT
 )
 AS x
 