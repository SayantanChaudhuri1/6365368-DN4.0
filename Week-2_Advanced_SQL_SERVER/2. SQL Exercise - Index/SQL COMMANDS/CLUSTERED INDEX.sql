SELECT * FROM Orders 
WHERE OrderDate='2023-01-15'
CREATE NONCLUSTERED INDEX IX_Orders_OrderDate ON Orders(OrderDate);
SELECT * FROM Orders  WHERE OrderDate='2023-01-15';