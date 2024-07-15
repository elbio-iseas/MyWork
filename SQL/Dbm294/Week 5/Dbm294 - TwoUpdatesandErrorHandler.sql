CREATE PROCEDURE VehicleChangeModelandID

@VehID1 INT,
@VehName1 VARCHAR(50),
@Capacity1 TINYINT,
@VehID2 INT,
@VehName2 VARCHAR(50),
@Capacity2 TINYINT

AS 

BEGIN TRY

       BEGIN TRAN

       UPDATE [dbo].[Vehicle]
       SET Model = @VehName1,
           Capacity = @Capacity1
       WHERE VehicleID = @VehID1

       UPDATE [dbo].[Vehicle]
       SET Model = @VehName2,
           Capacity = @Capacity2
       WHERE VehicleID = @VehID2

       COMMIT TRANSACTION

END TRY

BEGIN CATCH
      SELECT ERROR_MESSAGE() messerr
      PRINT 'Update did not finish successfully. '
      ROLLBACK TRANSACTION

END CATCH
 
GO

EXEC VehicleChangeModelandID 4, 'Maxima', 6, 8, 'Landcruiser', NULL

GO


