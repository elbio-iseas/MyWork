SELECT INV.Available AS Rented, 
       INV.LicensePlates, 
	   VE.Year, 
	   VE.Make,
	   VE.Model
FROM [dbo].[Inventory] AS INV
INNER JOIN [dbo].[Vehicle] AS VE
      ON INV.Vehicle = VE.VehicleID
WHERE INV.Available = 0;
