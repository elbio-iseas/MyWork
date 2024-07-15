CREATE PROCEDURE dbo.SaveDimEmployeesXML @XML XML
AS
INSERT dbo.DimEmployees (EmployeeID, FirstName, LastName, LatWork, LongWork)
SELECT EmployeeID = @XML.value('Employees[1]/EmployeeID[1]','INT'),
       FirstName = DimEmployees.value('Employees[1]/FirstName[1]','VARCHAR(50)'),
       LastName = DimEmployees.value('Employees[1]/LastName[1]', 'VARCHAR(50)'),
       LatWork = DimEmployees.value('Employees[1])/LatWork[1]', 'FLOAT'),
       LongWork = DimEmployees.value('Employees[1])/LongWork[1]','FLOAT')
FROM @XML.nodes('Employees/Employee') e (DimEmployees)
GO
