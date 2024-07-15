SELECT InventoryNum,
       Description,
	   DatePreviousPrice,
	   DateCurrentPrice,
	   DateEndPrice,
	   InventoryPrice
FROM dbo.PriceHistory
FOR XML PATH('PriceHistory'), Elements, ROOT('PriceHistory');
