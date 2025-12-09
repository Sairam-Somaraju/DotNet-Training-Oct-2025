
--FUNCTIONS

--1. create a function to find the greatest of three numbers
Create Function GreatestOfThree(@a int,@b int,@c int)
Returns int
As
begin
 declare @max int;
 set @max= Case
             when @a>=@b AND @a>=@c then @a
             when @b>=@a AND @b>=@c then @b
             Else @c
             end
             return @max
  end;

  select dbo.GreatestOfThree(55,25,37) As Greatest;

 --2. create a function to calculate to discount of 10% on price on all the products 

 alter function ToCalculateDiscount(@price Decimal(10,2))
 returns decimal(10,2)
 as
 begin
   Declare @discount decimal(10,2);
   Set @discount= @price - (@price * 10/100);
   return @discount
   end
   select order_id,order_date,product_name,price, dbo.ToCalculateDiscount(price) as DiscountPrice from Orders2;

   --3. create a function to calculate the discount on price as following 
  --if productname = 'books' then 10% 
  --if productname = toys then 15% 
  --else 
  --no discount 

 alter FUNCTION Tocalculatediscount(@pname VARCHAR(20),@price INT)
RETURNS INT
AS
BEGIN
    DECLARE @discount INT;
    IF (@pname = 'Keyboard')
    BEGIN
        SET @discount = @price - (@price * 10 / 100);
    END
    ELSE IF (@pname = 'Headphones')
    BEGIN
        SET @discount = @price - (@price * 15 / 100);
    END
    ELSE
    BEGIN
        SET @discount = @price;  
    END
    RETURN @discount;  
END;
SELECT * ,dbo.Tocalculatediscount(product_name, price) AS DiscountedPrice from Orders2
 
 
 --4 create inline function which accepts number and prints last n years of orders made from  now. (pass n as a parameter)
 Create function  GetLastNYearsOrders( @n int)
 returns table
 AS
 Return(
   select * from Orders2 where order_date>=DATEADD(year, -@n, Getdate())
 )
 select * from dbo.GetLastNYearsOrders(2);

 ==================================================================================================================================
 --TRIGGERS
--1. Create a trigger for table customer, which does not allow the user to delete the record who stays in Bangalore, Chennai, delhi
Alter Trigger  deleterecord
On Customer2
For Delete
As
 Begin
   If Exists( select * from deleted where cAddress in ('Bangalore', 'Chennai', 'Delhi'))
 Begin 
 print 'You cannot delete customers from Bangalore, chennai, delhi'
   rollback transaction;
   end
   end;
   delete from Customer2 where cAddress='Bangalore';
   select * from Customer2

--2. Create a triggers for orders which allows the user to insert only books, cd, mobile  

alter trigger trr2 on Orders2
for insert
as
begin
if exists(select * from inserted where product_name not in ('books','cd','mobile'))
begin
  print 'You Cannot Insert the Values'
  rollback transaction
end
end
 
 insert into  Orders2 values(10101,10120,'2024-12-03','books',500.0,2,600)
select * from orders2

 /**
3. Create a trigger for customer table whenever an item is 
delete from this table. The corresponding item should be 
added in customerhistory table. 
**/
 
create trigger tr_insertintocusthistoy on Customer2
for delete
as
begin
insert into custhistory
select * from deleted
end
delete from Customer2 where customerId=15;
 

 /**
4. Create update trigger for stock. Display old values and new 
values
**/
  
 
create trigger tr_update on Customer2
for update
as
begin
select c.customerId ,c.customerName,c.customerAge,c.cAddress,c.cPhoneNumber,
i.customerId as newid,i.customerName as newname,i.customerAge as newage,i.cAddress as newaddress,c.cPhoneNumber
from Customer2 as c
join inserted as i on c.customerId=i.customerId
end

select * from Customer2;
 
update Customer2 
set cAddress ='Chennai'
where customerId=3;

--5

-- Table A
CREATE TABLE a
(
    custid INT,
    custname VARCHAR(12)
);

-- Table B
CREATE TABLE b
(
    custid INT,
    product VARCHAR(12)
);

 CREATE VIEW testview
AS
SELECT a.*, b.product
FROM a
INNER JOIN b ON a.custid = b.custid;
GO

 CREATE TRIGGER trg_insert_testview
ON testview
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO a (custid, custname)
    SELECT custid, custname
    FROM inserted;
 
    INSERT INTO b (custid, product)
    SELECT custid, product
    FROM inserted;
END;
GO
 
INSERT INTO testview (custid, custname, product)
VALUES (1, 'Amit', 'Laptop');

SELECT * FROM a;
SELECT * FROM b;
SELECT * FROM testview;

