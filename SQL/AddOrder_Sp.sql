
Create procedure AddNewOrder
( 
   @order_no int,  
   @order_date datetime,
   @item nvarchar,
   @qty int,
   @price_per_item money,	
   @customer_name nvarchar(50),
   @address_id int,
   @house_no nvarchar(50),
   @street nvarchar(50),
   @city nvarchar(30),
   @cuntry nvarchar(30),
   @postal_code nvarchar(10)
  
)  
as  
begin  
Insert into [dbo].[address] values(@address_id,@house_no,@street,@city,@cuntry,@postal_code);
   Insert into [dbo].[orders] values(@order_no,@order_date,Cast(@item as nvarchar),@qty,@price_per_item,@customer_name,(SELECT @address_id from [dbo].[address] where @address_id=address.address_id));
   
End 
GO

--EXEC AddNewOrder 
	--			   @order_no = 10001, 
		--		   @order_date= '06/30/2022',
			--	   @item= 'Dell Keyboard' ,
			--	   @qty= 1,
			--	   @price_per_item = 100,	
			--	   @customer_name = 'Kavya Roy',
			--	   @address_id = 9,
			--	   @house_no = '604',
			--	   @street = '2000 Bay Street',
			--	   @city = 'Hamilton',
			--	   @cuntry = 'L8P8C4',
			--	   @postal_code = 'Canada';
--GO

   