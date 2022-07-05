USE [master]
GO
-- drop database
Drop database MVC
GO
-- create the database
CREATE DATABASE MVC
GO

--switch to MVC
Use MVC
GO

-- Create Table for orders
Create table orders
	(order_id int IDENTITY(1,1) PRIMARY KEY nonClustered,
	order_no int not null,
	order_date datetime not null,	
	item nvarchar(50)not null,
	qty int not null,
	price_per_item money not null,	
	customer_name nvarchar(50) not null,
	address_id int not null)
	Go
-- Insert Data into orders
Insert into orders values(10000,'06/29/2022','Dell intel Core i7 laptop',2,2008.97,'James Arthur',1);
Insert into orders values(20000,'06/29/2022','Dell intel Core i7 laptop',2,2008.97,'Hetal Patel',1);
Insert into orders values(30000,'06/29/2022','Dell intel Core i7 laptop',2,2008.97,'Dana Wie',1);
Insert into orders values(40000,'06/29/2022','Dell intel Core i7 laptop',2,2008.97,'Stephen park',1);
--select

select * from orders;

Create table address
(
	address_id int primary key nonClustered,
	house_no nvarchar(50),
	street nvarchar(50),
	city nvarchar(30),
	country nvarchar(30),
	postal_code nvarchar(10)
)
Go

Insert into address values(1,'504','2000 Bay street','Hamilton','Canada','L8P8C4');

select * from address;



