
 --SUB QUERIES

 --1. display all the records from customers who made a purchase of laptop  
select * from Customer where customerId in(select custid from Orders where products='laptop');

--display all the records from customer who made a purchase of books , toys, cd
select * from Customer where customerId in( select custid from Orders where  products in ('laptop' ,'AC' , 'Mobile'));

--3. display the list of customers who never made any purchase 
select * from Customer where customerId not in(select custid from Orders where products in('laptop'));

--4. display the second highest age from customers (do not use top keyword) 
 select MAX(customerAge) as SecondHighestAge from Customer where CustomerAge<(select MAX (customerAge) from Customer);

 --5. display the list from orders  where customers stays in bangalore 
 select * from Orders where custid in( select customerId from Customer where cAddress='Ben'); 

 --6. display list of customer who made lowest purchase (in terms of quantity) 
select * from Customer where  customerId = ( select custId from Orders where quantity=(select MIN(quantity) from Orders ));

--7. display the list of customer who's age is greater then  ajay's age ( but we dont know ajay's age) 
select * from Customer where customerAge>(select customerAge from Customer where  customerName='sairam');

--8. update customer table where custid =100's age  =     custid=200's age
UPDATE Customer SET customerAge=(select customerAge from Customer where customerId=101)where customerId=102;
 

--9. Display those details who made orders in December of any year 
 select * from Orders where Month(orderdate)=11;

 --10.Show all  orders made before first half of the month (before the 16th of the month who does not reside in bangalore). 
 select * 
 from Orders 
 where day(orderdate) <16
 AND custid IN(
     select customerId
     from Customer
     where cAddress not in ('Ben')
 );


 --11. Display list of customers  from delhi and Bangalore who made purchase of less than 3 product  
 select * 
 from Customer where cAddress in('Vjd', 'Vzg')  and  customerId in(select custId from Orders where quantity<3);


 --12.Display list of orders where price is greater than average price
 select *
 from Orders
 where price>(
 select avg(price)
 from Orders
 );


 --13.. update orders table increasing  price by 10%  for customers residing in Bangalore and who have purchased books.
 update Orders 
 set price =price*1.10
 where products='laptop'
 and custid in(
     select customerId
     from Customer 
     where cAddress='Ben'
 );
     
 --14.Display orderdetails in following format
 select 
 orderdate as "orderId-Date",
 sum(price*quantity) as "Total(price*qty)"
 from Orders group by orderid, orderdate;
