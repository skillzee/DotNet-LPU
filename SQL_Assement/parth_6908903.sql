create Database Assess1DB;

CREATE TABLE Sales_Raw

(

    OrderID INT,

    OrderDate VARCHAR(20),

    CustomerName VARCHAR(100),

    CustomerPhone VARCHAR(20),

    CustomerCity VARCHAR(50),

    ProductNames VARCHAR(200),   -- Multiple products comma-separated

    Quantities VARCHAR(100),     -- Multiple quantities comma-separated

    UnitPrices VARCHAR(100),     -- Multiple prices comma-separated

    SalesPerson VARCHAR(100)

);





INSERT INTO Sales_Raw VALUES

(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

 

(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',

 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

 

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop', '1', '54000', 'Suresh'),

 

(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',

 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

 

(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',

 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');




 

 -- Q-1
 --Normalisation 

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    CustomerPhone VARCHAR(10),
    CustomerCity VARCHAR(20)
);



CREATE TABLE SalesPerson (
    SalesPersonID INT IDENTITY(1,1) PRIMARY KEY,
    SalesPersonName VARCHAR(100) NOT NULL
);

 

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(20) NOT NULL
);



CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT NOT NULL,
    SalesPersonID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (SalesPersonID) REFERENCES SalesPerson(SalesPersonID)
);


CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);







INSERT INTO Customers (CustomerName, CustomerPhone, CustomerCity)
SELECT DISTINCT
    CustomerName,
    CustomerPhone,
    CustomerCity
FROM Sales_Raw;




INSERT INTO SalesPerson(SalesPersonName)
SELECT DISTINCT SalesPerson
FROM Sales_Raw;








INSERT INTO Products (ProductName)
SELECT DISTINCT TRIM(value) AS ProductName
FROM Sales_Raw
CROSS APPLY STRING_SPLIT(ProductNames, ',');





INSERT INTO Orders (OrderID, OrderDate, CustomerID, SalesPersonID)
SELECT 
    sr.OrderID,
    CAST(sr.OrderDate AS DATE),
    c.CustomerID,
    sp.SalesPersonID
FROM Sales_Raw sr
JOIN Customers c
    ON sr.CustomerName = c.CustomerName
   AND sr.CustomerPhone = c.CustomerPhone
JOIN SalesPerson sp
    ON sr.SalesPerson = sp.SalesPersonName;




    INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
SELECT 
    sr.OrderID,
    p.ProductID,
    CAST(q.value AS INT) AS Quantity,
    CAST(u.value AS DECIMAL(10,2)) AS UnitPrice
FROM Sales_Raw sr

CROSS APPLY (
    SELECT value, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) rn
    FROM STRING_SPLIT(sr.ProductNames, ',')
) pr

CROSS APPLY (
    SELECT value, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) rn
    FROM STRING_SPLIT(sr.Quantities, ',')
) q

CROSS APPLY (
    SELECT value, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) rn
    FROM STRING_SPLIT(sr.UnitPrices, ',')
) u

JOIN Products p
    ON TRIM(pr.value) = p.ProductName

WHERE pr.rn = q.rn
  AND q.rn = u.rn;





 select * from Sales_Raw;
 Select * from SalesPerson;
 select * from Products;
 Select * from Customers;
 select * from orders;
 select * from OrderDetails;


 WITH OrderTotals AS (
    SELECT 
        OrderID,
        SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
    FROM Sales_Raw
    CROSS APPLY STRING_SPLIT(Quantities, ',') q
    CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
    GROUP BY OrderID
),
RankedOrders AS (
    SELECT *,
           DENSE_RANK() OVER (ORDER BY TotalSales DESC) AS rnk
    FROM OrderTotals
)
SELECT OrderID, TotalSales
FROM RankedOrders
WHERE rnk = 3;




SELECT 
    sp.SalesPersonName,
    SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM SalesPerson sp
JOIN Orders o
    ON sp.SalesPersonID = o.SalesPersonID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
GROUP BY sp.SalesPersonName
HAVING SUM(od.Quantity * od.UnitPrice) > 60000;






SELECT 
    c.CustomerName,
    SUM(od.Quantity * od.UnitPrice) AS TotalSpent
FROM Customers c
JOIN Orders o
    ON c.CustomerID = o.CustomerID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
GROUP BY c.CustomerName
HAVING SUM(od.Quantity * od.UnitPrice) >
(
    SELECT AVG(CustomerTotal)
    FROM (
        SELECT 
            SUM(od2.Quantity * od2.UnitPrice) AS CustomerTotal
        FROM Orders o2
        JOIN OrderDetails od2
            ON o2.OrderID = od2.OrderID
        GROUP BY o2.CustomerID
    ) avg_table
);




SELECT 
    UPPER(c.CustomerName) AS CustomerName,
    DATENAME(MONTH, o.OrderDate) AS OrderMonth,
    o.OrderDate,
    o.OrderID
FROM Orders o
JOIN Customers c
    ON o.CustomerID = c.CustomerID
WHERE 
    YEAR(o.OrderDate) = 2026
    AND MONTH(o.OrderDate) = 1;


