SELECT EmployeeID,
       FirstName,
	   LastName,
	   LatWork,
	   LongWork
FROM dbo.DimEmployees
FOR XML PATH('Employee'), Elements, ROOT('Employees');
