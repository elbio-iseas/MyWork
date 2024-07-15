SELECT DISTINCT LicensePlates, Vin, InventoryID, Available
FROM [dbo].[Inventory]
WHERE Available = 1

