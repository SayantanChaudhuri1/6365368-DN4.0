SELECT *
FROM (
    SELECT 
        Category,
        ProductName,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;
