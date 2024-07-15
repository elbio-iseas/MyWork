DECLARE @x xml
DECLARE @hdoc int
SET @x = 
'
<Employees>
 <Employee>
    <EmployeeID>3</EmployeeID>
    <FirstName>Neal</FirstName>
    <LastName>Goldstone</LastName>
    <LatWork>5.086820000000000e+001</LatWork>
    <LongWork>8.342570000000001e+001</LongWork>
  </Employee>
</Employees>
'
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
 
 SELECT * FROM DimEmployees
 
 