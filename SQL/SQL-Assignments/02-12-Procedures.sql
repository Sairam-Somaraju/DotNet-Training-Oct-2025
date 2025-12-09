PROCEDURES
---------

--1. Create a procedure which accepts input parameter and inserts the data in the customer table. 
create procedure InsertCustomer(@CustomerId int ,@CustomerName varchar(200))
AS
BEGIN
insert into Customer2(CustomerID,CustomerName)
values(@CustomerID,@CustomerName)
END;
EXEC  InsertCustomer
@CustomerID=102,
@CustomerName='karthik'

 select * from Customer2
 --------------------------------------------------------------------------------------------------------

 --2.  Create a procedure for orders table , which displays all the purchase made between  1-12-2005  and 2-12-2007 (Accept date as parameter_)
 create procedure GetOrdersByDateRange(@startdate Date,@EndDate Date)
 As
 BEGIN
  select * from Orders2
  where order_date Between @startdate And @EndDate
  END;

  EXEC GetOrdersByDateRange '2025-01-01','2025-12-31'
  ---------------------------------------------------------------------------------------------------

  --3. create a procedure which reads custid as parameter and return qty and produtid as output parameter
   alter procedure GetOrders(@customer_id int, @order_id Int output,@quantity int output)
	As
	begin
	select order_id,quantity from Orders2 where customer_id=@customer_id
	end;

	Declare @P int,@Q int;
	exec GetOrders
	@customer_id=1,
	@order_id=@P output,
	@quantity =@Q output;
	print @P
	print @Q

 ---------------------------------------------------------------------------------------------------------------------
   --4 Write a batch that will check for the existence of the productnam “books” if it exists, display the total stock of the book else print  “productname books not found”. 
   
	create procedure pro4 
	As
	begin
	if exists(select 1 from Orders2 where product_name ='keyboard')
	begin
	  select sum (order_id)  as totalproduct from Products where product_name = 'keyboard'
	end
	else
	begin
	  print 'Product book not found'
	end
	end
	exec pro4
 
 ----------------------------------------------------------------------------------------
--5.insert  data to customer table via return value of sp_getdata() procedure 
 
	alter PROCEDURE sp_getdata
	AS
	BEGIN
		Declare @newCustId int=111;
		return @newCustId;
	END;
	DECLARE @customerId INT;
	EXEC @customerId = sp_getdata;    
	 INSERT INTO Customer2 (customerId, customerName, customerAge,cAddress,cPhoneNumber)
	VALUES (@customerId, 'Sai',24,'Vizag',9010362642); 

select *from Customer2

--------------------------------------------------------------------------------------
--6. Create a procedure to display all customer details where rownumber between 2 to 5 (accept row number as a parameter)
create procedure  GetCustomerByRow(@startRow int, @EndRow int)
AS
 begin
  select * from (select *, ROW_NUMBER() over (Order by CustomerId) AS RowNum From Customer2) AS T
  where RowNum Between @startRow And @EndRow;
  End;

  --7
  CREATE TABLE Employees2
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Department NVARCHAR(50) NOT NULL,
    Salary DECIMAL(18, 2) NOT NULL
);

CREATE PROCEDURE spAddEmployee
    @Name NVARCHAR(100),
    @Department NVARCHAR(50),
    @Salary DECIMAL(18, 2),
    @NewEmployeeID INT OUTPUT
AS
BEGIN
    -- Insert the new employee record
    INSERT INTO Employees2 (Name, Department, Salary)
    VALUES (@Name, @Department, @Salary);

    -- Get the newly generated EmployeeID
    SET @NewEmployeeID = SCOPE_IDENTITY();
END;
DECLARE @EmpID INT;

EXEC spAddEmployee
    @Name = 'John Doe',
    @Department = 'IT',
    @Salary = 60000,
    @NewEmployeeID = @EmpID OUTPUT;

-- Display the new EmployeeID
SELECT @EmpID AS NewEmployeeID;

--8CREATE PROCEDURE spGetProductsByCategory
    
	CREATE PROCEDURE spGetProductsByCategory
    @product_name NVARCHAR(100) = 'Electronics'
WITH ENCRYPTION
AS
BEGIN
    SELECT *
    FROM Products
    WHERE product_name = @product_name;
END;
EXEC spGetProductsByCategory;
EXEC spGetProductsByCategory @product_name = 'Keyboard';


--9
ALTER PROCEDURE spSafeOrderInsert
    @product_name NVARCHAR(100),
    @order_date DATE,
    @total_amount DECIMAL(18,2)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Orders2(product_name, order_date, total_amount)
        VALUES (@product_name, @order_date, @total_amount);
    END TRY
    BEGIN CATCH
        INSERT INTO ErrorLog (ErrorMessage, ErrorProcedure, ErrorLine)
        VALUES (
            ERROR_MESSAGE(),
            ERROR_PROCEDURE(),
            ERROR_LINE()
        );
    END CATCH
END;

EXEC spSafeOrderInsert 
    @product_name = 'bag',
    @order_date = GETDATE(),
    @total_amount = 500.00;

