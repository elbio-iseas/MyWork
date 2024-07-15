SELECT RE.ReturnCondition, 
       RE.Notes, 
       RE.PaidDays,
       RE.VehicleID,
       RE.CustomerID,
       VE.VehicleID,
       VE.Year,
       VE.Make,
       VE.Model,
       CU.CustomerID,
       CU.FirstName,
       CU.LastName,
	   CU.InsuranceCo,
       CU.InsurancePolicy
FROM Rented AS RE
INNER JOIN Vehicle AS VE
      ON RE.VehicleID = VE.VehicleID 
INNER JOIN Customer AS CU
      ON RE.CustomerID = CU.CustomerID 
WHERE RE.ReturnCondition = 1 OR RE.ReturnCondition = 2;



