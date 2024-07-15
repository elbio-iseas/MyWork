SELECT   WKD.EmployeeID AS 'Employee ID',
         WKD.Hours      AS 'Worked Hours',
         WKD.Payday     AS 'Pay Date',
         WKD.Amount     AS 'Amount Earned',
         EMP.FirstName  AS 'First Name',
         EMP.LastName   AS 'Last Name',
         EMP.SalaryID   AS 'Salary ID',
         SAL.ID         AS 'Salary ID',
         SAL.Amount     AS 'Hourly Pay',
         SAL.SalaryDate AS 'Date of Change'

FROM Worked AS WKD
INNER JOIN Employees AS EMP
ON WKD.EmployeeID = EMP.ID 
INNER JOIN Salaries AS SAL
ON EMP.SalaryID = SAL.ID