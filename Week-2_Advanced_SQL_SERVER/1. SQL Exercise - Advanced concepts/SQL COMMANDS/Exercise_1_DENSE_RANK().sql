SELECT *
FROM (
    SELECT 
        Category, ProductName, Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
    FROM Products
) AS RankedProducts
WHERE DenseRank <= 3;
