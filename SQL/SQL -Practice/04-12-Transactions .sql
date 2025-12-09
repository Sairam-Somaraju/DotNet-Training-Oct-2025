
--TRANSACTION
/*1. Basic Transaction — Commit / Rollback 
Create a table BankAccount with sample records. 
Write a transaction that transfers money from one account to another. 
If the source account balance becomes negative, roll back the transaction; otherwise 
commit.*/

CREATE TABLE BankAccount (
    AccountNo INT PRIMARY KEY,
    HolderName VARCHAR(100),
    Balance DECIMAL(10,2)
);
Insert Into BankAccount Values
(101, 'Sairam', 15000),
(102, 'Paddu', 8000),
(103, 'Vinnu', 2000);

Declare @Transformoney Decimal(10,2)=5000;
Declare @SourceAc int=101;
Declare @TargetAc int=102;

 Begin Transaction
 Update BankAccount Set Balance=Balance-@Transformoney where AccountNo=@SourceAc;

  Declare @CurrentBalance Decimal(10,2);
  Select @CurrentBalance=Balance From BankAccount where AccountNo=@SourceAc;

If(@CurrentBalance<0)
Begin 
   print @CurrentBalance;
   Print'Error: Insufficient Balance.Transaction Rolled Back';
   Rollback
    End
    Else
    Begin
   Update BankAccount Set Balance =Balance+@Transformoney where AccountNo=@TargetAc;
   Print 'Transaction Successfully.Money Transefered';
   Commit;
End
select *from BankAccount
----------------------------------------------------------------------------------
/* 2. Using SAVEPOINT 
Insert three new records into a table Orders. 
Create a SAVEPOINT after each insert. 
Rollback only the second insert using the SAVEPOINT, then commit the remaining inserts.*/
Create Table Orders3 (
    OrderID Int PRIMARY KEY,
    CustomerName Varchar(100),
    Amount Decimal(10,2)
);
Begin Transaction;
 insert into Orders3 values(101,'Sairam',1200.0);
 Save Transaction Save1;

 insert into Orders3 values(102,'Rajesh',1500.0);
 Save Transaction Save2;

 insert into Orders3 values(103,'Karthik',1800.0);
 Save Transaction Save3;

 Rollback Transaction Save1;
 insert into Orders3 values(103,'Karthik',1800.0);
 Commit;

 select * from Orders3

 -----------------------------------------------------------------------------------------------------------------
 /* 3. Handling Errors with TRY…CATCH 
Write a transaction that updates prices in a Products table. 
Introduce a division-by-zero error inside the transaction. 
Use TRY…CATCH to rollback the transaction and log the error message in a separate 
ErrorLog table */
 
  create table storelogs
  (
    logid int identity(1,1),
    errormessage varchar(100),
    errordate date
   )
 
    begin try
    begin transaction
    update BankAccount set Balance = Balance + 1000 where AccountNo = 101
    declare @n int = 10/0
    commit transaction
    end try
    begin catch
    rollback transaction
    insert into storelogs values(error_message(),getdate())
    print 'Error Occured : '+error_message()
    end
    catch
 
   select * from storelogs

 -----------------------------------------------------------------------------------------------------------
 /* 4. Nested Transactions 
Create nested transactions: 
• Outer transaction inserts a customer 
• Inner transaction inserts an order for the customer 
• Force an error in the inner transaction 
Practice observing whether the outer transaction is committed or rolled back. */

 
 Create Table Customers1 (
    CustomerID Int Identity Primary Key,
    CustomerName Nvarchar(100) NOT NULL
);
Create Table Orders1 (
    OrderID Int Identity Primary Key,
    CustomerID Int NOT NULL,
    OrderAmount Decimal (10,2) NOT NULL
);
select * from customers1;
select * from Orders1;
 
 begin transaction
    insert into customers1 (customername)values('Ram')
    declare  @customerid int = scope_identity()
      begin transaction
      begin try
      insert into
    Orders1(customerid,OrderAmount)values(@customerid,2300)
       declare @y int=1/0
       commit transaction
       end try
       begin catch
       rollback transaction
       print 'rolled back the entire transaction due to inner error'+ERROR_MESSAGE();
       end catch
 -------------------------------------------------------------------------------
 /*
 5.Isolation Level – Dirty Read 
Use two sessions: 
• Session 1: Open a transaction, update a row, but don’t commit 
• Session 2: Use SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED and read 
the same row 
Check whether dirty reads are allowed.*/
 
select * from Orders2
 
set transaction isolation level read uncommitted
select * from Orders2 where order_id = 102
waitfor delay '00:00:05'
select * from Orders2 where  order_id=102
 
  --- dirty read ---
begin transaction
update Orders2 set quantity = 3 where order_id = 102
 
/* 6. Isolation Level – Non-repeatable Read 
Using two sessions: 
• Session 1 reads a row twice inside a transaction 
• Session 2 updates and commits the same row in between 
Observe changes and understand non-repeatable reads. */
 
set transaction isolation level repeatable read
begin transaction
select * from Orders2 where order_id = 102
waitfor delay '00:00:10'
select * from Orders2 where order_id = 102
commit transaction

--- non repetable read ---
begin transaction
update Orders2 set quantity = 3 where order_id = 102
commit transaction 

/* 
7. Isolation Level – Phantom Read 
Create a table Sales. 
Using two sessions: 
• Session 1 selects rows between a range inside a transaction 
• Session 2 inserts a new row within the range and commits 
See if the first session sees new rows depending on isolation level. */

Set Transaction Isolation Level Read Committed;
Begin Transaction;
Select * from Sales where SaleAmount BETWEEN 90000 AND 100000;
Insert into Sales values (6, 6,'East',67000,'2023-10-23');  
COMMIT;   
select * from Sales where SaleAmount BETWEEN 90000 AND 100000;
Commit;

/* 8.Savepoint with Partial Rollback 
Inside a transaction: 
• Update 5 employee salaries 
• Create a savepoint after each update 
• Rollback to savepoint 3 
• Commit the rest 
Check which rows were updated finally.*/
 Begin Transaction;
Update Employees set Salary = Salary + 1000 where EmpId =1;
Save transaction S1;

Update Employees set Salary = Salary + 1000 where EmpId =2;
Save transaction S2;

Update Employees set Salary = Salary + 1000 where EmpId =3;
Save transaction S3;

Update Employees set Salary = Salary + 1000 where EmpId =4;
Save transaction S4;

Update Employees set Salary = Salary + 1000 where EmpId =5;
Save transaction S5;

Rollback transaction s3;
commit;

select * from Employees

/*9.Insert multiple product records using a single transaction. 
Force an error in one insert (duplicate key or null value). 
Ensure that no records are inserted into the table. */

CREATE TABLE Products2(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price INT
);
Begin try
    begin transaction;
    Insert into Products2 values (1, 'Laptop', 50000);
    Insert into Products2 values (2, 'Mouse', 8000);
    Insert into Products2 values (1, 'keyboard', 75000);

 commit;
 end try
 begin catch
       rollback;
       print'Error occured. All inserts rolled back';
       end catch;
select * from Products2;

/* 10.Savepoint in TRY…CATCH 
Inside a long transaction: 
• Insert 3 orders 
• Savepoint after each 
• Force an error before the third insert 
Use savepoint rollback to keep first 2 inserts.*/
 
CREATE TABLE Orders4 (
    OrderID INT PRIMARY KEY,
    Customer NVARCHAR(50) NOT NULL,
    Amount DECIMAL(10,2) NOT NULL
);
 
SELECT * FROM Orders4;
  Begin Try
    Begin Transaction;
    Insert Into Orders4(OrderID, Customer, Amount)
    Values(101, 'Asha', 1500.00);
    Save Transaction sp1;
 
    Insert Into Orders4(OrderID, Customer, Amount)
    Values (102, 'Bala', 2750.00);
    Save Transaction sp2;

     Insert Into Orders4(OrderID, Customer, Amount)
    Values(103, NULL, 3200.00);  
Commit;  
end try
Begin catch

    IF @@TRANCOUNT > 0
    Begin
         Rollback transaction sp2;  
         Commit;                   
     end
     Select ERROR_NUMBER() as ErrorNumber, ERROR_MESSAGE() as ErrorMessage;
 end catch;
 
Select * from Orders4 ORDER BY OrderID;
 
 