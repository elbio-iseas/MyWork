USE OpenXMLMigration
GO

DECLARE @xml AS XML, @hDoc AS int, @SQL nvarchar(MAX)
SELECT @xml = XMLDATA FROM XMLwithOPENXML

EXEC sp_xml_preparedocument @hDoc OUTPUT, @xml

SELECT CustomerID, CustomerName, Address
FROM OPENXML(@hDoc, 'ROOT/Customers/Curstomer')
WITH
(
CustomerID [varchar](50) '@CustomerID',
CustomerName [varchar](100) '@CustomerName',
Address [varchar](100) '@Address'
)

EXEC sp_xml_removedocument @hDoc

