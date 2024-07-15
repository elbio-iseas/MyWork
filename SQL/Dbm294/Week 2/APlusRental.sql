-- **************************************
-- DBM/294 Individual Assignment Week Two 
-- **************************************

-- Next line creates a database named DBM294Iseas
CREATE DATABASE DBM294Iseas
GO

-- ***********************************************
CREATE SCHEMA XCustomers AUTHORIZATION dbo
GO
CREATE SCHEMA XAddresses AUTHORIZATION dbo
GO
CREATE SCHEMA XCities AUTHORIZATION dbo
GO
CREATE SCHEMA XStates AUTHORIZATION dbo
GO
CREATE SCHEMA XVehicles AUTHORIZATION dbo
GO
CREATE SCHEMA XInventories AUTHORIZATION dbo
GO
CREATE SCHEMA XRent AUTHORIZATION dbo
GO
CREATE SCHEMA XTypes AUTHORIZATION dbo
GO

CREATE TABLE XCustomers.XCustomer
(CustomerID     INT         IDENTITY (1,1),
FirstName       VARCHAR(50) NOT NULL,
LastName        VARCHAR(50) NOT NULL,
Mobile          VARCHAR(12) NULL,
Home            VARCHAR(12) NULL,
Work            VARCHAR(12) NULL,
AddressID       INT         NOT NULL,
CONSTRAINT pk_customerid PRIMARY KEY (CustomerID))
GO
ALTER TABLE XCustomers.XCustomer
      ADD CONSTRAINT fk_addressid FOREIGN KEY (AddressID)
      REFERENCES XAddresses.XAddress(AddressID)
GO	  
-- ***********************************************


-- *********************************************

CREATE TABLE XAddresses.XAddress
(AddressID      INT         IDENTITY (1,1),
Street          VARCHAR(80) NOT NULL,
City            INT         NOT NULL,
State           TINYINT     NOT NULL,
ZipCode         VARCHAR(10) NULL,
CONSTRAINT pk_addressid PRIMARY KEY (AddressID))
GO
ALTER TABLE XAddresses.XAddress
      ADD CONSTRAINT fk_city FOREIGN KEY (City)
      REFERENCES XCities.XCity(CityID)
GO	
ALTER TABLE XAddresses.XAddress
      ADD CONSTRAINT fk_state FOREIGN KEY (State)
      REFERENCES XStates.XState(StateID)
GO	
-- *********************************************

-- *****************************************


CREATE TABLE XCities.XCity
(CityID         INT         IDENTITY (1,1),
Name            VARCHAR(50) NOT NULL,
Notes           VARCHAR(80) NULL,
CONSTRAINT pk_cityid PRIMARY KEY (CityID))
GO
-- *****************************************


-- *****************************************


CREATE TABLE XStates.State
(StateID        TINYINT     IDENTITY (1,1),
Name            VARCHAR(50) NOT NULL,
Notes           VARCHAR(80) NULL,
Code            VARCHAR(2)  NOT NULL,
CONSTRAINT pk_stateid PRIMARY KEY (StateID))
GO
-- *****************************************

-- *********************************************


CREATE TABLE XVehicles.XVehicle
(VehicleID      INT         IDENTITY (1,1),
Type            TINYINT     NOT NULL,  
Color           TINYINT     NOT NULL,
Doors           TINYINT     NOT NULL,
Capacity        TINYINT     NOT NULL,
CONSTRAINT pk_vehicleid PRIMARY KEY (VehicleID))
GO
ALTER TABLE XVehicles.XVehicle
      ADD CONSTRAINT fk_type FOREIGN KEY (Type)
      REFERENCES XTypes.XType(TypeID)
GO

-- *********************************************

-- *****************************************

CREATE TABLE XInventories.XInventory
(InventoryID    INT         IDENTITY (1,1),
Vehicle         INT         NOT NULL, 
Vin             VARCHAR(20) NOT NULL,
AdquisitionDate DATE        NOT NULL,
LicensePlates   VARCHAR(10) NOT NULL UNIQUE,
Available       BIT         NOT NULL,
Notes           VARCHAR(80) NULL,
CONSTRAINT pk_inventoryid PRIMARY KEY (InventoryID))
GO
ALTER TABLE XInventories.XInventory
      ADD CONSTRAINT fk_vehicle FOREIGN KEY (Vehicle)
      REFERENCES XVehicles.XVehicle(VehicleID)
GO
-- *****************************************

-- *****************************************

CREATE TABLE XRent.XRented
(RentedID       INT         IDENTITY (1,1),
RentedDate      DATE        NOT NULL,
ReturnDate      DATE        NOT NULL,
ReturnCondition INT         NOT NULL,
InsuranceCo     VARCHAR(50) NOT NULL,
InsurancePolicy VARCHAR(20) NOT NULL,
VehicleID       INT         NOT NULL,
CustomerID      INT         NOT NULL,
Notes           VARCHAR(80) NULL,
CONSTRAINT pk_rentedid PRIMARY KEY (RentedID))
GO
ALTER TABLE XRent.XRented
      ADD CONSTRAINT fk_vehicle FOREIGN KEY (VehicleID)
      REFERENCES XVehicles.XVehicle(TypeID);
GO
ALTER TABLE XRent.XRented
      ADD CONSTRAINT fk_customer FOREIGN KEY (CustomerID)
      REFERENCES XCustomers.XCustomer(CustomerID)
GO
-- *****************************************

-- *****************************************

CREATE TABLE XTypes.XType
(TypeID         TINYINT     IDENTITY (1,1),
Name            VARCHAR(20) NOT NULL,
Notes           VARCHAR(80) NULL,
CONSTRAINT pk_typeid PRIMARY KEY (TypeID))
GO

-- *****************************************
