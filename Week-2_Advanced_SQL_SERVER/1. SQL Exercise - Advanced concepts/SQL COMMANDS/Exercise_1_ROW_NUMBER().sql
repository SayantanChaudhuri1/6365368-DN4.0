
-- ROW_NUM()

SELECT *
FROM (
    SELECT 
        Category,
        ProductName,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;


