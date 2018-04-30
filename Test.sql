select netcaitlin
go

Create database Test
go

Create table Customers 
(ID int,
firstName nvarchar(255),
lastName nvarchar(255),
cardNumber int)

Create table Products 
(ID int,
productName nvarchar(255),
price float)

Create table Orders 
(ID int,
CustomerID int,
ProductID int,
)

insert into dbo.Products (productName)
values ('IPhone');

insert into 

alter table dbo.Customers
add PhoneId int;


update dbo.Customers
where CustomerID = Id

Alter table dbo.Products
drop IPhone; float;
 float = 200;

 select dbo.Products from
