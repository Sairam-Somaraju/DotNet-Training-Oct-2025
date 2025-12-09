
--ORDERS2 TABLE
CREATE TABLE Orders2 (
    order_id      INT PRIMARY KEY,
    customer_id   INT,
    order_date    DATE,
    product_name  VARCHAR(100),
    price         DECIMAL(10),
    quantity      INT  ,
    total_amount  DECIMAL(10),    
);

INSERT INTO Orders2 
(order_id, customer_id, order_date, product_name, price, quantity, total_amount)
VALUES
(101, 1, '2025-01-15', 'Wireless Mouse', 100, 2, 200 ),
(102, 3, '2023-07-16', 'Keyboard', 250, 3, 800 ),
(103, 2, '2024-08-17', 'Headphones', 700, 4, 282 ),
(104, 4, '2019-01-18', 'USB-C Charger',900, 3, 890),
(105, 1, '2025-01-19', 'Laptop Stand', 62.05, 5, 310 );


--CUSTOMER2 TABLE
CREATE TABLE Customer2 (
    customerId INT PRIMARY KEY,
    customerName VARCHAR(20),
    customerAge TINYINT,
    cAddress VARCHAR(20),
    cPhoneNumber BIGINT
);

INSERT INTO Customer2 (customerId, customerName, customerAge, cAddress, cPhoneNumber)
VALUES
(1, 'Sairam', 25, 'Hyderabad', 9876543210),
(2, 'Siva', 30, 'Mumbai', 9988776655),
(3, 'Venkat', 22, 'Chennai', 9123456780),
(4, 'Vinnu', 24, 'Bangalore', 9090909090),
(5, 'Paddu', 21, 'Delhi', 9911223344);

  --1. Write a query to display the custid ,name, age, orderid,orderdate for product books or cd, sort data by name in descending order 
   select c.customerId,c.customerName,c.customerAge ,o.order_id,o.order_date from Customer2 c
   join Orders2 o
   on c.customerId=o.customer_id
   where  o.product_name IN ('Laptop Stand', 'Keyboard')
   Order by c.customerName  desc;

   --2. Write a SQL statement to find the list of customers who live in the same city as ajay, and display custid , custname , price (price > 500)
   select c.customerId,c.customerName, o.price from  Customer2 c
   join Orders2 o
   on c.customerId=o.customer_id
   where cAddress=(select cAddress from Customer2 where customerName='Siva')
   and o.price>250;
   
   
   --3. Write a query to find the name of customers along with order details who purchased   more than two products 
   select c.customerName,o.order_id,o.order_date,o.product_name,o.price,o.quantity from Customer2 c
   join Orders2 o
   on c.customerId=o.customer_id
   where quantity>2

   --4. A discount of 20% has been announced to all customers who resides in Bangalore . display custid , custname , orderid  and discount price 
   
  select c.customerId,c.customerName,o.order_id,(o.price -(o.price * 20 / 100) ) as [Discount Price] from Customer2  c
    join Orders2  o
  on c.customerId=o.customer_id
    where c.cAddress='Bangalore';
 

  --5. write a query to join three tables (create products table for the same) 

          create table Products
        (
        productid int,
        custid int,
        product varchar(20)
        );
 
        insert into Products values
        (1,1,'Notebook'),
        (2,2,'Pen Set'),
        (3,3,'USB Cable'),
        (4,4,'Mouse'),
        (5,5,'Keyboard'),
        (6,6,'Pen Set'),
        (7,7,'Notebook');
 
        select * from Customer2;
        select * from Orders2;
        select * from Products;
 
        SELECT *
        FROM Customer2 c
        JOIN Orders2 o
            ON c.customerId = o.customer_id
        JOIN Products p
            ON o.customer_id = p.custid;


 --6. update price by 5% from orders table for customers who resides in pune and chennai 
  
        update Orders2
        set price= price+price*0.05 
        where price in (select o.price  from Orders2  o
        join Customer2 c
        on
        c.customerId=o.customer_id
        where c.cAddress in ('Hyderabad','Delhi'));

          select* from Customer2
          select *from Orders2


--7  1. Custname should be uppercase 
--   2. Display only first 3 character of product 
--   3.The report should be of December 2000 

        select concat('cid:',c.customerId,'-','ordid:',o.order_id) as Custidord,

        upper(c.customerName) as Custname,left(o.product_name,3) as Product,o.price,o.order_date from Customer2 as c

        join Orders2 as o

        on  c.customerId=o.customer_id
         
        where month(o.order_date)=01 and year(o.order_date)=2025;

--8) Validations 
 
  --STUDENT TABLE

CREATE TABLE Students (
    StudentRollNumber INT IDENTITY(100,100) PRIMARY KEY,
    StudentName VARCHAR(50),
    DOB DATE,
    Class INT
);

INSERT INTO Students (StudentName, DOB, Class)
VALUES 
('Dhoni', '2025-12-12', 8),
('Raina', '2007-07-15', 6),
('Kohli', '2005-11-20', 9),
('Sachin', '2008-04-05', 5),
('Rohit', '2009-09-12', 7);

select * from Students

--a. DOB cannot be greater then current date 
ALTER TABLE Students
ADD CONSTRAINT chk_dob CHECK (DOB <= GETDATE());

--b. Class should be between 1 - 10
ALTER TABLE Students
ADD CONSTRAINT chk_class CHECK (Class BETWEEN 1 AND 10);


 --9
CREATE TABLE Stock (
    StockId VARCHAR(20),
    MinStockLvl INT,
    MaxStockLvl INT
);
select * from Stock

--The MaxStockLvl should be Greater than MinStockLvl. 
ALTER TABLE Stock
ADD CONSTRAINT chk_stock_levels 
CHECK (MaxStockLvl > MinStockLvl);

--Start with 3 alphabets following by – followed by 2 digit followed by – and ending with 3 alphabets . 
ALTER TABLE Stock
ADD CONSTRAINT chk_stockid_format
CHECK (StockId LIKE '[S-Zs-Z][S-Za-z][A-Zs-Z]-[0-9][0-9]-[S-Zs-Z][S-Zs-Z][S-Zs-Z]');


--10 PURCHASE TABLE 
-- Create rules for Qty and Price
CREATE RULE QtyRule AS @Qty > 1;
CREATE RULE PriceRule AS @Price BETWEEN 1000 AND 7000;

-- Create the table
CREATE TABLE Purchase
(
    ProductID INT NOT NULL,
    PurchaseDate DATE NOT NULL DEFAULT GETDATE(),  -- Default system date
    SerialNo INT NOT NULL UNIQUE,                 -- Unique serial number
    Price DECIMAL(10,2) NOT NULL,                -- Price
    Qty INT NOT NULL,                             -- Quantity
    Total AS (Price * Qty)                        -- Total auto-generated
);
select * from Purchase

-- Bind rules to the columns
EXEC sp_bindrule 'QtyRule', 'Purchase.Qty';
EXEC sp_bindrule 'PriceRule', 'Purchase.Price';








