
--CURSORS
/*1.Basic Cursor – Print All Employee Names 
Create a cursor on an Employees table to print each employee’s name one by one.*/
-- 1. Declare variables to hold the data from the cursor
DECLARE @EmpName VARCHAR(50);
 DECLARE EmployeeCursor CURSOR FOR
SELECT EmpName FROM Employees;
 
OPEN EmployeeCursor;
FETCH NEXT FROM EmployeeCursor INTO @EmpName;
WHILE @@FETCH_STATUS = 0
BEGIN
     PRINT @EmpName;
    FETCH NEXT FROM EmployeeCursor INTO @EmpName;
END
 
CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;


/*2. Cursor to Update Salary 
Create a cursor that increases each employee’s salary by 10%. 
Update the table inside the cursor loop. */

-- 1. Declare variables to hold data from cursor
DECLARE @EmpID INT;
DECLARE @CurrentSalary DECIMAL(10,2);

-- 2. Declare cursor to select EmployeeID and Salary
DECLARE SalaryCursor CURSOR FOR
SELECT EmpId, Salary
FROM Employees;
 
OPEN SalaryCursor;
FETCH NEXT FROM SalaryCursor INTO @EmpID, @CurrentSalary;
WHILE @@FETCH_STATUS = 0
BEGIN
     UPDATE Employees
    SET Salary = @CurrentSalary * 1.10
    WHERE EmpId= @EmpID;
    FETCH NEXT FROM SalaryCursor INTO @EmpID, @CurrentSalary;
END
CLOSE SalaryCursor;
DEALLOCATE SalaryCursor;
 
SELECT * FROM Employees;

/*3.Cursor with Conditional Logic 
Fetch all orders. 
While looping: 
• If quantity > 10 → give 5% discount 
• If quantity <= 10 → give 2% discount 
Update each order accordingly.*/
-- 1. Declare variables
DECLARE @OrderID INT;
DECLARE @Quantity INT;
DECLARE @Discount DECIMAL(5,2);

 DECLARE OrdersCursor CURSOR FOR
SELECT orderid, quantity
FROM Orders;
 
OPEN OrdersCursor;
FETCH NEXT FROM OrdersCursor INTO @OrderID, @Quantity;
WHILE @@FETCH_STATUS = 0
BEGIN
     IF @Quantity > 10
        SET @Discount = 5;   -- 5% discount
    ELSE
        SET @Discount = 2;   -- 2% discount

     UPDATE Orders SET price = @Discount WHERE OrderID = @OrderID;
    FETCH NEXT FROM OrdersCursor INTO @OrderID, @Quantity;
END
 
CLOSE OrdersCursor;
DEALLOCATE OrdersCursor;
 
SELECT * FROM Orders;

/*4.Cursor to Copy Data From One Table to Another 
Read records from OldProducts table using a cursor and insert them into NewProducts.*/

CREATE TABLE NewProducts
(
    ProductID INT primary key not null,
    ProductName VARCHAR(50),
    Price int null
);
 DECLARE @ProductID INT;
DECLARE @ProductName VARCHAR(50);
DECLARE @Price int;

 DECLARE CopyCursor CURSOR FOR
SELECT ProductID, ProductName, Price
FROM Products2;

 OPEN CopyCursor;
FETCH NEXT FROM CopyCursor INTO @ProductID, @ProductName, @Price;
 
WHILE @@FETCH_STATUS = 0
BEGIN
     INSERT INTO NewProducts (ProductID, ProductName, Price)
    VALUES (@ProductID, @ProductName, @Price);
    FETCH NEXT FROM CopyCursor INTO @ProductID, @ProductName, @Price;
END
 
CLOSE CopyCursor;
DEALLOCATE CopyCursor;
 
SELECT * FROM NewProducts;


/*5. Cursor to Delete Specific Rows 
Create a cursor that loops through customers. 
Delete customers whose LastOrderDate is more than 2 years old.*/
-- 1. Declare variable
CREATE TABLE Customers
(
    CustomerID INT,
    CustomerName VARCHAR(50),
    LastOrderDate DATE
);

INSERT INTO Customers VALUES
(101, 'Paddu', '2021-05-10'),
(102, 'Triveni', '2023-01-15'),
(103, 'Mamatha', '2020-11-20'),
(104, 'Vinnu', '2022-08-05');
 
 DECLARE @CustomerID INT;
DECLARE @LastOrderDate DATE;

 DECLARE DeleteCursor CURSOR FOR
SELECT CustomerID, LastOrderDate
FROM Customers;

 OPEN DeleteCursor;

 FETCH NEXT FROM DeleteCursor INTO @CustomerID, @LastOrderDate;

 WHILE @@FETCH_STATUS = 0
BEGIN
     IF @LastOrderDate < DATEADD(YEAR, -2, GETDATE())
    BEGIN
        DELETE FROM Customers
        WHERE CustomerID = @CustomerID;
    END

     FETCH NEXT FROM DeleteCursor INTO @CustomerID, @LastOrderDate;
END

 CLOSE DeleteCursor;
DEALLOCATE DeleteCursor;

 SELECT * FROM Customers;
