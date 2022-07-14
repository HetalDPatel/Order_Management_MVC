--STORED PROCEDURES FOR ORDER TABLE--
USE MVC
GO

--INSERT
DROP PROCEDURE IF EXISTS dbo.SP_AddNewOrder
GO
CREATE PROCEDURE SP_AddNewOrder
(  
   @order_no int,  
   @order_date datetime,
   @item nvarchar(50),
   @qty int,
   @price_per_item money,	
   @customer_name nvarchar(50),
   @address_id int
)  
as  
begin  
   Insert into [dbo].[orders] values(@order_no,@order_date,@item,@qty,@price_per_item,@customer_name,@address_id);
End 
GO

EXEC SP_AddNewOrder @order_no = 10001, 
				   @order_date= '06/30/2022',
				   @item= 'Dell Keyboard',
				   @qty= 1,
				   @price_per_item = 100,	
				   @customer_name = 'Kavya Roy',
				   @address_id = 2;
GO
