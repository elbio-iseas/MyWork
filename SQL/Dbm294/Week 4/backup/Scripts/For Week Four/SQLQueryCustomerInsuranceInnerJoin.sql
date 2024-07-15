SELECT CU.CustomerID,
       CU.FirstName,
	   CU.LastName,
	   IC.Name,
	   CU.InsurancePolicy
FROM Customer AS CU
INNER JOIN Insurance AS IC
        ON CU.InsuranceCo = IC.InsuranceCoID;


