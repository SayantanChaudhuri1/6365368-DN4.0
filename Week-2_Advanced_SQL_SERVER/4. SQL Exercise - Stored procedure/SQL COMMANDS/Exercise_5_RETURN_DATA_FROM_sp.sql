-- If you had some statements above, separate them with GO
GO

CREATE PROCEDURE sp_GetEmployeeCount
  @DepartmentID INT
AS
BEGIN
  SELECT COUNT(*) AS EmployeeCount
  FROM Employees
  WHERE DepartmentID = @DepartmentID;
END;
GO

-- Now execute the stored procedure
EXEC sp_GetEmployeeCount @DepartmentID = 2;
