

--1.Display the youngest customer's details.
SELECT * FROM Customer
WHERE customerAge = (SELECT MIN(customerAge) FROM Customer);

--2.Retrieve customers whose phone number ends with '96'.
SELECT * FROM Customer
WHERE cPhonenumber LIKE '%96';

--3.Show the total number of customers from each city (cAddress).
SELECT cAddress, COUNT(*) AS Total_Customers
FROM Customer
GROUP BY cAddress;

--4.Retrieve customers whose name starts with the letter 'S'.
SELECT * FROM Customer
WHERE customerName LIKE 'S%';


--5.Retrieve customers whose age is between 23 and 25 (inclusive).
SELECT * FROM Customer
WHERE customerAge BETWEEN 23 AND 25;

--6Retrieve the oldest customer’s name and age.
SELECT customerName, customerAge
FROM Customer
WHERE customerAge = (SELECT MAX(customerAge) FROM Customer);


--7.Display customers sorted by age in descending order, and for customers with the same age, sort by name alphabetically.
SELECT * 
FROM Customer
ORDER BY customerAge DESC, customerName ASC;

--8.Update the city (cAddress) of customer 'Vinay' to 'Vijayawada'.
UPDATE Customer
SET cAddress = 'Vijayawada'
WHERE customerName = 'Vinay';


--9.Delete customers whose age is less than 23.
DELETE FROM Customer
WHERE customerAge < 23;

--10Find the average age of customers from each city.
SELECT cAddress, AVG(customerAge) AS AverageAge
FROM Customer
GROUP BY cAddress;





