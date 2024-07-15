INSERT INTO FactWorkedHours
(EmployeeID, DepartmentID, SalaryID, WorkedLocation, Hours, Amount, PayDate)
VALUES 
(3, 4, 7, geography::Point(1.00, 2.00, 4326 ), 38.50, 1.00, CONVERT(date,'09-14-2016', 110)),
(1, 6, 8, geography::Point(1.00, 2.00, 4326 ), 36.00, 1.00, CONVERT(date,'09-14-2016', 110)),
(4, 1, 2, geography::Point(1.00, 2.00, 4326 ), 40.00, 1.00, CONVERT(date,'09-14-2016', 110)),
(2, 5, 3, geography::Point(1.00, 2.00, 4326 ), 40.00, 1.00, CONVERT(date,'09-14-2016', 110));

UPDATE FactWorkedHours
SET WorkedLocation = geography::Point(EMP.LatWork,EMP.LongWork, 4326),
    Amount = Hours * SAL.SalaryAmount
FROM FactWorkedHours AS FWH
INNER JOIN dbo.DimEmployees AS EMP
ON FWH.EmployeeID = EMP.EmployeeID
INNER JOIN dbo.DimSalaries AS SAL
ON SAL.SalaryID = SAL.SalaryID
WHERE FWH.EmployeeID = 3;

UPDATE FactWorkedHours
SET WorkedLocation = geography::Point(EMP.LatWork,EMP.LongWork, 4326),
    Amount = Hours * SAL.SalaryAmount
FROM FactWorkedHours AS FWH
INNER JOIN dbo.DimEmployees AS EMP
ON FWH.EmployeeID = EMP.EmployeeID
INNER JOIN dbo.DimSalaries AS SAL
ON SAL.SalaryID = SAL.SalaryID
WHERE FWH.EmployeeID = 1;

UPDATE FactWorkedHours
SET WorkedLocation = geography::Point(EMP.LatWork,EMP.LongWork, 4326),
    Amount = Hours * SAL.SalaryAmount
FROM FactWorkedHours AS FWH
INNER JOIN dbo.DimEmployees AS EMP
ON FWH.EmployeeID = EMP.EmployeeID
INNER JOIN dbo.DimSalaries AS SAL
ON SAL.SalaryID = SAL.SalaryID
WHERE FWH.EmployeeID = 4;

UPDATE FactWorkedHours
SET WorkedLocation = geography::Point(EMP.LatWork,EMP.LongWork, 4326),
    Amount = Hours * SAL.SalaryAmount
FROM FactWorkedHours AS FWH
INNER JOIN dbo.DimEmployees AS EMP
ON FWH.EmployeeID = EMP.EmployeeID
INNER JOIN dbo.DimSalaries AS SAL
ON SAL.SalaryID = SAL.SalaryID
WHERE FWH.EmployeeID = 2;

