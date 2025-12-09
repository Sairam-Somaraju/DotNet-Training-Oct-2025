
---------------------TASK-1-------------------
alter procedure sp_GetEmployeesByDOJ(@d1 date,@d2 date)
as
begin
    select EmpID, EmpName, Salary, DateOfJoin 
    FROM Employee
    WHERE DateOfJoin BETWEEN @d1 AND @d2;
end

select*from Employee
select *from Department
---------------TASK-2--------------------------

create procedure sp_GetCommonRecords(@id int)
as
begin
select e.EmpID, e.EmpName, e.Salary, e.DateOfJoin ,d.DeptID,d.DeptName
    FROM Employee e
    inner join Department d
    on e.DeptID =d.DeptID
    where d.DeptID=@id
    end
 ----------------------TASK-5--------------------

 CREATE PROCEDURE sp_GetEmployeesAndDepartments
AS
BEGIN
    -- 1️⃣ First Result Set: Employees
    SELECT EmpID, EmpName, Salary, DateOfJoin, DeptID
    FROM Employee;

    -- 2️⃣ Second Result Set: Departments
    SELECT DeptID, DeptName
    FROM Department;
END

-------------------------TASK-6-------------------------

CREATE PROCEDURE sp_GetEmployeeDet
 @EmpID INT,
 @DateofJoin DATE OUTPUT,
 @Department NVARCHAR(50) OUTPUT
AS
BEGIN
    SELECT 
        @DateofJoin = DateOfJoin,
        @Department = DeptName
    FROM Employee e
    INNER JOIN Department d ON e.DeptID = d.DeptID
    WHERE e.EmpID = @EmpID;
END


 select*from Employee
select *from Department