 Alter view v1 with encryption,schemabinding as select customerId,customerName,customerAge,cAddress from dbo.Customer2 where customerAge =23 with check option


 create view v2
 with encryption
 as 
 select customerId,customerName,customerAge from Customer2
 select * from v2

 create view v3
 as
 select customerId,customerName,customerAge
 from dbo.Customer2
 where customerName like '%_%';

 select * from v3;

 create view v4
 with schemabinding
 as
 select customerId,customerName,customerAge
 from dbo.Customer2

 select * from v4;
 -- with aggregate
 WITH getmax(a,b) as(
 select sum(customerAge), cAddress from Customer2 group by cAddress
 )

 
 --without aggregate
 WITH getmax as(
 select customerAge,cAddress from Customer2 group by cAddress)

 select * from getmax

