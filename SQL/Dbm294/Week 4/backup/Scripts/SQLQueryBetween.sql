SELECT INV.LicensePlates, 
       INV.AdquisitionDate,
	   VE.Year,
	   VE.Make,
	   VE.Model
FROM [dbo].[Inventory] AS INV
INNER JOIN [dbo].[Vehicle] AS VE
      ON INV.Vehicle = VE.VehicleID
WHERE INV.AdquisitionDate BETWEEN '2015-09-30' AND '2015-12-31';