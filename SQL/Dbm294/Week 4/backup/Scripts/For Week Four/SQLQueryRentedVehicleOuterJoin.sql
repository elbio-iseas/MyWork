SELECT RentedID, CustomerID, Vehicle.VehicleID, RentedDate, Vehicle.Year, Vehicle.Make, Vehicle.Model
FROM Rented
FULL JOIN Vehicle ON
Rented.VehicleID = Vehicle.VehicleID
ORDER BY Rented.VehicleID;
