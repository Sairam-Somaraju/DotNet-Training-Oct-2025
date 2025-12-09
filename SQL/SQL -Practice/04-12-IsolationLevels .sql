

--ISOLATION LEVELS


create table test1(
custid int,
custname varchar(20)
)
insert into test1 values(100,'Dhoni')
insert into test1 values(101,'Raina')
 
 set transaction isolation level read uncommitted
select * from test1 where custid=100
waitfor delay '00:00:10'
select * from test1 where custid=100

begin transaction
update test1 set custname='kohli'
where custid=101

--Read commited demo
set transaction isolation level read committed
select * from test1 where custid=100
waitfor delay '00:00:10'
select * from test1 where custid=100

begin transaction 
update test1 set custname ='Rohit'
where custid=100

--Repeatable Read Demo

Set transaction isolation level Repeatable Read
begin transaction 
select * from test1 where custid=101
waitfor delay '00:00:5'
select * from test1 where custid=101

commit transaction
begin transaction
update test1 set custname='manikanata'
where custid=101
commit
