
--EMPLOYEE TABLE 
CREATE TABLE Employees 
( 
    EmpId INT PRIMARY KEY, 
    EmpName VARCHAR(100), 
    DeptId INT, 
    ManagerId INT NULL, 
    JoinDate DATE, 
    Salary DECIMAL(10,2) 
); 
 
INSERT INTO Employees VALUES 
(1, 'Amit', 10, NULL, '2020-01-10', 65000), 
(2, 'Neha', 10, 1,    '2022-02-15', 50000), 
(3, 'Ravi', 20, 1,    '2023-03-12', 45000), 
(4, 'Sana', 20, 3,    '2024-01-20', 42000), 
(5, 'Karan', 30, 1,   '2021-07-18', 55000);

select * from Employees

--DEPARTMENTS
CREATE TABLE Departments 
( 
    DeptId INT PRIMARY KEY, 
    DeptName VARCHAR(100) 
); 
 
INSERT INTO Departments VALUES 
(10, 'IT'), 
(20, 'HR'), 
(30, 'Finance')

select * from Departments

--SALES TABLE
CREATE TABLE Sales 
( 
    SaleId INT PRIMARY KEY, 
    EmpId INT, 
    Region VARCHAR(50), 
    SaleAmount DECIMAL(10,2), 
    SaleDate DATE 
); 
 
INSERT INTO Sales VALUES 
(1, 1, 'North', 100000, '2024-01-01'), 
(2, 2, 'North',  90000, '2024-01-10'), 
(3, 3, 'South', 120000, '2024-02-05'), 
(4, 4, 'South', 120000, '2024-02-20'), 
(5, 5, 'North', 110000, '2024-03-15');
select * from Sales

--TRANSACTION TABLE
CREATE TABLE Transactions 
( 
    TransId INT PRIMARY KEY, 
    AccountId INT, 
    Amount DECIMAL(10,2), 
    TransDate DATE 
); 
 
INSERT INTO Transactions VALUES 
(1, 101, 1000, '2024-01-01'), 
(2, 101, 2000, '2024-02-01'), 
(3, 101, -500, '2024-03-01'), 
(4, 102, 1500, '2024-01-15'), 
(5, 102, -200, '2024-03-10');

select * from Transactions


--1)Write a query using CASE to categorize salary levels on Employees table: 
SELECT 
   EmpId,
   EmpName,
   Salary,
    CASE 
        WHEN Salary < 20000 THEN 'Low'
        WHEN Salary BETWEEN 20000 AND 50000 THEN 'Medium'
        WHEN Salary>50000 THEN 'High'
    END AS SalStatus
FROM Employees;

---- TASK-2 ----
Declare @Age int =30;
 if  @Age<18
    print 'minor';
Else if @Age Between 18 and 60
    Print 'Adult';
Else
    print 'Senior';

---- Task-3 ----

Create View dbo.ViewEmployeeDetails
WITH SCHEMABINDING, ENCRYPTION
AS
SELECT 
   E.EmpId,
   E.EmpName,
   E.DeptId,
   D.DeptName,
   E.JoinDate,
   E.Salary,
   AnnualSalary=E.Salary*12
From dbo.Employees AS E
INNER JOIN dbo.Departments AS D
 ON E.DeptId=D.DeptId
WHERE E.JoinDate>='2022-12-01';

select *from ViewEmployeeDetails;
  
 ---- TASK -4 ----
 --Joins Employees + Sales 
 --Shows total sales per employee 
  --Shows rank based on total sales across company 
 CREATE VIEW dbo.ViewEmployeeSalesRank
AS
SELECT 
    E.EmpId,
    E.EmpName,
      (SELECT SUM(S.SaleAmount) 
     FROM dbo.Sales S 
     WHERE S.EmpId = E.EmpId) AS TotalSales,
     RANK() OVER (
        ORDER BY 
            (SELECT SUM(S2.SaleAmount)
             FROM dbo.Sales S2 
             WHERE S2.EmpId = E.EmpId) DESC
    ) AS SalesRank
FROM dbo.Employees E;

select * from ViewEmployeeSalesRank;


---- Task -5 ----
--Attempts dividing by zero 
--Catches the error 
--Prints error details 
BEGIN TRY
    DECLARE @x INT = 10;
    DECLARE @y INT = 0;
    DECLARE @result INT;

    SET @result = @x / @y;   
END TRY
BEGIN CATCH
    PRINT 'Error Occurred!';
      PRINT 'Error Message: ' + ERROR_MESSAGE();
END CATCH;

---- Task -6 ----
--If salary < 1000, throw custom error using THROW. 
--Declare variable  to simulate salary 

        BEGIN try
        declare @salary int
        set @salary =200
        if(@salary<1000)
        BEGIN
        THROW 50001,'not valid',1
        END
        Print 'salary not valid'
        END try
        BEGIN catch
            print error_message();
        END catch;

 ---- TASK -7 ----
 -- Compare Rank / Dense_Rank / Row_Number 
 -- Identify top 2 per region 

  SELECT 
    S.Region,
    E.EmpId,
    E.EmpName,
    S.TotalSales,
     RANK() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS RankSales,
    DENSE_RANK() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS DenseRankSales,
    ROW_NUMBER() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS RowNumSales
FROM dbo.Employees E
JOIN (
    SELECT EmpId, Region, SUM(SaleAmount) AS TotalSales
    FROM dbo.Sales
    GROUP BY EmpId, Region
) S ON E.EmpId = S.EmpId
ORDER BY S.Region, S.TotalSales DESC;

---- TASK-8 -----
--First CTE: Filter only last 1 year sales 
--Second CTE: Compute total sales per region 
--Third CTE: Rank regions based on total sales 
--Output top 3 regions 
 WITH LastYearSales AS (
    SELECT *FROM dbo.Sales
    WHERE SaleDate >= '2024-01-01'  
),
RegionSales AS (
    SELECT  Region, SUM(SaleAmount) AS TotalSales
    FROM LastYearSales
    GROUP BY Region
),
RankedRegions AS (
    SELECT  Region,TotalSales,
    RANK() OVER (ORDER BY TotalSales DESC) AS RegionRank
    FROM RegionSales
)
SELECT *
FROM RankedRegions
WHERE RegionRank <= 3
ORDER BY RegionRank;

---- Task-9 ----
 
 SELECT e.EmpId,
       e.EmpName,
       e.DeptId,
       d.DeptName,
       s.SaleAmount,
       s.SaleId,
       s.Region,
       s.SaleDate
FROM Employees e
JOIN Sales s ON e.EmpId = s.EmpId
JOIN Departments d ON e.DeptId = d.DeptId
WHERE (e.DeptId, s.SaleAmount) IN (
    SELECT e2.DeptId, s2.SaleAmount
    FROM Employees e2
    JOIN Sales s2 ON e2.EmpId = s2.EmpId
    GROUP BY e2.DeptId, s2.SaleAmount
    HAVING COUNT(*) > 1
)
ORDER BY e.DeptId, s.SaleAmount;
