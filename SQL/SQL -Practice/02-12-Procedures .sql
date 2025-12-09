

create procedure getcustomers
as
select * from Customer2

--to execute procedure
getcustomers

--To create simple procedure with parameter
Create procedure getbyaddress(@a varchar(20))
as
select * from Customer2 where cAddress=@a

getbyaddress 'Delhi'

-- to drop the procedure

drop procedure getbyaddress

--procedure can contain simple logic without queries as well
create procedure AddProduct(@a int, @b int)
as
print   @a+@b

AddProduct 10, 20

--procedure with return value
create Procedure Addproduct2(@a int, @b int)
as
return @a+@b

declare @result int
exec @result=Addproduct2 10,20
print @result


--Procedure return multiple values
alter procedure Addproduct3(@a int, @b int, @c int output, @d int output)
as
set @c=@a+@b
set @d=@a*@b

declare @m int
declare @n int 

exec Addproduct3 10,20,@m output, @n output
print @m
print @n


--How to create procedure with try/catch block
create procedure divide(@a int, @b int)
as
begin try
print @a/@b
end try
begin catch
print 'Error Occured : '+error_message()
end catch

divide 10,0


--How to Excute the procedure with insert command
insert into Customer2 exec getbyaddress 'Delhi'

select * from Customer2

create table testing
(
custid int identity (10,20),
custname varchar(20),
age int 
)

insert into testing values('Sairam','24')
insert into testing values('Vennela',23)
select * from testing

create procedure myProc(@cname varchar(20), @age int)
as
insert into testing values(@cname, @age)
return scope_identity()

--i want to know what values has beeen assigned for custid
declare @res int
exec @res=myproc 'sairam',23
print @res
 
create procedure displaydata(@tbl varchar(20))
as
declare @myquery nvarchar(100)
set @myquery='select * from '+@tbl
exec sp_executesql @myquery 

displaydata 'Students'