﻿CREATE PROCEDURE store
                     
       @e_nm                  VARCHAR(max)   , 
       @e_gn					VARCHAR(max)  ,
	   @e_city                VARCHAR(max) 
AS 
BEGIN 
          INSERT INTO dbo.Emp
          (               Name                     ,           Gender,City ) 
     VALUES          (   @e_nm     ,      @e_gn,  @e_city  )
		  End