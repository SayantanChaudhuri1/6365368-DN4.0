SELECT * FROM Products WHERE ProductName = 'Laptop';

CREATE NONCLUSTERED INDEX IX_Products_ProductName
ON Products(ProductName);

SELECT * FROM Products WHERE ProductName = 'Laptop';