 

  select * from Customer where cAddress not in('Ben','Hyd');

  select *from Customer where customerAge >24 AND cAddress not in('Ben');

  select * from Customer where customerName like 'S%';

  select * from Customer where customerName like '%n%';

  select * from Customer where customerName  like '[a-s]%';
                      
  select * from Customer where customerName like '______';
 
  select * from Customer where customerName like 'S_i%m' order by  customerName;

  select DISTINCT customerName from Customer;

  select * from Customer where customerName like 'sa%m' ;

 select *from Customer where customerName is null;
 
 --select * into custhistory from Customer;

     truncate table custhistory;

     select * from custhistory;

     insert into custhistory select * from Customer where customerAge>23;

     select * from custhistory;