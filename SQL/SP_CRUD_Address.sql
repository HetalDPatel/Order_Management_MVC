--STORED PROCEDURES FOR ADDRESS TABLE--
USE MVC
GO

--INSERT
DROP PROCEDURE IF EXISTS dbo.SP_AddNewAddress
GO
CREATE PROCEDURE SP_AddNewAddress
(  
   @house_no nvarchar(50),
   @street nvarchar(50),
   @city nvarchar(30),
   @cuntry nvarchar(30),
   @postal_code nvarchar(10)
)  
as  
begin  
   Insert into [dbo].[address] values(@house_no,@street,@city,@cuntry,@postal_code);
End 
GO

EXEC SP_AddNewAddress @house_no = '2010',
				   @street = '200 Bay Street',
				   @city = 'Hamilton',
				   @cuntry = 'Canada',
				   @postal_code = 'L8P8C4';
GO