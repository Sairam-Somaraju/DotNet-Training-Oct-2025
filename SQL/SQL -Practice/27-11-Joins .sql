
--Customer
--Orders

--INNER JOIN
select * from Customer
inner join Orders
on Customer.customerId=Orders.custId;

--LEFTOUTER JOIN
select * from Customer a
left outer join Orders b
on a.CustomerId=b.custId;

--RIGHTOUTER JOIN
select * from Customer a
right outer join Orders b
on a. CustomerId=b.custid;

--FULLOUTER JOIN
select * from Customer a
full outer join Orders b
on a.customerId=b.custid;

--CROSS JOIN
select * from Customer 
cross join Orders;

--SELF JOIN
select a.* from Customer a, Customer b
where a.customerAge>b.customerAge
and b.customerName='sairam';


--UNION
select * into newCustomer from Customer
select * from newCustomer

select * from Customer
union
select * from newCustomer


--UNION ALL
select * from Customer
union all
select * from newCustomer


--EXCEPT
select * from Customer
except
select * from newCustomer

--INTERSECT
select * from Customer
intersect
select * from newCustomer


