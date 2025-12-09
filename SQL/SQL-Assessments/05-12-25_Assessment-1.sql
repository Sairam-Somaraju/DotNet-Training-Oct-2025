create database Assessments

--Customer table
create table Customersx( 
    custId INT PRIMARY KEY, 
    CustName VARCHAR(100), 
    Email VARCHAR(200), 
    City VARCHAR(100) 
)
INSERT INTO Customersx(custId, CustName, Email, City) VALUES
(1, 'Amit Sharma', 'amit.sharma@gmail.com', 'Mumbai'),
(2, 'Ravi Kumar', 'ravi.kumar@yahoo.com', 'Delhi'),
(3, 'Priya Singh', 'priya.singh@gmail.com', 'Pune'),
(4, 'John Mathew', 'john.mathew@hotmail.com', 'Bangalore'),
(5, 'Sara Thomas', 'sara.thomas@gmail.com', 'Kochi'),
(6, 'Nidhi Jain', 'nidhi.jain@gmail.com', NULL);

 --Products table
 create table Productsx( 
    ProductID INT PRIMARY KEY, 
    ProductName VARCHAR(100), 
    Price DECIMAL(10,2), 
    Stock INT CHECK(Stock >= 0) 
) 
INSERT INTO Productsx(ProductID, ProductName, Price, Stock) VALUES
(101, 'Laptop Pro 14', 75000, 15),
(102, 'Laptop Air 13', 55000, 8),
(103, 'Wireless Mouse', 800, 50),
(104, 'Mechanical Keyboard', 3000, 20),
(105, 'USB-C Charger', 1200, 5),
(106, '27-inch Monitor', 18000, 10),
(107, 'Pen Drive 64GB', 600, 80);

--Orders table
create table Ordersx( 
    OrderID INT PRIMARY KEY, 
    CustID INT FOREIGN KEY REFERENCES Customersx(CustID), 
    OrderDate DATE, 
    Status VARCHAR(20) 
) 

INSERT INTO Ordersx(OrderID, CustID, OrderDate, Status) VALUES
(5001, 1, '2025-01-05', 'Pending'),
(5002, 2, '2025-01-10', 'Completed'),
(5003, 1, '2025-01-20', 'Completed'),
(5004, 3, '2025-02-01', 'Pending'),
(5005, 4, '2025-02-15', 'Completed'),
(5006, 5, '2025-02-18', 'Pending');

--OrderDetails table
create table OrderDetails( 
    DetailID INT PRIMARY KEY, 
    OrderID INT FOREIGN KEY REFERENCES Ordersx(OrderID), 
    ProductID INT FOREIGN KEY REFERENCES Productsx(ProductID), 
    Qty INT CHECK(Qty > 0) 
)

INSERT INTO OrderDetails(DetailID, OrderID, ProductID, Qty) VALUES
(9001, 5001, 101, 1),
(9002, 5001, 103, 2),
 
(9003, 5002, 104, 1),
(9004, 5002, 103, 1),
 
(9005, 5003, 102, 1),
(9006, 5003, 105, 1),
(9007, 5003, 103, 3),
 
(9008, 5004, 106, 1),
 
(9009, 5005, 107, 4),
(9010, 5005, 104, 1),
 
(9011, 5006, 101, 1),
(9012, 5006, 107, 2);

--Payments Table
create table Payments( 
    PaymentID INT PRIMARY KEY, 
    OrderID INT FOREIGN KEY REFERENCES Ordersx(OrderID), 
    Amount DECIMAL(10,2), 
    PaymentDate DATE 
) 
INSERT INTO Payments(PaymentID, OrderID, Amount, PaymentDate) VALUES
(7001, 5002, 3300, '2025-01-11'),
(7002, 5003, 62000, '2025-01-22'),
(7003, 5005, 4500, '2025-02-16');

=========================================================================================================

--SQL Queries
/*Q1. List customers who placed an order in the last 30 days. 
(Use joins) */

select distinct C.custId, C.CustName, C.Email, C.City, O.OrderDate
from Customersx C
join Ordersx O on C.custId = O.CustID
where O.OrderDate >= dateadd(day, -300, getdate());


/*Q2. Display top 3 products that generated the highest total sales amount. 
(Use aggregate + joins) */
select ProductID, ProductName, TotalSalesAmount
from ( select  P.ProductID, P.ProductName, sum(OD.Qty * P.Price) as TotalSalesAmount,
            row_number() over (order by sum(OD.Qty * P.Price) desc) as rn FROM OrderDetails OD
        join Productsx P ON OD.ProductID = P.ProductID
        group by P.ProductID, P.ProductName
     ) as T
where rn <= 3;


--Q3. For each city, show number of customers and total order count. 
select C.City,count(distinct C.custId) AS NumberOfCustomers,count(O.OrderID) AS TotalOrders
from Customersx C
left join Ordersx O on C.custId = O.CustID
group by C.City;


--Q4. Retrieve orders that contain more than 2 different products. 
select OrderID
from OrderDetails
group by OrderID
having count(distinct ProductID) > 2;


/*Q5. Show orders where total payable amount is greater than 10,000. 
(Hint: SUM(Qty * Price)) */
select OD.OrderID,sum(OD.Qty * P.Price) as TotalAmount
from OrderDetails OD
join Productsx P on OD.ProductID = P.ProductID
group by OD.OrderID
having sum(OD.Qty * P.Price) > 10000;


--Q6. List customers who ordered the same product more than once. 
select C.custId, C.CustName,OD.ProductID,count(*) as NoOfTimesOrdered
from Customersx C
join Ordersx O on C.custId = O.CustID
join OrderDetails OD on O.OrderID = OD.OrderID
group by C.custId, C.CustName, OD.ProductID
 having count(*) > 1;

 /*Q7. Display employee-wise order processing details 
(Assume Orders table has EmployeeID column)*/
create table Employeesx(
    EmployeeID int primary key,
    EmpName varchar(100)
);
insert into Employeesx(EmployeeID, EmpName) values
(1, 'sairam'),
(2, 'prudhvi'),
(3, 'karthik'),
(4, 'rajesh'),
(5, 'venkat');
 
alter table Ordersx add EmployeeID int;
update Ordersx set EmployeeID = 1 where OrderID IN (5001, 5003);
update Ordersx set EmployeeID = 2 where OrderID IN (5002);
update Ordersx set EmployeeID = 3 where OrderID IN (5004);
update Ordersx set EmployeeID = 4 where OrderID IN (5005);
update Ordersx set EmployeeID = 5 where OrderID IN (5006);
 
select  E.EmployeeID,E.EmpName,O.OrderID,O.OrderDate,O.Status
from Employeesx E
join Ordersx O on E.EmployeeID = O.EmployeeID
order by E.EmployeeID, O.OrderID;

=======================================================================================================
--VIEWS
/*1. Create a view vw_LowStockProducts 
Show only products with stock < 5. 
View should be WITH SCHEMABINDING and Encrypted */
create view vw_StockProducts
with schemabinding, encryption
as
select ProductID,ProductName,Price,Stock
from dbo.Productsx
where Stock < 5;

select * from vw_StockProducts;

--FUNCTIONS
/*1. Create a table-valued function: fn_GetCustomerOrderHistory(@CustID) 
Return: OrderID, OrderDate, TotalAmount. */
create function fn_GetCustomerOrderHistory(@CustID int)
returns table
as
return 
(
   select O.OrderID,O.OrderDate,SUM(OD.Qty * P.Price) as TotalAmount from Ordersx O
    join OrderDetails OD on O.OrderID = OD.OrderID
    join Productsx P on OD.ProductID = P.ProductID
    where O.CustID = @CustID
    group by O.OrderID, O.OrderDate
);

select * from fn_GetCustomerOrderHistory(1);

/*2. Create a function fn_GetCustomerLevel(@CustID) 
Logic: 
• Total purchase > 1,00,000 → "Platinum" 
• 50,000–1,00,000 → "Gold" 
• Else → "Silver" */
create function fn_GetCustomerLevel(@CustID int)
returns varchar(20)
as
begin
    declare @TotalPurchase decimal(18,2);
    declare @CustomerLevel varchar(20);
    select @TotalPurchase = sum(OD.Qty * P.Price) from Ordersx O
    join OrderDetails OD on O.OrderID = OD.OrderID
    join Productsx P on OD.ProductID = P.ProductID
    where O.CustID = @CustID;

     if @TotalPurchase > 100000
        set @CustomerLevel = 'Platinum';
     else if @TotalPurchase >= 50000
        set @CustomerLevel = 'Gold';
     else
        set @CustomerLevel = 'Silver';
    return @CustomerLevel;
end;

 select  dbo.fn_GetCustomerLevel(1) as CustomerLevel;
 
 =========================================================================================================
 --PROCEDURES
 /*1. Create a stored procedure to update product price 
Rules: 
• Old price must be logged in a PriceHistory table 
• New price must be > 0 
• If invalid, throw custom error.*/
create table  PriceHistory (
    HistoryID int identity(1,1) primary key,
    ProductID int,
    OldPrice decimal(10,2),
    ChangedDate datetime default GETDATE()
);
create procedure sp_UpdateProductPrice(@ProductID int, @NewPrice decimal(10,2))
as
begin
     if @NewPrice <= 0
    begin
        print 'Invalid price. New price must be greater than 0.';
        return;
    end

     insert into  PriceHistory (ProductID, OldPrice)
    select ProductID, Price from Productsx where  ProductID = @ProductID;
 
    update Productsx set Price = @NewPrice where ProductID = @ProductID;
end;
 
 exec sp_UpdateProductPrice @ProductID = 101, @NewPrice = 80000;
 exec sp_UpdateProductPrice @ProductID = 102, @NewPrice = -500;
 
 select * from PriceHistory

 /*2. Create a procedure sp_SearchOrders 
Search orders by: 
• Customer Name 
• City 
• Product Name 
• Date range 
(Any parameter can be NULL → Dynamic WHERE)*/
create procedure sp_SearchOrders(
    @CustomerName nvarchar(100) = NULL,
    @City nvarchar(100) = NULL,
    @ProductName nvarchar(100) = NULL,
    @StartDate date = NULL,
    @EndDate date = NULL
    )
as
begin
   select O.OrderID,O.OrderDate,C.CustName,C.City,P.ProductName,OD.Qty,P.Price,(OD.Qty * P.Price) as TotalAmount,
   O.Status FROM Ordersx O
    join Customersx C on O.CustID = C.CustID
    join OrderDetails OD on O.OrderID = OD.OrderID
    join Productsx P on OD.ProductID = P.ProductID
    where 
        (@CustomerName is null or C.CustName like '%' + @CustomerName + '%')
        and (@City is null or C.City like '%' + @City + '%')
        AND (@ProductName is null or P.ProductName like '%' + @ProductName + '%')
        AND (@StartDate is null or O.OrderDate >= @StartDate)
        AND (@EndDate is null or O.OrderDate <= @EndDate)
    order by O.OrderDate, O.OrderID;
end ;

exec sp_SearchOrders @CustomerName = 'Amit';
exec sp_SearchOrders @City = 'Mumbai', @StartDate = '2025-01-01', @EndDate = '2025-01-31';
exec sp_SearchOrders @ProductName = 'Laptop';

====================================================================================================================
--TRIGGERS
/*1. Create a trigger on Products 
Prevent deletion of a product if it is part of any OrderDetails.*/
alter trigger trg_PreventProductDeletion
on  Productsx
instead of  delete 
as
begin
    if exists(
      select od.ProductID  from deleted d join OrderDetails od on d.ProductID = od.ProductID
    )
    begin
         print 'Error: Cannot delete product. It exists in OrderDetails.';
        rollback transaction;
        return;
    end
end;

delete from  Productsx where ProductID = 106;
delete from  Productsx where ProductID = 107;


/*2. Create an AFTER UPDATE trigger on Payments 
Log old and new payment values into a PaymentAudit table.*/

create table PaymentAudit (
    AuditID int identity(1,1) primary key,
    PaymentID int,
    OldAmount decimal(10,2),
    NewAmount decimal(10,2),
    OldDate date,
    NewDate date,
    ChangedOn datetime default getdate()
);

alter trigger trg_PaymentAudit
on Payments
after update
as
begin
     insert into PaymentAudit (PaymentID, OldAmount, NewAmount, OldDate, NewDate)
    select
        d.PaymentID,
        d.Amount as OldAmount,
        i.Amount as NewAmount,
        d.PaymentDate as OldDate,
        i.PaymentDate as NewDate
    from deleted d
    join inserted i on d.PaymentID = i.PaymentID;
end;
 
 update Payments set Amount = 7000, PaymentDate = '2025-02-20' where PaymentID = 7003;

 select * from PaymentAudit;


 /*3. Create an INSTEAD OF DELETE trigger on Customers 
Logic: 
• If customer has orders → mark status as “Inactive” instead of deleting 
• If no orders → allow deletion*/
  alter table Customersx add Status varchar(20) default 'Active';
   
 alter trigger trg_CustomersInsteadOfDelete
on Customersx
instead of delete
as 
begin
     update C set Status = 'Inactive' from Customersx C
    join deleted d on C.CustID = d.CustID
   where exists ( select O.CustID from Ordersx O where O.CustID = d.CustID );
    delete C from Customersx C
    join deleted d on C.CustID = d.CustID
    where NOT EXISTS (select  O.CustID from Ordersx O where O.CustID = d.CustID
    );
end;
  
delete from  Customersx where CustID = 1;
delete from  Customersx where CustID = 3;
select  CustID, CustName, Status from  Customersx order by CustID;
 
 select * from Customersx










