CREATE PROCEDURE storedata
                        
       @pname     NVARCHAR(Max), 
       @pprice    float,
	   @pqty		int                
AS 
BEGIN 
  INSERT INTO dbo.Product( Name ,Qty,Price)    VALUES (  @pname  ,  @pqty , @pprice     )
 End