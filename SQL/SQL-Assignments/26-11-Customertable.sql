create table Orders
(
 custid int,
 orderid int,
 orderdate varchar(20),
 products varchar(20),
 price int,
 quantity int

)

insert into Orders values(101,1,'25-11-25','TV',30000,2),
							(102,2,'26-11-25','laptop',50000,3),
							(103,3,'21-11-25','AC',45000,1),
							(104,4,'23-11-25','Fridge',28000,4),
							(105,5,'30-11-25','Mobile',22000,6);
 --10. List orders details where qty falling in the range 100-200  and 700-1200					 
 select * from Orders where  (quantity BETWEEN 1 AND 4) AND (quantity BETWEEN 2 AND 6);

 --12. Display what each  price would be if a 20% price increase were to take place. Show the custid , old price and new price ,using meaningful headings(use orders table)  
 select 
    custid AS CustomerID,
    price AS OldPrice,
    price + (price * 20 / 100) AS NewPrice
 from Orders;

 --13. Display top 3 highest qty from orders table
 select Top 3 *from Orders Order by quantity Desc ;

 --14. Display how many times customers have purchased a product (display count and customerid from orders table)
 select custid,
    COUNT(*) AS PurchaseCount
    from Orders
    GROUP BY custid;

--15. Display the list of orders who’s orders made earlier then 5 years from now
select * from orders where year(getdate()) - year('orderdate')>1;

--17  Display orderdetails in following format 
--OrderID-Date Total(price*qty) 
--100-1/1/2000 500 
select orderdate as OrderIDDate, (price*quantity) as Total
from Orders

--18  Update orders table by decreasing price by 20% for qty > 50
UPDATE Orders
SET price = price - (price * 20 / 100)  
WHERE quantity > 50;

--19. You want to retrieve data for all the orders who made order  '1-12-90' having price 4000 – 6000 and sort the column in descending order on price 
select * from Orders where orderdate='26-11-25' and price between 30000 and 60000 order by price desc
 
--20 Display order details in following format 
--Custid Price (sum of price) Count (count of qty) 
--1 5000 3 
--2 4000 9 
--3 6700 6
select custid, sum(price) as SumOfPrice, Count(quantity) as CountofQty from Orders Group by custid;

--21. Display above details only for price > 4000
select *from Orders where price>30000;

