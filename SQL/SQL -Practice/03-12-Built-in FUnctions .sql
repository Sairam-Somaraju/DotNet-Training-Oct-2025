--String Functions
--LEN()
SELECT LEN('SQL Server') AS LengthResult;

-- CONCAT()
SELECT CONCAT('Hello ', 'World') AS FullText;

 --REPLACE()
SELECT REPLACE('SQL SERVER TRAINING', 'SERVER', 'Database') AS NewText;

--SUBSTRING()
SELECT SUBSTRING('Microsoft SQL Server', 11, 3) AS ExtractedText;
-- Output: SQL


select SUBSTRING('helloworld',2,3)

 --UPPER()
SELECT UPPER('sql server') AS UpperCaseText;

-- LOWER()
SELECT LOWER('SQL SERVER') AS LowerCaseText;

-- RIGHT()
SELECT RIGHT('SQLSERVER', 6) AS LastCharacters;
-- Output: SERVER

--LEFT()
SELECT LEFT('DATABASE', 4) AS FirstCharacters;
-- Output: DATA


--Aggregate Functions


CREATE TABLE Sales2(
   Id INT,
   Amount INT
);

INSERT INTO Sales VALUES
(1, 100), (2, 300), (3, 250), (4, 150);

--MAX()
SELECT MAX(Amount) AS MaxAmount FROM Sales2;

--MIN()
SELECT MIN(Amount) AS MinAmount FROM Sales2;

-- SUM()
SELECT SUM(Amount) AS TotalAmount FROM Sales2;

-- COUNT()
SELECT COUNT(*) AS TotalRows FROM Sales2;

-- AVG()
SELECT AVG(Amount) AS AverageAmount FROM Sales2;

-- Numeric Functions
--SQRT()
SELECT SQRT(144) AS SquareRoot;

-- ROUND()
SELECT ROUND(123.4567, 2) AS RoundedValue;
-- Output: 123.46

 select POWER(2, 3);
-- Output: 8

-- RAND()
SELECT RAND() AS RandomNumber;       -- Random number between 0 and 1

select getdate()
--date function
SELECT DATENAME(year, GETDATE()) as Year,
       DATENAME(week, GETDATE()) as Week,
       DATENAME(dayofyear, GETDATE()) as DayOfYear,
       DATENAME(month, GETDATE()) as Month,
       DATENAME(day, GETDATE()) as Day,
       DATENAME(weekday, GETDATE()) as WEEKDAY



SELECT DATEADD(DAY, 10, '2024-01-01');
SELECT DATEADD(MONTH, -2, '2024-06-15');
SELECT DATEADD(YEAR, 1, GETDATE())


select DATEDIFF(DAY, '2024-01-01', '2024-01-02')
SELECT DATEDIFF(YEAR, '2010-01-01', GETDATE());
SELECT DATEDIFF(MONTH, '2024-01-01', '2024-06-01');

--Cast Functions
--1). CAST Function

declare @x int 
set @x=10
print 'you have entered ' +cast(@x as varchar) -- This is not exact  formatting

--2).CONVERT Function
print 'you have entered '+ convert (varchar(10),@x) -- This is the exact formatting 

--what is formatting
declare @a date
set @a='1-1-2000'
print 'you have entered '+convert(varchar(10),@a,111)
print 'you have entered '+convert(varchar(10),@a,109)
print 'you have entered '+convert(varchar(10),@a,112)
print 'you have entered '+convert(varchar(10),@a,113)
print 'you have entered '+convert(varchar(10),@a,108)

---Scaler Function
alter function fn_add(@a int, @b int)
returns int
as
begin
declare @c int
set @c=@a* @b
return @c 
end

--how to return the function
select dbo.fn_add(10,20)as Multiplication


--Inline Function
Create function fn_getStudents(@a varchar(20))
returns table
as
return (
select * from Customer2 where cAddress=@a
)

select * from fn_getStudents('Delhi');

--Function along with JOINS
create  function test()
returns  table
as
return(
select c.customerId,c.customerName,c.cAddress,o.product_name,o.order_id,o.order_date,o.quantity
from Customer2 c join Orders2 o on c.customerId=o.customer_id
)
select * from dbo.test()

--Multi statement tale valued function

Create function fn_Employess
  (@length nvarchar(9))
  returns @tbl_Employees TABLE