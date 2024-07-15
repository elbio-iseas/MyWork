USE OpenXMLMigration
GO

DECLARE @XML AS XML, @hDoc AS INT, @SQL NVARCHAR (MAX)

SELECT @XML = XMLDATA FROM XMLwithOpenXML

EXCEC sp_xml_preparedocument @hDoc OUTPUT, @XML

SELECT CustomerID, CustomerName, Address, OrderID, OrderDate, ProductID, Quantity
FROM OPENXML(@hDoc, 'ROOT/Customers/Customer/Orders/Order/OrderDetail')
WITH
(
CustomerID [varchar] (50) '../../../@CustomerID',
CustomerName [varchar] (100) '../../../@CustomerName',
Address [varchar] (100) '../../../@Address',
OrderID [varchar] (1000) '../@OrderID',
OrderDate [datetime] '../@OrderDate',
ProductID [varchar] (50) '@ProductID',
Quantity int '@Quantity'
)

EXEC sp_xml_removedocument @hDoc
GO
