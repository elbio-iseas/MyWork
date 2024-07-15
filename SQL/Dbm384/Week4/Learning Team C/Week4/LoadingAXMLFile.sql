DECLARE @x xml
SELECT @x = E
FROM OPENROWSET(BULK 'U:DBM384\DimEmployees.XML', SINGLE_BLOB) AS DimEmployees(E)
DECLARE @hdoc int
EXEC sp_xml_preparedocument @hdoc OUTPUT, @x
SELECT * 
FROM OPENXML(@hdoc, '/Employees/Employee',2)
WITH 
(
   EmployeeID int,
   FirstName varchar(50),
   LastName varchar(50),
   LatWork float,
   LongWork float
)

SET @x.modify('replace value of /Employees[1]/Employee[1]/LastName[1]/text()[1] with "Smith" ')

