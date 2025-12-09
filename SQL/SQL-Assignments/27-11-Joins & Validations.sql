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

select * from Customer2